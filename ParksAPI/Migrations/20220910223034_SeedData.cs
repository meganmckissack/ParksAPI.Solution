using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "City", "Feature", "ParkName", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Coos Bay", "yurts", "Bullards Beach", "Oregon", "State" },
                    { 2, "The Dalles", "fishing", "Cottonwood Canyon", "Oregon", "State" },
                    { 3, "Astoria", "swimming", "Fort Stevens State Park", "Oregon", "State" },
                    { 4, "Crater Lake", "biking", "Crater Lake", "Oregon", "National" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);
        }
    }
}
