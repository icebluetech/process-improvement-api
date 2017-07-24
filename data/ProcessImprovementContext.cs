using Microsoft.EntityFrameworkCore;
using model;
using System;
using System.Collections.Generic;
using System.Text;

namespace data
{
    public class ProcessImprovementContext : DbContext
    {
        public ProcessImprovementContext(DbContextOptions<ProcessImprovementContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Innovation> Innovations { get; set; }
        public DbSet<Notification> Tasks { get; set; }
        public DbSet<Celebrate> Celebrates { get; set; }
        public DbSet<Experiment> Experiments { get; set; }
        public DbSet<InnovationCategory> InnovationCategories { get; set; }
        public DbSet<InnovationType> InnovationTypes { get; set; }
        public DbSet<InnovationUser> InnovationUsers { get; set; }
        public DbSet<Doc> Docs { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<RootCauseAnalysis> RootCauseAnalysies { get; set; }
        public DbSet<StandardWork> StandardWorks { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Brainstorm> Brainstorms { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InnovationUser>().HasKey(x => new { x.InnovationId, x.UserId });
        }
    }
}
