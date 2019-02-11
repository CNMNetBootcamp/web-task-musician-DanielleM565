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
        public DbSet<MusicianToSong> MusicianToSongs { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<MusicianToAlbum> MusicianToAlbums { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musician>().ToTable("Musicians");
            modelBuilder.Entity<Instrument>().ToTable("Instrument");
            modelBuilder.Entity<MusicianToInstrument>().ToTable("MusicianToInstrument");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<MusicianToSong>().ToTable("MusicianToSong");
            modelBuilder.Entity<Song>().ToTable("Song");
            modelBuilder.Entity<Album>().ToTable("Album");
            modelBuilder.Entity<MusicianToAlbum>().ToTable("MusicianToAlbum");

            modelBuilder.Entity<MusicianToInstrument>()
                .HasKey(c => new { c.MusicianID, c.InstrumentID });
            modelBuilder.Entity<MusicianToSong>()
                .HasKey(c => new { c.MusicianID, c.SongID });
            modelBuilder.Entity<MusicianToAlbum>()
                .HasKey(c => new { c.MusicianID, c.AlbumID });
        }
    }
}
