using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObjects.Migrations
{
    /// <inheritdoc />
    public partial class JssatsV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CounterId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8870), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8873), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8959), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8964), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8967), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8995), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(9003), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(9006), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8832), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8802), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8840), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8838), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8843), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(8842), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(9033), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 38, 48, 712, DateTimeKind.Unspecified).AddTicks(9035), new TimeSpan(0, 7, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CounterId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: 1,
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1309), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "BillId",
                keyValue: 2,
                column: "SaleDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1313), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1393), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1397), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Gems",
                keyColumn: "GemId",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1400), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1468), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1471), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Golds",
                keyColumn: "GoldId",
                keyValue: 3,
                column: "LastUpdated",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1473), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1271), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1239), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1279), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1278), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "PromotionId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 7, 2, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1283), new TimeSpan(0, 7, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1281), new TimeSpan(0, 7, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1502), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "PurchaseId",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTimeOffset(new DateTime(2024, 6, 22, 14, 34, 22, 462, DateTimeKind.Unspecified).AddTicks(1504), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
