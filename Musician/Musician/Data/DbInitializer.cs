using MusicianRecords.Models;
using MusicianRecords.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MusicianRecords.Data
{
    public class DbInitializer
    {
        public static void Initialize(RecordsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Musicians.Any())
            {
                return; //Db seeded
            }
            var musicians = new Musician[]
            {
                new Musician{FirstMidName="Freddie", LastName="Mercury", SSN=123-45-6789},
                new Musician{FirstMidName="Brian", LastName="May", SSN=234-56-7891},
                new Musician{FirstMidName="John", LastName="Deacon", SSN=345-67-8912},
                new Musician{FirstMidName="Roger", LastName="Taylor", SSN=456-78-9123},
            };
            foreach (Musician m in musicians)
            {
                context.Musicians.Add(m);
            }
            context.SaveChanges();

            var addresses = new Address[]
            {
                new Address{AddressLocation="221B Baker St. London, UK", PhoneNumber=505-555-1234}
            };
            foreach (Address a in addresses)
            {
                context.Addresses.Add(a);
            }
            context.SaveChanges();

            var instruments = new Instrument[]
            {
                new Instrument{InstrumentName="Guitar",},
                new Instrument{InstrumentName="Vocals"},
                new Instrument{InstrumentName="Keyboard"},
                new Instrument{InstrumentName="Bass"},
                new Instrument{InstrumentName="Drums"},
            };
            foreach (Instrument i in instruments)
            {
                context.Instruments.Add(i);
            }
            context.SaveChanges();

            var songs = new Song[]
            {
                new Song{SongTitle="We Will Rock You", Author="Brian May", MusicKey="C Major"},
                new Song{SongTitle="We are the Champions", Author="Brian May", MusicKey="C Minor"},
                new Song{SongTitle="Bohemian Rhapsody", Author="Freddie Mercury", MusicKey="B-flat Major"},
            };
            foreach (Song s in songs)
            {
                context.Songs.Add(s);
            }
            context.SaveChanges();

            var albums = new Album[]
            {
                new Album{Producer="John Deacon", AlbumName="News of the World", CopyrightDate = DateTime.Parse("1977"), Format="Vinyl", AlbumIdnt="no. 1235"},
                new Album{Producer="Freddie Murcery", AlbumName="Bohemian Rhapsody", CopyrightDate = DateTime.Parse("1975"), Format="Vinyl", AlbumIdnt="no. 6637" }
            };
            foreach (Album a in albums)
            {
                context.Albums.Add(a);
            }
            context.SaveChanges();
        }
    }
}
