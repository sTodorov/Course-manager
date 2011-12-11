using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using CouresManager.Core;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CourseManager.Core.DataAccess
{
  public class CourseContext : DbContext
  {
    public CourseContext()
      : base("course")
    {

      this.Configuration.LazyLoadingEnabled = true;
      this.Configuration.ValidateOnSaveEnabled = false;
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

    public DbSet<Course> Courses { get; set; }

    public DbSet<Language> Languages { get; set; }

    public DbSet<Semester> Semesters { get; set; }

    public DbSet<Teacher> Teachers { get; set; }

    public DbSet<Group> Groups { get; set; }
  }
}
