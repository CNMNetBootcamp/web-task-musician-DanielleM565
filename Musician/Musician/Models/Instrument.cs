using System.Collections.Generic;

namespace Musician.Models
{
    public class Instrument
    {
        public int InstrumentID { get; set; }
        public string InstrumentName { get; set; }
        public string MusicKey { get; set; }

        ICollection<MusicianToInstrument> MusicianToInstrument { get; set; }
    }
}