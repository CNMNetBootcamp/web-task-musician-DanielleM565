using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Musician.Models;

namespace NotownRecords.Data
{
    public class RecordsContext : DbContext
    {
        public RecordsContext(DbContextOptions<RecordsContext> options) : base(options)
        {
        }

        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        DbSet<MusicianToInstrument> MusicianToInstruments { get; set; }
        public DbSet<Musician> Musicians { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musician>().ToTable("Musicians");
        }
    }
}
