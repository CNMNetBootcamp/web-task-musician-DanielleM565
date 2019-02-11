namespace MusicianRecords.Models
{
    public class MusicianToSong
    {
        public int MusicianID { get; set; }
        public int SongID { get; set; }
        public Musician Musician { get; set; }
        public Song Song { get; set; }
    }
}