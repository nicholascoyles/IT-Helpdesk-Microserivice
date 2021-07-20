using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketComments",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketComments", x => x.TicketId);
                });

            migrationBuilder.InsertData(
                table: "TicketComments",
                columns: new[] { "TicketId", "CommentContent", "PostTime", "User" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"), "This is a comment", new DateTime(2021, 5, 8, 18, 0, 10, 9, DateTimeKind.Local).AddTicks(8158), "Nicholas" });

            migrationBuilder.InsertData(
                table: "TicketComments",
                columns: new[] { "TicketId", "CommentContent", "PostTime", "User" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), "Thanks for the help", new DateTime(2021, 5, 8, 18, 0, 10, 15, DateTimeKind.Local).AddTicks(5390), "Liam" });

            migrationBuilder.InsertData(
                table: "TicketComments",
                columns: new[] { "TicketId", "CommentContent", "PostTime", "User" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "How do I fix my computer", new DateTime(2021, 5, 8, 18, 0, 10, 15, DateTimeKind.Local).AddTicks(5534), "Robbie" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketComments");
        }
    }
}
