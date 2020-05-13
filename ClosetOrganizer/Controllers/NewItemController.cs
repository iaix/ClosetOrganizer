using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosetOrganizer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClosetOrganizer.Controllers
{
    public class NewItemController : Controller
    {
        private readonly IClothItemRepository clothItemRepository;
        private readonly ICategoryRepository categoryRepository;

        public NewItemController(IClothItemRepository clothItemRepository, ICategoryRepository categoryRepository)
        {
            this.clothItemRepository = clothItemRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult AddNewItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewItem(ClothItem clothItem)
        {
            clothItemRepository.Create(clothItem);
            return View(clothItem);
        }


    }
}