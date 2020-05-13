using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosetOrganizer.Models;
using ClosetOrganizer.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ClosetOrganizer.Controllers
{
    public class ClosetController : Controller
    {
        private readonly IClothItemRepository clothItemRepository;
        private readonly ICategoryRepository categoryRepository;

        public ClosetController(IClothItemRepository clothItemRepository, ICategoryRepository categoryRepository)
        {
            this.clothItemRepository = clothItemRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            IEnumerable<ClothItem> clothItems;

            clothItems = clothItemRepository.AllClothes.OrderBy(c=>c.Name);
            return View(new ClothListViewModel
            {
                ClothItems = clothItems
            });
        }
        public ViewResult GetListOfCategoryName()
        {
            return View(categoryRepository.AllCategories.Select(c => c.CategoryName).ToList());
        }
        public IActionResult Details(int id)
        {
            var cloth = clothItemRepository.GetClothById(id);
            if (cloth == null)
                return NotFound();
            return View(cloth);
        }
        public IActionResult Edit(int id)
        {
            var cloth = clothItemRepository.GetClothById(id);
            if (cloth == null)
                return NotFound();
            return View(cloth);
        }

        public RedirectToActionResult EditConfirm(ClothItem clothItem)
        {
            //var cloth = clothItemRepository.GetClothById(clothItem.ClothItemId);
            if (clothItem == null)
            {
                return RedirectToAction("List");
            }

            clothItemRepository.Update(clothItem);
            return RedirectToAction("List");
        }


        public RedirectToActionResult RemoveFromCloset(int id)
        {
            var cloth = clothItemRepository.AllClothes.FirstOrDefault(c => c.ClothItemId == id);
            if (cloth != null) clothItemRepository.Delete(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult ListCategories()
        {
            var categories = categoryRepository.AllCategories.ToList();
            var viewModel = new CategoryListViewModel { Categories = categories };
            return View(viewModel);
        }
    }
}