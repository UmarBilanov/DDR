using Microsoft.EntityFrameworkCore.Migrations;

namespace DiamondDrillingReport.Migrations
{
    public partial class holeModeling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Section",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "ProjectCoordinatesZ",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "ProjectCoordinatesY",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "ProjectCoordinatesX",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "HoleDepth",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "Dip",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "Azimut",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ActualCoordinateZ",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "ActualCoordinateY",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");

            migrationBuilder.AlterColumn<double>(
                name: "ActualCoordinateX",
                table: "Hole",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double(18, 2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Section",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ProjectCoordinatesZ",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ProjectCoordinatesY",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ProjectCoordinatesX",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "HoleDepth",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Dip",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "Azimut",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ActualCoordinateZ",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "ActualCoordinateY",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<double>(
                name: "ActualCoordinateX",
                table: "Hole",
                type: "double(18, 2)",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
