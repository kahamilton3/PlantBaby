using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantBaby.Models
{
    public class PlantParent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<PlantType> SuggestedPlants { get; set; }

        public List<MyPlantBaby> ActivePlants = new List<MyPlantBaby> { };

        public PlantParent()
        {
        }

        public PlantParent(string name, string username, string email, string password)
        {
            Name = name;
            Username = username;
            Email = email;
            Password = password;
        }

        internal void AddBaby(MyPlantBaby newPlant)
        {
            newPlant.DatePlanted = DateTime.Now;
            ActivePlants.Add(newPlant);
        }
    }
}
