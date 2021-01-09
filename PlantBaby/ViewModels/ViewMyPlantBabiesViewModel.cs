using PlantBaby.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantBaby.ViewModels
{
    public class ViewMyPlantBabiesViewModel
    {
        public string PlantParentName { get; set; }
        public int PlantParentId { get; set; }
        public List<MyPlantBaby> PlantParentActivePlants { get; set; }

        public ViewMyPlantBabiesViewModel(string plantParentName, int plantParentId, List<MyPlantBaby> plantParentActivePlants)
        {
            PlantParentName = plantParentName;
            PlantParentId = plantParentId;
            PlantParentActivePlants = plantParentActivePlants;

        }
    }
}
