using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddingParticipatorIndividualCoporateCustomConfigurations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Participators");

            migrationBuilder.AddColumn<string>(
                name: "ParticipatorType",
                table: "Participators",
                type: "VARCHAR(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ParticipatorType",
                table: "Participators");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Participators",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

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
        }
    }
}
