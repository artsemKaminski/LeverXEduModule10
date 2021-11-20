using Microsoft.EntityFrameworkCore.Migrations;

namespace LeverXEduModule10.Migrations
{
    public partial class AngeColumnNameRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Users",
                newName: "Age_changed_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age_changed_name",
                table: "Users",
                newName: "Age");
        }
    }
}
