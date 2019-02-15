using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicianRecords.Models
{
    public class Address
    {
        //Poorly paid musicians often share the same address, and no address has more than one phone.
        public int AddressID { get; set; }
        [StringLength(50, ErrorMessage = "Please enter an Address with less than 50 characters")]
        public string AddressLocation { get; set; }
        public int PhoneNumber { get; set; }

    }
}