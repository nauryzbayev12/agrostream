using Company.Delivery.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Company.Delivery.Database.ModelConfigurations;

internal class CargoItemConfiguration : IEntityTypeConfiguration<CargoItem>
{
    public void Configure(EntityTypeBuilder<CargoItem> builder)
    {

        builder.HasData(
                 new CargoItem
                 {
                     Id = Guid.Parse("2936A77A-D491-4CFB-8047-A809ACF2AD5E"),
                     WaybillId = Guid.Parse("BBB2AFB6-8ECF-4F63-9F98-71C3FC1B5F33"),
                     Number = "2023-A-1/01",
                     Name = "Box"
                 },
                 new CargoItem
                 {
                     Id = Guid.Parse("FEA616D3-75B1-49C7-86CE-65107BFE3DFC"),
                     WaybillId = Guid.Parse("BBB2AFB6-8ECF-4F63-9F98-71C3FC1B5F33"),
                     Number = "2023-A-1/02",
                     Name = "Pallet"
                 }
        );
    }
}