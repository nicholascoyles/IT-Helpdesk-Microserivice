// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketCollection.Database;

namespace TicketCollection.Migrations
{
    [DbContext(typeof(TicketCollectionDbContext))]
    [Migration("20210508115102_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketCollection.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d0"),
                            Name = "Computer"
                        },
                        new
                        {
                            CategoryId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d1"),
                            Name = "Keyboard"
                        },
                        new
                        {
                            CategoryId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d2"),
                            Name = "Laptop"
                        });
                });

            modelBuilder.Entity("TicketCollection.Models.Priority", b =>
                {
                    b.Property<Guid>("PriorityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriorityId");

                    b.ToTable("Priorities");

                    b.HasData(
                        new
                        {
                            PriorityId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a0"),
                            Name = "Low"
                        },
                        new
                        {
                            PriorityId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a1"),
                            Name = "Medium"
                        },
                        new
                        {
                            PriorityId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a2"),
                            Name = "High"
                        });
                });

            modelBuilder.Entity("TicketCollection.Models.Status", b =>
                {
                    b.Property<Guid>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e0"),
                            Name = "Open"
                        },
                        new
                        {
                            StatusId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e1"),
                            Name = "Closed"
                        },
                        new
                        {
                            StatusId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e2"),
                            Name = "Pending"
                        });
                });

            modelBuilder.Entity("TicketCollection.Models.Ticket", b =>
                {
                    b.Property<Guid>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PriorityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TicketId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("PriorityId");

                    b.HasIndex("StatusId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea313"),
                            CategoryId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d0"),
                            DateCreated = new DateTime(2021, 5, 8, 12, 51, 2, 119, DateTimeKind.Local).AddTicks(3070),
                            Description = "Please help my computer is broken.",
                            PriorityId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a0"),
                            StatusId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e0"),
                            Title = "My Computer is broken"
                        },
                        new
                        {
                            TicketId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea314"),
                            CategoryId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d1"),
                            DateCreated = new DateTime(2021, 5, 8, 12, 51, 2, 124, DateTimeKind.Local).AddTicks(1971),
                            Description = "Please help my Keyboard is broken.",
                            PriorityId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a1"),
                            StatusId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e1"),
                            Title = "My Keyboard is broken"
                        },
                        new
                        {
                            TicketId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea315"),
                            CategoryId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62d2"),
                            DateCreated = new DateTime(2021, 5, 8, 12, 51, 2, 124, DateTimeKind.Local).AddTicks(2065),
                            Description = "Please help my computer is broken.",
                            PriorityId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62a2"),
                            StatusId = new Guid("9853a3dc-6c18-4215-81ee-cdfff42a62e2"),
                            Title = "My Laptop is broken"
                        });
                });

            modelBuilder.Entity("TicketCollection.Models.Ticket", b =>
                {
                    b.HasOne("TicketCollection.Models.Category", "Category")
                        .WithMany("Tickets")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketCollection.Models.Priority", "Priority")
                        .WithMany("Tickets")
                        .HasForeignKey("PriorityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketCollection.Models.Status", "Status")
                        .WithMany("Tickets")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Priority");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TicketCollection.Models.Category", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("TicketCollection.Models.Priority", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("TicketCollection.Models.Status", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
