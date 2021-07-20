using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketComments",
                table: "TicketComments");

            migrationBuilder.DeleteData(
                table: "TicketComments",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"));

            migrationBuilder.DeleteData(
                table: "TicketComments",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"));

            migrationBuilder.DeleteData(
                table: "TicketComments",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"));

            migrationBuilder.AddColumn<Guid>(
                name: "CommentId",
                table: "TicketComments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketComments",
                table: "TicketComments",
                column: "CommentId");

            migrationBuilder.InsertData(
                table: "TicketComments",
                columns: new[] { "CommentId", "CommentContent", "PostTime", "TicketId", "User" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea456"), "This is a comment", new DateTime(2021, 5, 9, 10, 53, 50, 587, DateTimeKind.Local).AddTicks(3048), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"), "Nicholas" });

            migrationBuilder.InsertData(
                table: "TicketComments",
                columns: new[] { "CommentId", "CommentContent", "PostTime", "TicketId", "User" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea486"), "Thanks for the help", new DateTime(2021, 5, 9, 10, 53, 50, 596, DateTimeKind.Local).AddTicks(1861), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), "Liam" });

            migrationBuilder.InsertData(
                table: "TicketComments",
                columns: new[] { "CommentId", "CommentContent", "PostTime", "TicketId", "User" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea476"), "How do I fix my computer", new DateTime(2021, 5, 9, 10, 53, 50, 596, DateTimeKind.Local).AddTicks(2282), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "Robbie" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketComments",
                table: "TicketComments");

            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "TicketComments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketComments",
                table: "TicketComments",
                column: "TicketId");

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"),
                column: "PostTime",
                value: new DateTime(2021, 5, 8, 18, 0, 10, 9, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"),
                column: "PostTime",
                value: new DateTime(2021, 5, 8, 18, 0, 10, 15, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"),
                column: "PostTime",
                value: new DateTime(2021, 5, 8, 18, 0, 10, 15, DateTimeKind.Local).AddTicks(5534));
        }
    }
}
