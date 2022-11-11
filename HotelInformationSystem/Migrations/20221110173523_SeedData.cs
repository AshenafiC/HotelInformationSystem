using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelInformationSystem.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "Name", "ShortName" },
                values: new object[] { 1, "Ethiopia", "ET" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "Name", "ShortName" },
                values: new object[] { 2, "Kenya", "KN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "Name", "ShortName" },
                values: new object[] { 3, "Sudan", "SN" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 1, "Addis Ababa", 1, "Ilily Hotel", 4.7999999999999998 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 2, "Nairobi", 2, "Sheraton Hotel", 4.7000000000000002 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "id", "Address", "CountryId", "Name", "Rating" },
                values: new object[] { 3, "Khartum", 3, "Hilton", 4.9000000000000004 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
