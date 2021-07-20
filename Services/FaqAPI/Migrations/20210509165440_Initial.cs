using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FaqAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faqs",
                columns: table => new
                {
                    FaqId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faqs", x => x.FaqId);
                });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqId", "Answer", "Question" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea378"), "Make sure it is plugged in", "My computer does not turn on?" });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqId", "Answer", "Question" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea379"), "Navigate to the tickets page and click the create new ticket button.", "How do I create a ticket?" });

            migrationBuilder.InsertData(
                table: "Faqs",
                columns: new[] { "FaqId", "Answer", "Question" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea374"), "There is a log out button located in the top right corner", "How do I logout?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faqs");
        }
    }
}
