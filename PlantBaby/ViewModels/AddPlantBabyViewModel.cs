using Microsoft.AspNetCore.Mvc.Rendering;
using PlantBaby.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlantBaby.ViewModels
{
    public class AddPlantBabyViewModel
    {
        public PlantParent PlantParent { get; set; }
        public List<PlantType> PlantTypes { get; set; }
        public int PlantParentId { get; set; }
        public string PlantBabyName { get; set; }

        public AddPlantBabyViewModel(PlantParent plantParent, List<PlantType> plantTypes)
        {
            PlantParent = plantParent;
            PlantTypes = plantTypes;
        }

        public AddPlantBabyViewModel()
        {
        }
    }
}
