//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ClosetOrganizer.Models
//{
//    public class EditItem
//    {
//        private readonly AppDbContext appDbContext;
//        private readonly IClothItemRepository clothItemRepository;

//        public int ClothItemId { get; set; }
//        public EditItem(AppDbContext appDbContext)
//        {
//            this.appDbContext = appDbContext;
//        }


//        public IActionResult OnGet(int? clothItemId)
//        {
//            if (clothItemId.HasValue)
//            {
//                ClothItem = clothItemRepository.GetClothById(clothItemId.Value);
//            }
//            else
//            {
//                ClothItem = new ClothItem();
//            }
//            if (ClothItem == null)
//            {
//                return RedirectToPage("NotFound");
//            }
//            return Page();
//        }
//        public IActionResult OnPost()
//        {
//            if (!ModelState.IsValid)
//            {
//                Colors = htmlHelper.GetEnumSelectList<ClothingColor>();
//                Styles = htmlHelper.GetEnumSelectList<ClothingStyle>();
//                return Page();
//            }
//            if (ClothItem.ClothItemId > 0)
//            {
//                clothItemRepository.Update(ClothItem);
//            }
//            else
//            {
//                clothItemRepository.Create(ClothItem);
//            }
//            clothItemRepository.SaveChanges();
//            return RedirectToPage("ClosetList");
//        }
//    }
//}
