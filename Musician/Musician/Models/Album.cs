using System.Collections.Generic;

namespace MusicianRecords.Models
{
    public class Album
    {
        public int Id { get; set; }

        public ICollection<MusicianToAlbum> MusicianToAlbum { get; set; }
    }
}