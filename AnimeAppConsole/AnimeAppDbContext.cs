using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AnimeAppConsole;
public class AnimeAppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=ACENGIZ\\AKINCENGIZ;initial catalog=AnimeGenreAppDb;Integrated Security=True;Trust Server Certificate=True;");
    }

    public DbSet<Anime> Animes { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<AnimeDetail> AnimeDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnimeDetail>().HasNoKey();
        base.OnModelCreating(modelBuilder);
    }
}
