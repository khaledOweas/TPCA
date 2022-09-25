using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPCA.Infrastructure.Persistence.Migrations
{
    public partial class AddingNameAndMaxForTodoList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxCount",
                table: "TodoLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TodoLists",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxCount",
                table: "TodoLists");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TodoLists");
        }
    }
}
