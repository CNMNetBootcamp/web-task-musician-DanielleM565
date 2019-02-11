using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianRecords.Models

{
    public class Song
    {
        public int Id { get; set; }
        public string SongTitle { get; set; }
        public string Author { get; set; }


        public Album Albums { get; set; }
        public ICollection<MusicianToSong> MusicianToSong { get; set; }
    }
}