using System.ComponentModel.DataAnnotations;

namespace Company.Delivery.Domain.Dto;

public class WaybillDto
{
    public Guid Id { get; init; }

    [StringLength(50)]
    public string Number { get; init; } = null!;

    public DateTime Date { get; init; }

    public IEnumerable<CargoItemDto>? Items { get; init; }
}