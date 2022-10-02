using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;
using ShoppingCart.Models;

#nullable disable

namespace ShoppingCart.Migrations
{
    public partial class CreateAdminAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            AppUser admin = new AppUser
            {
                UserName = "Admin",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN",
                SecurityStamp = "J2MWWDBL6XGW2FL6U6E4QG6LNZISEVY7",
                PasswordHash = "AQAAAAEAACcQAAAAENIaObw4vnMKVa/RfTGGuKv5k++B7My41w2KXgj+UBT9F668XcxNvdLf4vHPvpbDRw=="
                
            };
            migrationBuilder.InsertData(
                "AspNetUsers",
                new[]
                {
                    "Id",
                    "UserName",
                    "NormalizedUserName",
                    "Email",
                    "NormalizedEmail",
                    "EmailConfirmed",
                    "PasswordHash",
                    "SecurityStamp",
                    "ConcurrencyStamp",
                    "PhoneNumberConfirmed",
                    "TwoFactorEnabled",
                    "LockoutEnabled",
                    "AccessFailedCount"
                },
                new object[,]
                {
                    {
                        admin.Id,
                        admin.UserName,
                        admin.NormalizedUserName,
                        admin.Email,
                        admin.NormalizedEmail,
                        true,
                        admin.PasswordHash,
                        admin.SecurityStamp,
                        admin.ConcurrencyStamp,
                        admin.PhoneNumberConfirmed,
                        admin.TwoFactorEnabled,
                        admin.LockoutEnabled,
                        admin.AccessFailedCount
                    }
                }
            );
            migrationBuilder
                .InsertData(
                    "AspNetUserRoles",
                    new[]
                    {
                        "UserId",
                        "RoleId"
                    },
                    new object[,]
                    {
                        {
                            admin.Id,
                            "admin"
                        }
                    }
                );
        }
        
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
