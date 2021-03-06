using Microsoft.EntityFrameworkCore.Migrations;

namespace LeverXEduModule10.Migrations
{
    public partial class ArtsemAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age_changed_name", "Name" },
                values: new object[] { 2, 36, "Artsem2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
