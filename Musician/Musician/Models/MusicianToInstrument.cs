namespace MusicianRecords.Models
{
    public class MusicianToInstrument
    {
        public int MusicianID { get; set; }
        public int InstrumentID { get; set; }
        public Musician Muscian { get; set; }
        public Instrument Instrument { get; set; }

    }
}