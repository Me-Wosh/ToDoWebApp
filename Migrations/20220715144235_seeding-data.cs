using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoWebApp.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDoTable",
                columns: new[] { "Id", "Details", "ImportanceLevel", "Name" },
                values: new object[] { 1, "Simple as that!", (short)1, "Enjoying the App" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDoTable",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
