using AutoMapper;
using Company.Delivery.Core;
using Company.Delivery.Database;
using Company.Delivery.Domain;
using Company.Delivery.Domain.Dto;
using Microsoft.EntityFrameworkCore;

namespace Company.Delivery.Infrastructure;

public class WaybillService : IWaybillService
{
    private readonly IMapper _mapper;
    private readonly DeliveryDbContext _db;
    public WaybillService(DeliveryDbContext db,
        IMapper mapper)
    {
        _mapper = mapper;
        _db = db;
    }

    public async Task<WaybillDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var res = await _db.Waybills.Include(s => s.Items).FirstOrDefaultAsync(s => s.Id == id, cancellationToken: cancellationToken);

        if (res == null)
        {
            throw new EntityNotFoundException();
        }
        var ev = _mapper.Map<WaybillDto>(res);

        return ev;
    }

    public async Task<WaybillDto> CreateAsync(WaybillCreateDto data, CancellationToken cancellationToken)
    {
        var ev = _mapper.Map<Waybill>(data);
        await _db.Waybills.AddAsync(ev, cancellationToken);
        await _db.SaveChangesAsync(cancellationToken);
        var res = _mapper.Map<WaybillDto>(ev);
        return res;
    }

    public async Task<WaybillDto> UpdateByIdAsync(Guid id, WaybillUpdateDto data, CancellationToken cancellationToken)
    {
        var res = await _db.Waybills.Include(s => s.Items).FirstOrDefaultAsync(s => s.Id == id, cancellationToken: cancellationToken);

        if (res == null)
        {
            throw new EntityNotFoundException();
        }

        _mapper.Map(data, res);

        _db.Waybills.Update(res);
        _db.SaveChanges();

        var res1 = _mapper.Map<WaybillDto>(data);

        var waybillDto = new WaybillDto();
        return res1;

    }

    public Task DeleteByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var res = _db.Waybills.Include(s => s.Items).FirstOrDefault(s => s.Id == id);

        if (res == null)
        {
            throw new EntityNotFoundException();
        }

        _db.Waybills.Remove(res);
        _db.SaveChanges();

        return Task.CompletedTask;
    }
}