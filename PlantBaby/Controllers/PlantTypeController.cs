using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantBaby.Data;
using PlantBaby.Models;

namespace PlantBaby.Controllers
{
    public class PlantTypeController : Controller
    {
        private PlantDbContext context;

        public PlantTypeController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<PlantType> plantTypes = context.PlantTypes.ToList();
            return View(plantTypes);
        }

        public IActionResult About(int id)
        {
            PlantType thePlantType = context.PlantTypes.Find(id);
            return View(thePlantType);
        }
    }
}
