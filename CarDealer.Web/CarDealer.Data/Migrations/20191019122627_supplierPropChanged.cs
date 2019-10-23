using Microsoft.EntityFrameworkCore.Migrations;

namespace CarDealer.Web.Data.Migrations
{
    public partial class supplierPropChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Namae",
                table: "Suppliers",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Suppliers",
                newName: "Namae");
        }
    }
}
