using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.Models.Tables
{
    public class Shelter
    {
        [PrimaryKey, AutoIncrement]
        public int ShelterID { get; set; }

        public string Name { get; set; }
        public long Region { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
