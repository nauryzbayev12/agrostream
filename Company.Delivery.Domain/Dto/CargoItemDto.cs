using System.ComponentModel.DataAnnotations;

namespace Company.Delivery.Domain.Dto;

public class CargoItemDto
{
    public Guid Id { get; init; }

    public Guid WaybillId { get; init; }
    [StringLength(50)]
    public string Number { get; init; } = null!;
    [StringLength(50)]
    public string Name { get; init; } = null!;
}