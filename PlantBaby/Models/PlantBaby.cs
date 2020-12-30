using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantBaby.Models
{
    public class PlantBaby
    {
        public int BabyId { get; set; }
        public string Name { get; set; }
        public PlantType Type { get; set; }
        public int TypeId { get; set; }
        public DateTime DatePlanted { get; set; }
        public DateTime LastWatered { get; set; }

        public PlantBaby()
        {
        }

        public PlantBaby(string name)
        {
            Name = name;
        }

        internal void WaterPLant()
        {
            LastWatered = DateTime.Now;
        }
    }
}
