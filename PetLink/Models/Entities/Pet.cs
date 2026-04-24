using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.Models.Entities
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; } // Enums are usually stored as strings or ints
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Health { get; set; }
        public double Sociability { get; set; }
        public int Activity { get; set; }
        public bool Training { get; set; }

        // Foreign Key Reference
        public string ShelterID { get; set; }
    }
}