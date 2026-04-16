using SQLite;

namespace PetLink.Models.Tables
{
    public class Pet
    {
        [PrimaryKey, AutoIncrement]
        public int PetID { get; set; }

        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public string Health { get; set; }
        public double Sociability { get; set; }
        public int Activity { get; set; }
        public bool Training { get; set; }

        [Indexed]
        public long ShelterID { get; set; }
    }
}

enum Health