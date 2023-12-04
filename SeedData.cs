using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VinylDatabase.Models;

namespace VinylDatabase
{
    //public class VinylData(string title, string artist, int numberOfLps, int numberOfTracks, float price, DateTime releaseDate, string imageLink)
    //{
    //    public int VinylId { get; set; }
    //    public string Title { get; set; } = title;
    //    public string Artist { get; set; } = artist;
    //    public int NumberOfLps { get; set; } = numberOfLps;
    //    public int NumberOfTracks { get; set; } = numberOfTracks;
    //    public float Price { get; set; } = price;
    //    public DateTime ReleaseDate { get; set; } = releaseDate;
    //    public string ImageLink { get; set; } = imageLink;
    //    public List<Track>? Tracks { get; set; }

    //    public void AddTracks(Track[] tracks)
    //    {
    //        foreach (var track in tracks)
    //        {
    //            Tracks!.Add(track);
    //        }
    //    }
    //}
    //public class TrackData(string title, float length, int vinylId)
    //{
    //    public int TrackId { get; set; }
    //    public string Title { get; set; } = title;
    //    public float Length { get; set; } = length;

    //    public int VinylId { get; set; } = vinylId;
    //    public Vinyl Vinyl { get; set; }
    //}
    //public class VinylAndTracks(Vinyl vinyl)
    //{
    //    public Vinyl Vinyl { get; set; } = vinyl;
    //    //public List<Track> Track { get; set; } = tracks;
    //}
    public class SeedData

    {
        //public List<VinylData> Data = new List<VinylData>();
        //public void Main(string[] args)
        //{
        //    VinylData backInBlack = new VinylData(
        //        "Back In Black",
        //        "AC/DC",
        //        1,
        //        8,
        //        19.99f,
        //        new DateTime(1980, 1, 1, new GregorianCalendar()),
        //        "Link");
        //    backInBlack.AddTracks(new List([new TrackData("Highway To Hell", 4.35f, 1)]));
        //    Data.Add(backInBlack);
        //}
        public static List<Vinyl> RunSeed()
        {
            //using var db = new VinylDbContext();

            List<Vinyl> list =
            [
                //new VinylAndTracks(
                //    new Vinyl
                //{
                //    Artist = "AC/DC",
                //    Title = "Back In Black",
                //    NumberOfTracks = 8,
                //    NumberOfLps = 1,
                //    Price = 19.99f,
                //    ReleaseDate = new DateTime(1980, 8, 10, new GregorianCalendar()),
                //    ImageLink = "Link"
                //}, new List<Track>([
                //    new Track
                //    {
                //        Title = "ACDC1",
                //        Length = 4.35f,
                //    },
                //    new Track
                //    {
                //        Title = "ACDC2",
                //        Length = 4.10f,
                //    }
                //    ]))
                //,
                //new VinylAndTracks(
                new Vinyl
                {
                    Artist = "Bon Jovi",
                    Title = "Slippery When Wet",
                    NumberOfTracks = 16,
                    NumberOfLps = 2,
                    Price = 39.99f,
                    ReleaseDate = new DateTime(1982, 3, 18, new GregorianCalendar()),
                    ImageLink = "Link",
                    Tracks = new List<Track>([
                    new Track
                    {
                        Title = "BJ1",
                        Length = 4.35f,
                    },
                        new Track
                        {
                            Title = "BJ2",
                            Length = 4.10f,
                        }
                    ])
                }
            ];
            return list;

            //foreach (Vinyl data in list)
            //{
            //    db.Add(data);
            //    //data.Vinyl.Tracks = data.Track;
            //    //foreach (Track track in data.Vinyl.Tracks)
            //    //{
            //    db.SaveChanges();

            //    //}
            //    //db.Add(data);
            //}

            //db.SaveChanges();
            //Vinyl[] vinylData = [
            //    new Vinyl
            //    {
            //        Artist = "AC/DC",
            //        Title = "Back In Black",
            //        NumberOfTracks = 8,
            //        NumberOfLps = 1,
            //        Price = 19.99f,
            //        ReleaseDate = new DateTime(1980, 1, 1, new GregorianCalendar()),
            //        ImageLink = "Link"
            //    },
            //    new Vinyl
            //    {
            //        Artist = "Bon Jovi",
            //        Title = "Slippery When Wet",
            //        NumberOfTracks = 16,
            //        NumberOfLps = 2,
            //        Price = 39.99f,
            //        ReleaseDate = new DateTime(1975, 1, 1, new GregorianCalendar()),
            //        ImageLink = "Link"
            //    },
            //    new Vinyl
            //    {
            //        Artist = "AC/DC",
            //        Title = "Back In Black",
            //        NumberOfTracks = 8,
            //        NumberOfLps = 1,
            //        Price = 19.99f,
            //        ReleaseDate = new DateTime(1980, 1, 1, new GregorianCalendar()),
            //        ImageLink = "Link"
            //    }
            //    ];

            //Track[] trackData =
            //    [
            //        new Track
            //        {
            //            Title = "Title",
            //            Length = 4.35f,
            //        }
            //    ];

            //foreach (var vinyl in vinylData)
            //{
            //    db.Add(vinyl);
            //}

        }
    }
}
