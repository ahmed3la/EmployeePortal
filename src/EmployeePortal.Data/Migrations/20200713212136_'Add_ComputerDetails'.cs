using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeePortal.Data.Migrations
{
    public partial class Add_ComputerDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComputerDetails",
                table: "Employees",
                type: "varchar(250)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComputerDetails",
                table: "Employees");
        }
    }
}
