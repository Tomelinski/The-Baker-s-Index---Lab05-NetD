using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab05.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recipes",
                columns: table => new
                {
                    recipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recipeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cookTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    directions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipes", x => x.recipeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recipes");
        }
    }
}
