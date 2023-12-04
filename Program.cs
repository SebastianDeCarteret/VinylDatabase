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

foreach (var item in SeedData.SeedDataList)
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
        Console.WriteLine($"Track: {TimeFormatter(track.Length)}");
    }
}

// note: not to be used in api
string TimeFormatter(float time)
{
    string[] slicedTime = time.ToString().Split(".");
    return $"{slicedTime[0]}m {slicedTime[1]}s";
}