using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Company.Delivery.Core;

[Index("Number", "WaybillId", IsUnique = true, Name = "Number_WaybillId_Index")]
public class CargoItem
{
    public Guid Id { get; set; }


    [ForeignKey(nameof(Waybill))]
    public Guid WaybillId { get; set; }
    public Waybill? Waybill { get; set; }


    [StringLength(50)]
    public string Number { get; set; } = null!;

    [StringLength(50)]
    public string Name { get; set; } = null!;
}