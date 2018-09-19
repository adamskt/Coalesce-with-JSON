using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Json.Test.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FieldWork",
                columns: table => new
                {
                    FieldWorkId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FieldCompletionDateTime = table.Column<DateTimeOffset>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    MeterVoltage = table.Column<string>(maxLength: 20, nullable: true),
                    NumberOfDials = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldWork", x => x.FieldWorkId);
                });

            migrationBuilder.CreateTable(
                name: "Inspection",
                columns: table => new
                {
                    InspectionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentFieldWorkFieldWorkId = table.Column<long>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    LiveAuditQuestion1 = table.Column<bool>(nullable: true),
                    LiveAuditQuestion2 = table.Column<bool>(nullable: true),
                    PostInstallQuestion1 = table.Column<bool>(nullable: true),
                    PostInstallQuestion2 = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection", x => x.InspectionId);
                    table.ForeignKey(
                        name: "FK_Inspection_FieldWork_ParentFieldWorkFieldWorkId",
                        column: x => x.ParentFieldWorkFieldWorkId,
                        principalTable: "FieldWork",
                        principalColumn: "FieldWorkId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_ParentFieldWorkFieldWorkId",
                table: "Inspection",
                column: "ParentFieldWorkFieldWorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inspection");

            migrationBuilder.DropTable(
                name: "FieldWork");
        }
    }
}
