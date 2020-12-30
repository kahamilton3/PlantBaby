using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantBaby.Models
{
    public class PlantParent
    {
        public int ParentId { get; set; }
        public string Name { get; set; }
        public List<PlantType> SuggestedPlants { get; set; }
        public List<PlantBaby> ActivePlants { get; set; }

        public PlantParent()
        {
        }

        public PlantParent(string name)
        {
            Name = name;
        }

        internal void AddBaby(PlantBaby newPlant)
        {
            newPlant.DatePlanted = DateTime.Now;
            ActivePlants.Add(newPlant);
        }
    }
}
