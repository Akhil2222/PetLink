using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.Models.Tables
{
    [Table("PetPeopleMap")]
    public class PetPeopleMap
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } // Internal primary key for the mapping row

        [Indexed]
        public long PetID { get; set; }

        [Indexed]
        public long PersonID { get; set; }

        public DateTime MeetingDate { get; set; }
    }
}
