using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantBaby.Models
{
    public class PlantType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string Light { get; set; }
        public int Water { get; set; }
        public string SoilType { get; set; }

        public PlantType()
        {
        }

        public PlantType(string name, int size, string light, int water, string soilType)
        {
            Name = name;
            Size = size;
            Light = light;
            Water = water;
            SoilType = soilType;
        }
    }
}
