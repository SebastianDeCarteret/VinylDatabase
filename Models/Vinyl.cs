namespace VinylDatabase.Models
{
    public class Vinyl
    {
        public int VinylId { get; set; }
        public string Title { get; set; }
        public int Artist { get; set; }
        public int NumberOfLps { get; set; }
        public int NumberOfTracks { get; set; }
        public int Price { get; set; }
        public string ImageLink { get; set; }
        public List<Track> Tracks { get; set; }

    }
}
