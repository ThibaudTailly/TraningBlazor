using DomaineLayer.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class DiabloContext : DbContext
{
    public DbSet<DiabloActs> DiabloActs { get; set; }
    public DbSet<Act> Act { get; set; }
    public DbSet<Quest> Quest { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\tailly\\Documents\\Blazor\\BlazorApi\\TrainingApiBlizzard\\SqlLiteTools\\diablo.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Act>().ToTable("Act");

    }
}
