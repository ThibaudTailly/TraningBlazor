using Microsoft.EntityFrameworkCore;
using SqlLiteTool.Models;

public class DiabloContext : DbContext
{
    public DbSet<DiabloActs> DiabloActs { get; set; }
    public DbSet<Act> Act { get; set; }
    public DbSet<Quest> Quest { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\JTELLIER\\source\\repos\\ThibaudBlazor\\TraningBlazor\\SqliteTool\\diablo.db");
    }
}
