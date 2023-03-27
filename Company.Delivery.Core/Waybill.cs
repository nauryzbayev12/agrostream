using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Company.Delivery.Core;

[Index("Number", IsUnique = true, Name = "Number_Index")]
public class Waybill
{
    public Guid Id { get; set; }
    [StringLength(50)]
    public string Number { get; set; } = null!;

    public DateTime Date { get; set; }

    public ICollection<CargoItem>? Items { get; set; }
}