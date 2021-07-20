using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Priorities",
                columns: table => new
                {
                    PriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Priorities", x => x.PriorityId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriorityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Priorities_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "Priorities",
                        principalColumn: "PriorityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d0"), "Computer" },
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d1"), "Keyboard" },
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d2"), "Laptop" }
                });

            migrationBuilder.InsertData(
                table: "Priorities",
                columns: new[] { "PriorityId", "Name" },
                values: new object[,]
                {
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a0"), "Low" },
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a1"), "Medium" },
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a2"), "High" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e0"), "Open" },
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e1"), "Closed" },
                    { new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e2"), "Pending" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "CategoryId", "DateCreated", "Description", "PriorityId", "StatusId", "Title" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"), new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d0"), new DateTime(2021, 5, 8, 12, 51, 2, 119, DateTimeKind.Local).AddTicks(3070), "Please help my computer is broken.", new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a0"), new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e0"), "My Computer is broken" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "CategoryId", "DateCreated", "Description", "PriorityId", "StatusId", "Title" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"), new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d1"), new DateTime(2021, 5, 8, 12, 51, 2, 124, DateTimeKind.Local).AddTicks(1971), "Please help my Keyboard is broken.", new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a1"), new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e1"), "My Keyboard is broken" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "CategoryId", "DateCreated", "Description", "PriorityId", "StatusId", "Title" },
                values: new object[] { new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"), new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d2"), new DateTime(2021, 5, 8, 12, 51, 2, 124, DateTimeKind.Local).AddTicks(2065), "Please help my computer is broken.", new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a2"), new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e2"), "My Laptop is broken" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CategoryId",
                table: "Tickets",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PriorityId",
                table: "Tickets",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StatusId",
                table: "Tickets",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Priorities");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
