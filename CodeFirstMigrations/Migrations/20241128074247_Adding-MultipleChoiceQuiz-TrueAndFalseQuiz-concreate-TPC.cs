using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddingMultipleChoiceQuizTrueAndFalseQuizconcreateTPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Participators");

            migrationBuilder.DropColumn(
                name: "IsIntern",
                table: "Participators");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Participators");

            migrationBuilder.DropColumn(
                name: "ParticipatorType",
                table: "Participators");

            migrationBuilder.DropColumn(
                name: "University",
                table: "Participators");

            migrationBuilder.DropColumn(
                name: "YearOfGraduation",
                table: "Participators");

            migrationBuilder.CreateTable(
                name: "Coporates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coporates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coporates_Participators_Id",
                        column: x => x.Id,
                        principalTable: "Participators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfGraduation = table.Column<int>(type: "int", nullable: false),
                    IsIntern = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Individuals_Participators_Id",
                        column: x => x.Id,
                        principalTable: "Participators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MultipleChoiceQuizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    OptionA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OptionD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultipleChoiceQuizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultipleChoiceQuizes_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrueAndFalseQuizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrueAndFalseQuizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrueAndFalseQuizes_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MultipleChoiceQuizes_CourseId",
                table: "MultipleChoiceQuizes",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrueAndFalseQuizes_CourseId",
                table: "TrueAndFalseQuizes",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coporates");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "MultipleChoiceQuizes");

            migrationBuilder.DropTable(
                name: "TrueAndFalseQuizes");

            migrationBuilder.DeleteData(
                table: "Participators",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Participators",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Participators",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Participators",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Participators",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Participators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsIntern",
                table: "Participators",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Participators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParticipatorType",
                table: "Participators",
                type: "VARCHAR(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Participators",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YearOfGraduation",
                table: "Participators",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Participators",
                columns: new[] { "Id", "FName", "LName", "ParticipatorType" },
                values: new object[,]
                {
                    { 1, "Ahmed", "test1", "Participator" },
                    { 2, "Mohamed", "test2", "Participator" },
                    { 3, "Amr", "test3", "Participator" },
                    { 4, "Salah", "test4", "Participator" },
                    { 5, "Max", "test5", "Participator" }
                });
        }
    }
}
