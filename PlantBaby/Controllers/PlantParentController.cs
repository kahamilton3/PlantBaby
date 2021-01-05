using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantBaby.Data;
using PlantBaby.Models;
using PlantBaby.ViewModels;

namespace PlantBaby.Controllers
{
    public class PlantParentController : Controller
    {
        private PlantDbContext context;

        public PlantParentController(PlantDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index(PlantParent newPlantParent)
        {
            return View(newPlantParent);
        }

        public IActionResult Create()
        {
            CreatePlantParentViewModel createPlantParentViewModel = new CreatePlantParentViewModel();

            return View(createPlantParentViewModel);
        }

        [HttpPost]
        public IActionResult ProcessCreatePlantParentForm(CreatePlantParentViewModel createPlantParentViewModel)
        {
            if (ModelState.IsValid)
            {
                PlantParent newPlantParent = new PlantParent
                {
                    Name = createPlantParentViewModel.Name,
                    Username = createPlantParentViewModel.Username,
                    Email = createPlantParentViewModel.Email,
                    Password = createPlantParentViewModel.Password
                };
                context.PlantParents.Add(newPlantParent);
                context.SaveChanges();

                return View("Index", newPlantParent);
            } else
            {
                return View("Create", createPlantParentViewModel);
            };
        }
    }
}
