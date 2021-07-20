using FaqAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaqAPI.Database
{
    public class FaqDbContext : DbContext
    {

        public FaqDbContext(DbContextOptions<FaqDbContext> options) : base(options)
        { }

        public DbSet<Faq> Faqs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Faq>().HasData(new Faq
            {
                FaqId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA378}"),
                Question = "My computer does not turn on?",
                Answer = "Make sure it is plugged in"
            });

            modelBuilder.Entity<Faq>().HasData(new Faq
            {
                FaqId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA379}"),
                Question = "How do I create a ticket?",
                Answer = "Navigate to the tickets page and click the create new ticket button."
            });
            modelBuilder.Entity<Faq>().HasData(new Faq
            {
                FaqId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA374}"),
                Question = "How do I logout?",
                Answer = "There is a log out button located in the top right corner"
            });
        }
    }
}