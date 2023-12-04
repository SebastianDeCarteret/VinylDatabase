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
    public class SeedData

    {
        public static List<Vinyl> RunSeed()
        {
            List<Vinyl> list =
            [
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
        }
    }
}
