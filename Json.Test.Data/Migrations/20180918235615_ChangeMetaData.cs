using Microsoft.EntityFrameworkCore.Migrations;

namespace Json.Test.Data.Migrations
{
    public partial class ChangeMetaData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "_MetaData",
                table: "Inspection",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "_MetaData",
                table: "Inspection");
        }
    }
}
