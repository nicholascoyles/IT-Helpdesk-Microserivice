using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea456"),
                column: "PostTime",
                value: new DateTime(2021, 5, 11, 21, 23, 27, 149, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea476"),
                column: "PostTime",
                value: new DateTime(2021, 5, 11, 21, 23, 27, 161, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea486"),
                column: "PostTime",
                value: new DateTime(2021, 5, 11, 21, 23, 27, 161, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.InsertData(
                table: "TicketComments",
                columns: new[] { "CommentId", "CommentContent", "PostTime", "TicketId", "User" },
                values: new object[,]
                {
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea471"), "How do I fix my computer", new DateTime(2021, 5, 11, 21, 23, 27, 161, DateTimeKind.Local).AddTicks(5985), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "Robbie" },
                    { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea472"), "How do I fix my computer", new DateTime(2021, 5, 11, 21, 23, 27, 161, DateTimeKind.Local).AddTicks(6010), new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), "Robbie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea471"));

            migrationBuilder.DeleteData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea472"));

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea456"),
                column: "PostTime",
                value: new DateTime(2021, 5, 9, 10, 53, 50, 587, DateTimeKind.Local).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea476"),
                column: "PostTime",
                value: new DateTime(2021, 5, 9, 10, 53, 50, 596, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "TicketComments",
                keyColumn: "CommentId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea486"),
                column: "PostTime",
                value: new DateTime(2021, 5, 9, 10, 53, 50, 596, DateTimeKind.Local).AddTicks(1861));
        }
    }
}
