using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeePortal.Data.Migrations
{
    public partial class Add_House_MedicalAllowance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyPay",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<decimal>(
                name: "HouseAllowance",
                table: "Employees",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MedicalAllowance",
                table: "Employees",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HouseAllowance",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MedicalAllowance",
                table: "Employees");

            migrationBuilder.AlterColumn<double>(
                name: "HourlyPay",
                table: "Employees",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "Bonus",
                table: "Employees",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
