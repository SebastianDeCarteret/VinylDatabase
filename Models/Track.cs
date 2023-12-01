namespace VinylDatabase.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }

        public int VinylId { get; set; }
        public Vinyl Vinyl { get; set; }
    }
}
