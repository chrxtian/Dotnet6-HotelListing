using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class AddDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca228a5c-ec61-4480-bbd8-b82bcbf0d4bd", "da8b7f60-ca6a-4b46-ab89-745c8cfc43ef", "Administrator", "ADMINSTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dda8ce9d-86ed-4dc5-92ac-8e0996f24719", "227e42cf-b1bb-4c6d-8b6c-5e6ada9bf6ca", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca228a5c-ec61-4480-bbd8-b82bcbf0d4bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dda8ce9d-86ed-4dc5-92ac-8e0996f24719");
        }
    }
}
