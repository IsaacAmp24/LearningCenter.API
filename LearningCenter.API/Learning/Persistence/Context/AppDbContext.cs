using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.API.Learning.Persistence.Context;

public class AppDbContext : DbContext
{
    public DbSet<CategoryAF> CategoryAfs { get; set; }
    public DbSet<TutorialAF> TutorialAfs { get; set; }
    public object Categories { get; set; }

    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<CategoryAF>().ToTable("Categories");
        builder.Entity<CategoryAF>().HasKey(p => p.Id);
        builder.Entity<CategoryAF>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<CategoryAF>().Property(p => p.Name).IsRequired().HasMaxLength(30);
        
        //Relationships
        builder.Entity<CategoryAF>()
            .HasMany(p => p.Tutorials)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId);

        builder.Entity<TutorialAF>().ToTable("Tutorials");
        builder.Entity<TutorialAF>().HasKey(p => p.Id);
        builder.Entity<TutorialAF>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<TutorialAF>().Property(p => p.Title).IsRequired().HasMaxLength(50);
        builder.Entity<TutorialAF>().Property(p => p.Description).HasMaxLength(120);

        // Apply Snake Case Naming Conventions
        
        builder.UseSnakeCaseNamingConvention();

    }
    
}