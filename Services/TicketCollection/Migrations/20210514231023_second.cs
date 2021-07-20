using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketCollection.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"),
                columns: new[] { "DateCreated", "Username" },
                values: new object[] { new DateTime(2021, 5, 15, 0, 10, 22, 858, DateTimeKind.Local).AddTicks(8376), "nicholas@test.com" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"),
                columns: new[] { "DateCreated", "Username" },
                values: new object[] { new DateTime(2021, 5, 15, 0, 10, 22, 863, DateTimeKind.Local).AddTicks(4438), "nicholas@test.com" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"),
                columns: new[] { "DateCreated", "Username" },
                values: new object[] { new DateTime(2021, 5, 15, 0, 10, 22, 863, DateTimeKind.Local).AddTicks(4527), "nicholas@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "Tickets");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"),
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 12, 51, 2, 119, DateTimeKind.Local).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"),
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 12, 51, 2, 124, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"),
                column: "DateCreated",
                value: new DateTime(2021, 5, 8, 12, 51, 2, 124, DateTimeKind.Local).AddTicks(2065));
        }
    }
}
