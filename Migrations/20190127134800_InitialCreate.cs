using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiamondDrillingReport.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drill",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DrillCode = table.Column<string>(nullable: true),
                    DrillNum = table.Column<string>(nullable: true),
                    DrillColour = table.Column<string>(nullable: true),
                    Modification = table.Column<string>(nullable: true),
                    DrillName = table.Column<string>(nullable: true),
                    Depth = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drill", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Short = table.Column<string>(nullable: true),
                    NameRus = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hole",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HoleCode = table.Column<string>(nullable: true),
                    HoleZone = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    DrillID = table.Column<int>(nullable: false),
                    HoleDepth = table.Column<double>(nullable: false),
                    Azimut = table.Column<double>(nullable: false),
                    Dip = table.Column<double>(nullable: false),
                    Section = table.Column<double>(nullable: false),
                    ZeroDatum = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    ProjectCoordinatesX = table.Column<double>(nullable: false),
                    ProjectCoordinatesY = table.Column<double>(nullable: false),
                    ProjectCoordinatesZ = table.Column<double>(nullable: false),
                    ActualCoordinateX = table.Column<double>(nullable: false),
                    ActualCoordinateY = table.Column<double>(nullable: false),
                    ActualCoordinateZ = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hole", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hole_Drill_DrillID",
                        column: x => x.DrillID,
                        principalTable: "Drill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crew",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crew", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Crew_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CreateDailyReport",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    HoleID = table.Column<int>(nullable: false),
                    WaterTruckDay = table.Column<string>(nullable: true),
                    WaterTruckNight = table.Column<string>(nullable: true),
                    BitsDay = table.Column<string>(nullable: true),
                    BitsNight = table.Column<string>(nullable: true),
                    ShellDay = table.Column<string>(nullable: true),
                    ShellNight = table.Column<string>(nullable: true),
                    HoleDepthToDay = table.Column<double>(nullable: false),
                    HoleDepthToNight = table.Column<double>(nullable: false),
                    CasingFromDay = table.Column<double>(nullable: false),
                    CasingFromNight = table.Column<double>(nullable: false),
                    CasingToDay = table.Column<double>(nullable: false),
                    CasingToNight = table.Column<double>(nullable: false),
                    PreStartDay = table.Column<double>(nullable: false),
                    PreStartNight = table.Column<double>(nullable: false),
                    ConditionDay = table.Column<double>(nullable: false),
                    ConditionNight = table.Column<double>(nullable: false),
                    DrillingDay = table.Column<double>(nullable: false),
                    DrillingNight = table.Column<double>(nullable: false),
                    ReamingDay = table.Column<double>(nullable: false),
                    ReamingNight = table.Column<double>(nullable: false),
                    ReamingCasingDay = table.Column<double>(nullable: false),
                    ReamingCasingNight = table.Column<double>(nullable: false),
                    BitChangeDay = table.Column<double>(nullable: false),
                    BitChangeNight = table.Column<double>(nullable: false),
                    RepairsDay = table.Column<double>(nullable: false),
                    RepairsNight = table.Column<double>(nullable: false),
                    BlastDay = table.Column<double>(nullable: false),
                    BlastNight = table.Column<double>(nullable: false),
                    WaterDelayDay = table.Column<double>(nullable: false),
                    WaterDelayNight = table.Column<double>(nullable: false),
                    AwaitingPartsMaterialsDay = table.Column<double>(nullable: false),
                    AwaitingPartsMaterialsNight = table.Column<double>(nullable: false),
                    AwaitingMechanicElectricianDay = table.Column<double>(nullable: false),
                    AwaitingMechanicElectricianNight = table.Column<double>(nullable: false),
                    AwaitingDozerDay = table.Column<double>(nullable: false),
                    AwaitingDozerNight = table.Column<double>(nullable: false),
                    PreparationDrillingDay = table.Column<double>(nullable: false),
                    PreparationDrillingNight = table.Column<double>(nullable: false),
                    DismantlingDay = table.Column<double>(nullable: false),
                    DismantlingNight = table.Column<double>(nullable: false),
                    MovingRigDay = table.Column<double>(nullable: false),
                    MovingRigNight = table.Column<double>(nullable: false),
                    TestsDay = table.Column<double>(nullable: false),
                    TestsNight = table.Column<double>(nullable: false),
                    AwaitingDrillCrewDay = table.Column<double>(nullable: false),
                    AwaitingDrillCrewNight = table.Column<double>(nullable: false),
                    TestDayDepth = table.Column<double>(nullable: false),
                    TestDayDIP = table.Column<double>(nullable: false),
                    TestDayAZ = table.Column<double>(nullable: false),
                    TestDayMAG = table.Column<double>(nullable: false),
                    TestDayDepth2 = table.Column<double>(nullable: false),
                    TestDayDIP2 = table.Column<double>(nullable: false),
                    TestDayAZ2 = table.Column<double>(nullable: false),
                    TestDayMAG2 = table.Column<double>(nullable: false),
                    TestDayDepth3 = table.Column<double>(nullable: false),
                    TestDayDIP3 = table.Column<double>(nullable: false),
                    TestDayAZ3 = table.Column<double>(nullable: false),
                    TestDayMAG3 = table.Column<double>(nullable: false),
                    TestDayDepth4 = table.Column<double>(nullable: false),
                    TestDayDIP4 = table.Column<double>(nullable: false),
                    TestDayAZ4 = table.Column<double>(nullable: false),
                    TestDayMAG4 = table.Column<double>(nullable: false),
                    TestNightDepth = table.Column<double>(nullable: false),
                    TestNightDIP = table.Column<double>(nullable: false),
                    TestNightAZ = table.Column<double>(nullable: false),
                    TestNightMAG = table.Column<double>(nullable: false),
                    TestNightDepth2 = table.Column<double>(nullable: false),
                    TestNightDIP2 = table.Column<double>(nullable: false),
                    TestNightAZ2 = table.Column<double>(nullable: false),
                    TestNightMAG2 = table.Column<double>(nullable: false),
                    TestNightDepth3 = table.Column<double>(nullable: false),
                    TestNightDIP3 = table.Column<double>(nullable: false),
                    TestNightAZ3 = table.Column<double>(nullable: false),
                    TestNightMAG3 = table.Column<double>(nullable: false),
                    TestNightDepth4 = table.Column<double>(nullable: false),
                    TestNightDIP4 = table.Column<double>(nullable: false),
                    TestNightAZ4 = table.Column<double>(nullable: false),
                    TestNightMAG4 = table.Column<double>(nullable: false),
                    CommentDay = table.Column<string>(nullable: true),
                    CommentNight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateDailyReport", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CreateDailyReport_Hole_HoleID",
                        column: x => x.HoleID,
                        principalTable: "Hole",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CreateDailyReport_HoleID",
                table: "CreateDailyReport",
                column: "HoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Crew_EmployeeID",
                table: "Crew",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Hole_DrillID",
                table: "Hole",
                column: "DrillID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateDailyReport");

            migrationBuilder.DropTable(
                name: "Crew");

            migrationBuilder.DropTable(
                name: "Hole");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Drill");
        }
    }
}
