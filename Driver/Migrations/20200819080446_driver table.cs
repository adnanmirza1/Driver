using Microsoft.EntityFrameworkCore.Migrations;

namespace Driver.Migrations
{
    public partial class drivertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityName",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfBirth",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateOfJoining",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DriverType",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportExpiryDate",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassportNo",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ResidenceCountry",
                table: "DriverBasics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisaExpiry",
                table: "DriverBasics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "CityName",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "Company",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "DateOfJoining",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "DriverType",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "PassportExpiryDate",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "PassportNo",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "ResidenceCountry",
                table: "DriverBasics");

            migrationBuilder.DropColumn(
                name: "VisaExpiry",
                table: "DriverBasics");
        }
    }
}
