using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using VinylDatabase;
using VinylDatabase.Models;

//using var db = new VinylDbContext();

//Console.WriteLine($"Database path: {db.DbPath}");

//db.Database.EnsureDeleted();
//db.Database.Migrate();
//db.SaveChanges();

var tempData = SeedData.RunSeed();

foreach (var item in tempData)
{
    using var db2 = new VinylDbContext();
    db2.Add(item);
    item.Tracks.AddRange(item.Tracks);
    db2.SaveChanges();
}

//db.SaveChanges();


//db.Add(new Vinyl
//{
//    Artist = "AC/DC",
//    Title = "Back In Black",
//    NumberOfTracks = 8,
//    NumberOfLps = 1,
//    Price = 19.99f,
//    ReleaseDate = new DateTime(1980, 1, 1, new GregorianCalendar()),
//    ImageLink = "Link"
//});

//db.SaveChanges();

//var vinyl = db.Vinyls.OrderBy(v => v.VinylId).First();
//Console.WriteLine($"Newly created vinyl {vinyl.Title}");

//foreach (var vinyl in db.Vinyls)
//{
//    Console.WriteLine($"Vinyl: {vinyl.Title}");
//    Console.WriteLine($"Tracks: {vinyl.Tracks}");
//}