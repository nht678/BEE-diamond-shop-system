using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class fix_type_masterPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterPrices");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "GoldPrices",
                type: "datetimeoffset",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

            migrationBuilder.CreateTable(
                name: "GoldMasterPrice",
                columns: table => new
                {
                    GoldMasterPriceId = table.Column<string>(type: "varchar(20)", nullable: false),
                    GoldPriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldStorePrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoldMasterPrice", x => x.GoldMasterPriceId);
                    table.ForeignKey(
                        name: "FK_GoldMasterPrice_GoldPrices_GoldPriceId",
                        column: x => x.GoldPriceId,
                        principalTable: "GoldPrices",
                        principalColumn: "GoldPriceId");
                });

            migrationBuilder.CreateTable(
                name: "StoneMasterPrice",
                columns: table => new
                {
                    StoneMasterPriceId = table.Column<string>(type: "varchar(20)", nullable: false),
                    StonePriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    StoneStorePrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoneMasterPrice", x => x.StoneMasterPriceId);
                    table.ForeignKey(
                        name: "FK_StoneMasterPrice_StonePrices_StonePriceId",
                        column: x => x.StonePriceId,
                        principalTable: "StonePrices",
                        principalColumn: "StonePriceId");
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6552), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6555), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6663), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6666), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6669), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 25, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6486), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6444), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 25, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6494), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6493), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 25, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6498), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6497), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6706), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6708), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "3",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6711), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6629), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6632), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 15, 9, 32, 13, 196, DateTimeKind.Unspecified).AddTicks(6635), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_GoldMasterPrice_GoldPriceId",
                table: "GoldMasterPrice",
                column: "GoldPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_StoneMasterPrice_StonePriceId",
                table: "StoneMasterPrice",
                column: "StonePriceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoldMasterPrice");

            migrationBuilder.DropTable(
                name: "StoneMasterPrice");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "GoldPrices",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MasterPrices",
                columns: table => new
                {
                    MasterPriceId = table.Column<string>(type: "varchar(20)", nullable: false),
                    GoldPriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    StonePriceId = table.Column<string>(type: "varchar(20)", nullable: true),
                    GoldStorePrice = table.Column<float>(type: "real", nullable: false),
                    StoneStorePrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterPrices", x => x.MasterPriceId);
                    table.ForeignKey(
                        name: "FK_MasterPrices_GoldPrices_GoldPriceId",
                        column: x => x.GoldPriceId,
                        principalTable: "GoldPrices",
                        principalColumn: "GoldPriceId");
                    table.ForeignKey(
                        name: "FK_MasterPrices_StonePrices_StonePriceId",
                        column: x => x.StonePriceId,
                        principalTable: "StonePrices",
                        principalColumn: "StonePriceId");
                });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "1",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: "2",
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7571), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7662), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7664), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "GoldPrices",
                keyColumn: "GoldPriceId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "1",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7535), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7507), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "2",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7541), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7540), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: "3",
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 24, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7544), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7543), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "1",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7686), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "2",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7688), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: "3",
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7690), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "1",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7637), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "2",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7639), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "StonePrices",
                keyColumn: "StonePriceId",
                keyValue: "3",
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 14, 18, 46, 39, 881, DateTimeKind.Unspecified).AddTicks(7641), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "IX_MasterPrices_GoldPriceId",
                table: "MasterPrices",
                column: "GoldPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_MasterPrices_StonePriceId",
                table: "MasterPrices",
                column: "StonePriceId");
        }
    }
}
