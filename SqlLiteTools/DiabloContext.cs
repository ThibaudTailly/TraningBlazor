﻿using Microsoft.EntityFrameworkCore;
using SqlLiteTools.Models;

public class DiabloContext : DbContext
{
    public DbSet<DiabloActs> DiabloActs { get; set; }
    public DbSet<Act> Act { get; set; }
    public DbSet<Quest> Quest { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=diablo.db");
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);
    //}
}
