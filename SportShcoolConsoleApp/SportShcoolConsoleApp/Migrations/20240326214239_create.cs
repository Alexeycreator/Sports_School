using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SportShcoolConsoleApp.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coachingStaffs",
                columns: table => new
                {
                    CoachingStaffId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    JobTitle = table.Column<string>(type: "text", nullable: true),
                    Fullname = table.Column<string>(type: "text", nullable: true),
                    Sex = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coachingStaffs", x => x.CoachingStaffId);
                });

            migrationBuilder.CreateTable(
                name: "kindOfSports",
                columns: table => new
                {
                    KindOfSportId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fullname = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    StudentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kindOfSports", x => x.KindOfSportId);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Fullname = table.Column<string>(type: "text", nullable: true),
                    Sex = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Achievements = table.Column<string>(type: "text", nullable: true),
                    CoachingStaffId = table.Column<int>(type: "integer", nullable: false),
                    KindOfSportId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_students_coachingStaffs_CoachingStaffId",
                        column: x => x.CoachingStaffId,
                        principalTable: "coachingStaffs",
                        principalColumn: "CoachingStaffId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_kindOfSports_KindOfSportId",
                        column: x => x.KindOfSportId,
                        principalTable: "kindOfSports",
                        principalColumn: "KindOfSportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hospitalCards",
                columns: table => new
                {
                    HospitalCardId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Fullname = table.Column<string>(type: "text", nullable: true),
                    AddmissionToCompetitions = table.Column<string>(type: "text", nullable: true),
                    Deseases = table.Column<string>(type: "text", nullable: true),
                    StudentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospitalCards", x => x.HospitalCardId);
                    table.ForeignKey(
                        name: "FK_hospitalCards_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_hospitalCards_StudentId",
                table: "hospitalCards",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_students_CoachingStaffId",
                table: "students",
                column: "CoachingStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_students_KindOfSportId",
                table: "students",
                column: "KindOfSportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hospitalCards");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "coachingStaffs");

            migrationBuilder.DropTable(
                name: "kindOfSports");
        }
    }
}
