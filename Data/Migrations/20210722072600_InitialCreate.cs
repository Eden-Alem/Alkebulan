using Microsoft.EntityFrameworkCore.Migrations;

namespace Datien.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EducationInstitution",
                columns: table => new
                {
                    EducationID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstitutionName = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    CountryName = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    LegalCertificate = table.Column<string>(type: "TEXT", nullable: true),
                    TeachingStaff = table.Column<int>(type: "INTEGER", nullable: false),
                    Students = table.Column<int>(type: "INTEGER", nullable: false),
                    AnnualAverageGraduates = table.Column<int>(type: "INTEGER", nullable: false),
                    Latitude = table.Column<decimal>(type: "TEXT", nullable: false),
                    Longitude = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationInstitution", x => x.EducationID);
                });

            migrationBuilder.CreateTable(
                name: "HealthInstitution",
                columns: table => new
                {
                    HealthID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstitutionName = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    CountryName = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    LegalCertificate = table.Column<string>(type: "TEXT", nullable: true),
                    HealthCareSpecialists = table.Column<int>(type: "INTEGER", nullable: false),
                    HealthEquipments = table.Column<int>(type: "INTEGER", nullable: false),
                    DailyAveragePatients = table.Column<int>(type: "INTEGER", nullable: false),
                    Latitude = table.Column<decimal>(type: "TEXT", nullable: false),
                    Longitude = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInstitution", x => x.HealthID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationInstitution");

            migrationBuilder.DropTable(
                name: "HealthInstitution");
        }
    }
}
