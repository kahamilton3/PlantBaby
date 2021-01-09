using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantBaby.Data;
using PlantBaby.Models;
using PlantBaby.ViewModels;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult AddPlantBaby(int id)
        {
            PlantParent thePlantParent = context.PlantParents.Find(id);
            List<PlantType> possibleTypes = context.PlantTypes.ToList();
            AddPlantBabyViewModel newViewModel = new AddPlantBabyViewModel(thePlantParent, possibleTypes);
            return View(newViewModel);
        }

        public IActionResult ProcessAddPlantBabyForm(AddPlantBabyViewModel addPlantBabyViewModel, string[] selectedTypes)
        {
            PlantParent thePlantParent = context.PlantParents.Find(addPlantBabyViewModel.PlantParentId);
            
            foreach (string type in selectedTypes)
                {
                PlantType thePlantType = context.PlantTypes.Find(Int32.Parse(type));

                MyPlantBaby myPlantBaby = new MyPlantBaby
                {
                    Name = addPlantBabyViewModel.PlantBabyName,
                    Type = thePlantType,
                    TypeId = thePlantType.Id,
                    PlantParent = thePlantParent
                };
                
                thePlantParent.AddBaby(myPlantBaby);
                context.MyPlantBabies.Add(myPlantBaby);
                }
            
            context.SaveChanges();

            List<MyPlantBaby> activePlants = context.MyPlantBabies
                .Where(mpb => mpb.PlantParentId == thePlantParent.Id)
                .Include(mpb => mpb.Type)
                .ToList();

            ViewMyPlantBabiesViewModel viewModel = new ViewMyPlantBabiesViewModel(thePlantParent.Name, thePlantParent.Id, activePlants);

            return View("ViewMyPlantBabies", viewModel);
        }

        public IActionResult ViewMyPlantBabies(ViewMyPlantBabiesViewModel viewModel)
        {
            return View(viewModel);
        }
    }
}
