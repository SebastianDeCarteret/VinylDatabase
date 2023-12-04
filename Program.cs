using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using VinylDatabase;
using VinylDatabase.Models;

using var db = new VinylDbContext();

db.Database.EnsureDeleted();
db.Database.EnsureCreated();
db.SaveChanges();

var tempData = SeedData.RunSeed();

foreach (var item in tempData)
{
    await db.Vinyls.AddAsync(item);
    db.SaveChanges();
}

foreach (var vinyl in db.Vinyls)
{
    Console.WriteLine($"Vinyl: {vinyl.Title}");
    foreach (var track in vinyl.Tracks)
    {
        Console.WriteLine($"Track: {track.Title}");
    }
}