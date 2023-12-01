using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using VinylDatabase.Models;

namespace VinylDatabase.Models
{
    public class VinylDbContext : DbContext
    {
        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public string DbPath { get; }

        public VinylDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "vinyl.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
