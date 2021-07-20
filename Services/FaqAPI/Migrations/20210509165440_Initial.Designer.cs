﻿// <auto-generated />
using System;
using FaqAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FaqAPI.Migrations
{
    [DbContext(typeof(FaqDbContext))]
    [Migration("20210509165440_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FaqAPI.Models.Faq", b =>
                {
                    b.Property<Guid>("FaqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FaqId");

                    b.ToTable("Faqs");

                    b.HasData(
                        new
                        {
                            FaqId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea378"),
                            Answer = "Make sure it is plugged in",
                            Question = "My computer does not turn on?"
                        },
                        new
                        {
                            FaqId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea379"),
                            Answer = "Navigate to the tickets page and click the create new ticket button.",
                            Question = "How do I create a ticket?"
                        },
                        new
                        {
                            FaqId = new Guid("cfb88e29-4744-48c0-94fa-b25b92dea374"),
                            Answer = "There is a log out button located in the top right corner",
                            Question = "How do I logout?"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}