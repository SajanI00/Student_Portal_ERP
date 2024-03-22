using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    /// <inheritdoc />
    public partial class Feedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LecturerName = table.Column<string>(type: "text", nullable: false),
                    ModuleName = table.Column<string>(type: "text", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: false),
                    Semester = table.Column<string>(type: "text", nullable: false),
                    LectureContentRating = table.Column<int>(type: "integer", nullable: false),
                    LectureEngagementRating = table.Column<int>(type: "integer", nullable: false),
                    CommunicationRating = table.Column<int>(type: "integer", nullable: false),
                    ExamplesRating = table.Column<int>(type: "integer", nullable: false),
                    CoverageRating = table.Column<int>(type: "integer", nullable: false),
                    PaceRating = table.Column<int>(type: "integer", nullable: false),
                    ParticipationRating = table.Column<int>(type: "integer", nullable: false),
                    VisualAidsRating = table.Column<int>(type: "integer", nullable: false),
                    RealWorldApplicationsRating = table.Column<int>(type: "integer", nullable: false),
                    ConceptRating = table.Column<int>(type: "integer", nullable: false),
                    LectureOrganizationRating = table.Column<int>(type: "integer", nullable: false),
                    InteractionRating = table.Column<int>(type: "integer", nullable: false),
                    ExplanationClarityRating = table.Column<int>(type: "integer", nullable: false),
                    SummaryEffectivenessRating = table.Column<int>(type: "integer", nullable: false),
                    RelevanceToCourseRating = table.Column<int>(type: "integer", nullable: false),
                    OverallFeedback = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
