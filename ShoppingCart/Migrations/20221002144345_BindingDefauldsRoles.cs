using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCart.Migrations
{
    public partial class BindingDefauldsRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                "AspNetRoles",
                new []
                {
                    "Id",
                    "Name",
                    "NormalizedName",
                    "ConcurrencyStamp"
                },
                new object[,]
                {
                    {
                        "admin",
                        "Admin",
                        "admin",
                        ""
                    },
                    {
                        "user",
                        "User",
                        "user",
                        ""
                    }
                }
            );
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
