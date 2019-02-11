using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicianRecords.Models;

namespace MusicianRecords.Data
{
    public class RecordsContext : DbContext
    {
        public RecordsContext(DbContextOptions<RecordsContext> options) : base(options)
        {
        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<MusicianToInstrument> MusicianToInstruments { get; set; }
        public DbSet<Musician> Musicians { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musician>().ToTable("Musicians");
            modelBuilder.Entity<Instrument>().ToTable("Instrument");
            modelBuilder.Entity<MusicianToInstrument>().ToTable("MusicianToInstrument");
            modelBuilder.Entity<Address>().ToTable("Address");

            modelBuilder.Entity<MusicianToInstrument>()
                .HasKey(c => new { c.MusicianID, c.InstrumentID });
        }
    }
}
