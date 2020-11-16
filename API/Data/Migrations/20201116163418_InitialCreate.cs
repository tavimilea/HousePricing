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
                    Lat = table.Column<double>(type: "REAL", nullable: false),
                    Longg = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_living15 = table.Column<double>(type: "REAL", nullable: false),
                    Sqft_lot15 = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Houses");
        }
    }
}
