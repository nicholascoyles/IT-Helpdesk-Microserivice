using DiscussionAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionAPI.Database
{
    public class DiscussionDbContext : DbContext
    {
    
            public DiscussionDbContext(DbContextOptions<DiscussionDbContext> options) : base(options)
            { }

            public DbSet<TicketComments> TicketComments { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TicketComments>().HasData(new TicketComments
            {
                CommentId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA456}"),
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA313}"),
                CommentContent = "This is a comment",
                PostTime = DateTime.Now,
                User = "Nicholas"
            });
            modelBuilder.Entity<TicketComments>().HasData(new TicketComments
            {
                CommentId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA486}"),
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA314}"),
                CommentContent = "Thanks for the help",
                PostTime = DateTime.Now,
                User = "Liam"
            });
            modelBuilder.Entity<TicketComments>().HasData(new TicketComments
            {
                CommentId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA476}"),
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}"),
                CommentContent = "How do I fix my computer",
                PostTime = DateTime.Now,
                User = "Robbie"
            });
            modelBuilder.Entity<TicketComments>().HasData(new TicketComments
            {
                CommentId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA471}"),
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}"),
                CommentContent = "How do I fix my computer",
                PostTime = DateTime.Now,
                User = "Robbie"
            });
            modelBuilder.Entity<TicketComments>().HasData(new TicketComments
            {
                CommentId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA472}"),
                TicketId = Guid.Parse("{CFB88E29-4744-48C0-94FA-B25B92DEA315}"),
                CommentContent = "How do I fix my computer",
                PostTime = DateTime.Now,
                User = "Robbie"
            });
        }


     }  
}
