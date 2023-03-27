using Company.Delivery.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.Delivery.Database.ModelConfigurations;

internal class WaybillConfiguration : IEntityTypeConfiguration<Waybill>
{
    public void Configure(EntityTypeBuilder<Waybill> builder)
    {
        builder.HasData(
                new Waybill
                {
                    Id = Guid.Parse("BBB2AFB6-8ECF-4F63-9F98-71C3FC1B5F33"),
                    Number = "2023-A-1",
                    Date = new DateTime(2023, 01, 01),

                }
       );
    }
}