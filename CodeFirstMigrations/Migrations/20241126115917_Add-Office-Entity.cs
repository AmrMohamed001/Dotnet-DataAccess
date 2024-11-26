using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddOfficeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OfficeId",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    OfficeName = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false),
                    OfficeLocation = table.Column<string>(type: "VARCHAR(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1,
                column: "OfficeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2,
                column: "OfficeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 3,
                column: "OfficeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 4,
                column: "OfficeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 5,
                column: "OfficeId",
                value: 5);

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "OfficeLocation", "OfficeName" },
                values: new object[,]
                {
                    { 1, "x1", "OFF_05" },
                    { 2, "x2", "OFF_06" },
                    { 3, "x3", "OFF_07" },
                    { 4, "x4", "OFF_08" },
                    { 5, "x5", "OFF_09" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_OfficeId",
                table: "Instructors",
                column: "OfficeId",
                unique: true,
                filter: "[OfficeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Offices_OfficeId",
                table: "Instructors",
                column: "OfficeId",
                principalTable: "Offices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Offices_OfficeId",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_OfficeId",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "OfficeId",
                table: "Instructors");
        }
    }
}
