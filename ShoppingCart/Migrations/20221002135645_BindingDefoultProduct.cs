using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Migrations
{
    public partial class BindingDefoultProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "Products",
                new []{
                    "Name",
                    "Slug",
                    "Description",
                    "Price",
                    "CategoryId",
                    "Image"
                },
                new object[,]
                {
                    {
                        "Сочные яблоки",
                        "яблоки",
                        "Свежие яблоки",
                        (11.00M),
                        1,
                        "apples.jpg"
                    },
                    {
                        "Бананы",
                        "бананы",
                        "Свежие бананы",
                        (3M),
                        1,
                        "bananas.jpg"
                    },
                    {
                        "Грейпфрут",
                        "грейпфрут",
                        "Сочный грэйпфрут",
                        (0.50M),
                        1,
                        "grapefruit.jpg"
                    },
                    {
                        "Арбуз",
                        "арбуз",
                        "Сочный арбуз",
                        (2.00M),
                        1,
                        "watermelon.jpg"
                    },
                    {
                        "Белая футболка",
                        "белая футболка",
                        "Белая футболка",
                        (5.99M),
                        2,
                        "white shirt.jpg"
                    },
                    {
                        "Черная футболка",
                        "черная футболка",
                        "Черная футболка",
                        (7.99M),
                        2,
                        "black shirt.jpg"
                    },
                    {
                        "Желтая футболка",
                        "желтая футболка",
                        "Желтая футболка",
                        (11.99M),
                        2,
                        "yellow shirt.jpg"
                    },
                    {
                        "Серая футболка",
                        "серая футболка",
                        "Серая футболка",
                        (12.99M),
                        2,
                        "pink shirt.jpg"
                    }
                }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
