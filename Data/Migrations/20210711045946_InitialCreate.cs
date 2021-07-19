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
                    FullName = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    LegalCertificate = table.Column<string>(type: "TEXT", nullable: true),
                    TeachingStaff = table.Column<string>(type: "TEXT", nullable: true),
                    Students = table.Column<string>(type: "TEXT", nullable: true),
                    AnnualAverageGraduates = table.Column<string>(type: "TEXT", nullable: true),
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
                    FullName = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    LegalCertificate = table.Column<string>(type: "TEXT", nullable: true),
                    HealthCareSpecialists = table.Column<string>(type: "TEXT", nullable: true),
                    HealthEquipments = table.Column<string>(type: "TEXT", nullable: true),
                    DailyAveragePatients = table.Column<string>(type: "TEXT", nullable: true),
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
