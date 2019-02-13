using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicianRecords.Models
{
    public class Album
    {
        //Each album recorded on the Notown label has a unique identification number, a title, a copyright date, a format (e.g., CD or MC), and an album identifier.
        public int Id { get; set; }
        public int MusicianID { get; set; }
        public string Producer { get; set; }
        [Display(Name = "Album")]
        public string AlbumName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Copyright Date")]
        public DateTime CopyrightDate { get; set; }
        public string Format { get; set; }
        [Display(Name = "Album Id")]
        public string AlbumIdnt { get; set; }


        //navigational properties
        public Musician Musician { get; set; }
    }
}