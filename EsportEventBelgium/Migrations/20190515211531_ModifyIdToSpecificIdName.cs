using Microsoft.EntityFrameworkCore.Migrations;

namespace EsportEventBelgium.Migrations
{
    public partial class ModifyIdToSpecificIdName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Organizations",
                newName: "OrganizationId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Games",
                newName: "GameId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Events",
                newName: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrganizationId",
                table: "Organizations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Games",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Events",
                newName: "Id");
        }
    }
}
