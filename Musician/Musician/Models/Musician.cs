using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianRecords.Models
{
    public class Musician
    {
        //Each musician that records at Notown has an SSN, a name, an address, and a phone number. 
        public int ID { get; set; }
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int SSN { get; set; }

        public Address Addresses { get; set; }
        public ICollection<MusicianToInstrument> MusicianToInstrument { get; set; }
        public ICollection<MusicianToSong> MusicianToSong { get; set; }
        public ICollection<Album> Album { get; set; }

    }
}
