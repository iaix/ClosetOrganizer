using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosetOrganizer.Models;
using Microsoft.AspNetCore.Mvc;

// github test

namespace ClosetOrganizer.ViewModel
{
    public class CategoryList : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryList(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IViewComponentResult Invoke()
        {
            var categories = categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
