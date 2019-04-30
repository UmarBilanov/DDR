using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiamondDrillingReport.Migrations
{
    public partial class HoleStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Hole",
                newName: "HoleStatusID");

            migrationBuilder.CreateTable(
                name: "HoleStatus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoleStatus", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hole_HoleStatusID",
                table: "Hole",
                column: "HoleStatusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hole_HoleStatus_HoleStatusID",
                table: "Hole",
                column: "HoleStatusID",
                principalTable: "HoleStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hole_HoleStatus_HoleStatusID",
                table: "Hole");

            migrationBuilder.DropTable(
                name: "HoleStatus");

            migrationBuilder.DropIndex(
                name: "IX_Hole_HoleStatusID",
                table: "Hole");

            migrationBuilder.RenameColumn(
                name: "HoleStatusID",
                table: "Hole",
                newName: "Status");
        }
    }
}
