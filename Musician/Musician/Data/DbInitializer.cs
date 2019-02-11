using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicianRecords.Data
{
    public class DbInitializer
    {
        public static void Initialize(RecordsContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
