using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class Update_Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "client_id",
                table: "Clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "client_id",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
