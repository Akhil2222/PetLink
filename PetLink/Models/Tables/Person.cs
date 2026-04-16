using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetLink.Models.Tables
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public long PeopleID { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Region { get; set; }
        public int Stability { get; set; }
        public string Password { get; set; }
    }
}
