using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Migrations
{
    public partial class BindingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Categories",
                new[] { 
                    "Id",
                    "Name",
                    "Slug"
                    
                },
                new object[,]
                {
                    {
                        1,
                        "Фрукты",
                        "фрукты"
                    },
                    {
                        2,
                        "Футболки",
                        "футболки"
                    }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                "Categories",
                new[] { "Name", "Slug" },
                new object[,]
                {
                    { "Фрукты", "фрукты" },
                    { "Футболки", "футболки" }
                }
            );
        }
    }
}
