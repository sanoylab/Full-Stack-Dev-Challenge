using Microsoft.EntityFrameworkCore;
using System;


namespace Project.Data
{
    public class ProjectAppDbContext:DbContext
    {
        public ProjectAppDbContext(DbContextOptions<ProjectAppDbContext>options): base(options)  {  }

        public DbSet<Project.Data.Models.Project> Projects { get; set; }
    }
}
