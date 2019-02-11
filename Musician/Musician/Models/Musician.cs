using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musician.Models
{
    public class Musician
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int SSN { get; set; }
        public int PhoneNumber { get; set; }

        public Address Addresses { get; set; }

    }
}
