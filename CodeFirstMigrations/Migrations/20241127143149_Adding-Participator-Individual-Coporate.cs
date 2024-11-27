using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddingParticipatorIndividualCoporate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Enrollments",
                newName: "ParticipatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                newName: "IX_Enrollments_ParticipatorId");

            migrationBuilder.CreateTable(
                name: "Participators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    LName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearOfGraduation = table.Column<int>(type: "int", nullable: true),
                    IsIntern = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participators", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Participators",
                columns: new[] { "Id", "Discriminator", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Participator", "Ahmed", "test1" },
                    { 2, "Participator", "Mohamed", "test2" },
                    { 3, "Participator", "Amr", "test3" },
                    { 4, "Participator", "Salah", "test4" },
                    { 5, "Participator", "Max", "test5" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Participators_ParticipatorId",
                table: "Enrollments",
                column: "ParticipatorId",
                principalTable: "Participators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Participators_ParticipatorId",
                table: "Enrollments");

            migrationBuilder.DropTable(
                name: "Participators");

            migrationBuilder.RenameColumn(
                name: "ParticipatorId",
                table: "Enrollments",
                newName: "StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollments_ParticipatorId",
                table: "Enrollments",
                newName: "IX_Enrollments_StudentId");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true),
                    LName = table.Column<string>(type: "VARCHAR(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FName", "LName" },
                values: new object[,]
                {
                    { 1, "Ahmed", "test1" },
                    { 2, "Mohamed", "test2" },
                    { 3, "Amr", "test3" },
                    { 4, "Salah", "test4" },
                    { 5, "Max", "test5" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
