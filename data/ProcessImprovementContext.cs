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
        public DbSet<Department> Departments { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Widget> Widgets { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<ReasonForAction> ReasonForActions { get; set; }
        public DbSet<StateType> StateTypes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<GapAnalysis> GapAnalysis { get; set; }
        public DbSet<WasteType> WasteTypes { get; set; }
        public DbSet<BrainstormFile> BrainstormFiles { get; set; }
        public DbSet<BrainstormFileType> BrainstormFileTypes { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<SolutionFile> SolutionFiles { get; set; }
        public DbSet<SolutionFileType> SolutionFileTypes { get; set; }
        public DbSet<ActionPlan> ActionPlans { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<ResultEntry> ResultEntries { get; set; }
        public DbSet<ResultEntryType> ResultEntryTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<InnovationUser>().HasKey(x => new { x.InnovationId, x.UserId });

        }
    }
}
