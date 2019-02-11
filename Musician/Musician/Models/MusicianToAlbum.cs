namespace MusicianRecords.Models
{
    public class MusicianToAlbum
    {
        public int AlbumID { get; set; }
        public int MusicianID { get; set; }
        public Album Album { get; set; }
        public Musician Musician { get; set; }
    }
}