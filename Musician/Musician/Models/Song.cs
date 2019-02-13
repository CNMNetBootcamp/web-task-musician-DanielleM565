using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianRecords.Models
{
    //Each song recorded at Notown has a title and an author.

    public class Song
    {
        public int Id { get; set; }
        [Display(Name = "Title")]
        public string SongTitle { get; set; }
        public string Author { get; set; }
        [Display(Name = "Music Key")]
        public string MusicKey { set; get; }

        public Album Albums { get; set; }
        public ICollection<MusicianToSong> MusicianToSong { get; set; }
    }
}