using Microsoft.EntityFrameworkCore.Migrations;

namespace DiamondDrillingReport.Migrations
{
    public partial class holeStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<double>(
                name: "ActualCoordinateZ",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualCoordinateZ",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
