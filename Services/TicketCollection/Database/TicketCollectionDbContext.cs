using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketCollection.Models;

namespace TicketCollection.Database
{
    public class TicketCollectionDbContext : DbContext
    {
        public TicketCollectionDbContext(DbContextOptions<TicketCollectionDbContext> options) : base(options)
        { }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Priority> Priorities { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62d0}"),
                Name = "Computer"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62d1}"),
                Name = "Keyboard"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                CategoryId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62d2}"),
                Name = "Laptop"
            });



            modelBuilder.Entity<Status>().HasData(new Status
            {
                StatusId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62e0}"),
                Name = "Open"
            });
            modelBuilder.Entity<Status>().HasData(new Status
            {
                StatusId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62e1}"),
                Name = "Closed"
            });
            modelBuilder.Entity<Status>().HasData(new Status
            {
                StatusId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62e2}"),
                Name = "Pending"
            });





            modelBuilder.Entity<Priority>().HasData(new Priority
            {
                PriorityId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62a0}"),
                Name = "Low"
            });
            modelBuilder.Entity<Priority>().HasData(new Priority
            {
                PriorityId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62a1}"),
                Name = "Medium"
            });
            modelBuilder.Entity<Priority>().HasData(new Priority
            {
                PriorityId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62a2}"),
                Name = "High"
            });



            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA313}"),
                Title = "My Computer is broken",
                DateCreated = DateTime.Now,
                Description = "Please help my computer is broken.",
                CategoryId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62d0}"),
                PriorityId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62a0}"),
                StatusId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62e0}"),
                Username = "nicholas@test.com"

            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA314}"),
                Title = "My Keyboard is broken",
                DateCreated = DateTime.Now,
                Description = "Please help my Keyboard is broken.",
                CategoryId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62d1}"),
                PriorityId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62a1}"),
                StatusId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62e1}"),
                Username = "nicholas@test.com"

            });

            modelBuilder.Entity<Ticket>().HasData(new Ticket
            {
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}"),
                Title = "My Laptop is broken",
                DateCreated = DateTime.Now,
                Description = "Please help my computer is broken.",
                CategoryId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62d2}"),
                PriorityId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62a2}"),
                StatusId = Guid.Parse("{9853a3dc-6c18-4215-81ee-cdfff42a62e2}"),
                Username = "nicholas@test.com"

            });

        }
    }
}
