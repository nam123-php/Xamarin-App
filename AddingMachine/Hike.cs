using System.ComponentModel.DataAnnotations.Schema;

namespace HikerManagementApp
{
    [Table("Hike")]
    public class Hike
    {
        [PrimaryKey, AutoIncrement]
        public int HikeId { get; set; }
        public string NameofHike { get; set; }
        public string Location { get; set; }
        public DateTime DateofHike { get; set; }
        public string ParkingAvailable { get; set; }
        public string LengththeHike { get; set; }
        public string LevelofDifficulty { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public bool Gender { get; set; }
        public string Heartbeat { get; set; }

        public Hike() { }

        public Hike(int hikeId, string nameofHike, string location, DateTime dateofHike, string parkingAvailable,
            string lengththeHike, string levelofDifficulty, string description,
            string name, DateTime doB, bool gender, string heartbeat)
        {
            HikeId = hikeId;
            NameofHike = nameofHike;
            Location = location;
            DateofHike = dateofHike;
            ParkingAvailable = parkingAvailable;
            LengththeHike = lengththeHike;
            LevelofDifficulty = levelofDifficulty;
            Description = description;
            Name = name;
            DoB = doB;
            Gender = gender;
            Heartbeat = heartbeat;
        }
    }
}