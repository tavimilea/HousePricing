using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<double>(type: "REAL", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    Bedrooms = table.Column<double>(type: "REAL", nullable: false),
                    Bathrooms = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_living = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_lot = table.Column<double>(type: "REAL", nullable: false),
                    Floors = table.Column<double>(type: "REAL", nullable: false),
                    Waterfront = table.Column<double>(type: "REAL", nullable: false),
                    View = table.Column<double>(type: "REAL", nullable: false),
                    Condition = table.Column<double>(type: "REAL", nullable: false),
                    Grade = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_above = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_basement = table.Column<double>(type: "REAL", nullable: false),
                    Yr_built = table.Column<double>(type: "REAL", nullable: false),
                    Yr_renovated = table.Column<double>(type: "REAL", nullable: false),
                    Zipcode = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_living15 = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_lot15 = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Floors = table.Column<float>(type: "REAL", nullable: false),
                    Grade = table.Column<float>(type: "REAL", nullable: false),
                    Condition = table.Column<float>(type: "REAL", nullable: false),
                    Token = table.Column<string>(type: "TEXT", nullable: true),
                    ReportFk = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Reports_ReportFk",
                        column: x => x.ReportFk,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Token = table.Column<string>(type: "TEXT", nullable: true),
                    ReportFk = table.Column<int>(type: "INTEGER", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Reports_ReportFk",
                        column: x => x.ReportFk,
                        principalTable: "Reports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ReportFk",
                table: "Requests",
                column: "ReportFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ReportFk",
                table: "Users",
                column: "ReportFk",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Reports");
        }
    }
}
