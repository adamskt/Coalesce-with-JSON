using Microsoft.EntityFrameworkCore.Migrations;

namespace Json.Test.Data.Migrations
{
    public partial class ShortDescriminators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Inspection",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "FieldWork",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.Sql(@"ALTER TABLE Inspection
ADD CONSTRAINT [_MetaDataIsJson]
CHECK (ISJSON(_MetaData)=1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Inspection",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "FieldWork",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.Sql(@"ALTER TABLE Inspection
DROP CONSTRAINT [_MetaDataIsJson]");
        }
    }
}
