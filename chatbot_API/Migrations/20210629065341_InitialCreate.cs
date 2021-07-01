using Microsoft.EntityFrameworkCore.Migrations;

namespace chatbot_API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoriesDetails",
                columns: table => new
                {
                    Stories_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stories_headName = table.Column<string>(type: "varchar(100)", nullable: false),
                    Stories_Text = table.Column<string>(type: "varchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoriesDetails", x => x.Stories_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoriesDetails");
        }
    }
}
