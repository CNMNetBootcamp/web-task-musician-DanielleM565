using System.Collections.Generic;

namespace MusicianRecords.Models
{
    public class Instrument
    {
        
        public int InstrumentID { get; set; }
        public string InstrumentName { get; set; }
        //fun fact: songs can have musical keys not instruments
        //if you count vocals as an instrument there can be a vocal range which is ever changing over the life of a musician
        //moved music key to song :)

        public ICollection<MusicianToInstrument> MusicianToInstrument { get; set; }
    }
}