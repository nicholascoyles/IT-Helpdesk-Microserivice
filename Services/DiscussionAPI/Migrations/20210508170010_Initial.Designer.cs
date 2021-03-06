// <auto-generated />
using System;
using DiscussionAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiscussionAPI.Migrations
{
    [DbContext(typeof(DiscussionDbContext))]
    [Migration("20210508170010_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiscussionAPI.Models.TicketComments", b =>
                {
                    b.Property<Guid>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId");

                    b.ToTable("TicketComments");

                    b.HasData(
                        new
                        {
                            TicketId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"),
                            CommentContent = "This is a comment",
                            PostTime = new DateTime(2021, 5, 8, 18, 0, 10, 9, DateTimeKind.Local).AddTicks(8158),
                            User = "Nicholas"
                        },
                        new
                        {
                            TicketId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"),
                            CommentContent = "Thanks for the help",
                            PostTime = new DateTime(2021, 5, 8, 18, 0, 10, 15, DateTimeKind.Local).AddTicks(5390),
                            User = "Liam"
                        },
                        new
                        {
                            TicketId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"),
                            CommentContent = "How do I fix my computer",
                            PostTime = new DateTime(2021, 5, 8, 18, 0, 10, 15, DateTimeKind.Local).AddTicks(5534),
                            User = "Robbie"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
