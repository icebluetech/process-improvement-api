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
        public DbSet<Task> Tasks { get; set; }
    }
}
