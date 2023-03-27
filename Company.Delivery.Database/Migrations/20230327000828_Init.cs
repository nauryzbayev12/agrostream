using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Company.Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Waybills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Waybills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargoItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    WaybillId = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoItems_Waybills_WaybillId",
                        column: x => x.WaybillId,
                        principalTable: "Waybills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Waybills",
                columns: new[] { "Id", "Date", "Number" },
                values: new object[] { new Guid("bbb2afb6-8ecf-4f63-9f98-71c3fc1b5f33"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2023-A-1" });

            migrationBuilder.InsertData(
                table: "CargoItems",
                columns: new[] { "Id", "Name", "Number", "WaybillId" },
                values: new object[,]
                {
                    { new Guid("2936a77a-d491-4cfb-8047-a809acf2ad5e"), "Box", "2023-A-1/01", new Guid("bbb2afb6-8ecf-4f63-9f98-71c3fc1b5f33") },
                    { new Guid("fea616d3-75b1-49c7-86ce-65107bfe3dfc"), "Pallet", "2023-A-1/02", new Guid("bbb2afb6-8ecf-4f63-9f98-71c3fc1b5f33") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoItems_WaybillId",
                table: "CargoItems",
                column: "WaybillId");

            migrationBuilder.CreateIndex(
                name: "Number_WaybillId_Index",
                table: "CargoItems",
                columns: new[] { "Number", "WaybillId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Number_Index",
                table: "Waybills",
                column: "Number",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoItems");

            migrationBuilder.DropTable(
                name: "Waybills");
        }
    }
}
