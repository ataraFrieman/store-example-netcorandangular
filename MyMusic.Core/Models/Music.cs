namespace MyMusic.Core.Models
{
    public class Music: EntityBase
    {
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
    }
}

