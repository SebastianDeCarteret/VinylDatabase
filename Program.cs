using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using VinylDatabase.Models;

using var db = new VinylDbContext();

Console.WriteLine($"Database path: {db.DbPath}");

//db.Database.EnsureDeleted();
//db.Database.Migrate();
//db.SaveChanges();

db.Add(new Vinyl
{
    Artist = "AC/DC",
    Title = "Back In Black",
    NumberOfTracks = 8,
    NumberOfLps = 1,
    Price = 19.99f,
    ReleaseDate = new DateTime(1980, 1, 1, new GregorianCalendar()),
    ImageLink = "Link"
});

db.SaveChanges();

var vinyl = db.Vinyls.OrderBy(v => v.VinylId).First();
Console.WriteLine($"Newly created vinyl {vinyl.Title}");