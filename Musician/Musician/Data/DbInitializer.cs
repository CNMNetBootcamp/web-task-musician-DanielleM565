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

            //if (context.Musicians.Any())
            //{
            //    return; //Db seeded
            //}

            if (context.Musicians.Any())
            {
                foreach (var musician in context.Musicians)
                {
                    context.Musicians.Remove(musician);
                }
                context.SaveChanges();
                AddMusicians(context);
            }
            else
            {
                AddMusicians(context);
            }

            if (context.Addresses.Any())
            {
                foreach (var address in context.Addresses)
                {
                    context.Addresses.Remove(address);
                }
                context.SaveChanges();
                AddAddresses(context);
            }
            else
            {
                AddAddresses(context);
            }

            if (context.Instruments.Any())
            {
                foreach (var instrument in context.Instruments)
                {
                    context.Instruments.Remove(instrument);
                }
                context.SaveChanges();
                AddInstruments(context);
            }
            else
            {
                AddInstruments(context);
            }

            if (context.Songs.Any())
            {
                foreach (var song in context.Songs)
                {
                    context.Songs.Remove(song);
                }
                context.SaveChanges();
                AddSongs(context);
            }
            else
            {
                AddSongs(context);
            }

            if (context.Albums.Any())
            {
                foreach (var album in context.Albums)
                {
                    context.Albums.Remove(album);
                }
                context.SaveChanges();
                AddAlbums(context);
            }
            else
            {
                AddAlbums(context);
            }
        }

        private static void AddAlbums(RecordsContext context)
        {
            var albums = new Album[]
        {
                new Album{Producer="John Deacon", AlbumName="News of the World", CopyrightDate = DateTime.Parse("01-01-1977"), Format="Vinyl", AlbumIdnt="no. 1235"},
                new Album{Producer="Freddie Murcery", AlbumName="Bohemian Rhapsody", CopyrightDate = DateTime.Parse("01-01-1975"), Format="Vinyl", AlbumIdnt="no. 6637" }
        };
            foreach (Album a in albums)
            {
                context.Albums.Add(a);
            }
            context.SaveChanges();
        }

        private static void AddSongs(RecordsContext context)
        {
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
        }

        private static void AddInstruments(RecordsContext context)
        {
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
        }

        private static void AddAddresses(RecordsContext context)
        {
            var addresses = new Address[]
                        {
                new Address{AddressLocation="221B Baker St. London, UK", PhoneNumber=505-555-1234}
                        };
            foreach (Address a in addresses)
            {
                context.Addresses.Add(a);
            }
            context.SaveChanges();
        }

        private static void AddMusicians(RecordsContext context)
        {
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
        }
    }
}
