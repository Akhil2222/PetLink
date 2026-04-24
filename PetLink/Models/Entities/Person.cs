using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.Models.Entities
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Region { get; set; }
        public int Stability { get; set; }
        public string Password { get; set; }
        public List<Pet> LikedPets { get; set; } 
    }
}
