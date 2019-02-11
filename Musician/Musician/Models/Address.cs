using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicianRecords.Models
{
    public class Address
    {
        [Key]
        public int MusicianID { get; set; }
        [StringLength(50, ErrorMessage = "Please enter an Address with less than 50 characters")]
        public string AddressLocation { get; set; }

        public Musician Musician { get; set; }
    }
}