using System.Collections.Generic;

namespace MusicianRecords.Models
{
    public class Instrument
    {
        public int InstrumentID { get; set; }
        public string InstrumentName { get; set; }
        public string MusicKey { get; set; }

        public ICollection<MusicianToInstrument> MusicianToInstrument { get; set; }
    }
}