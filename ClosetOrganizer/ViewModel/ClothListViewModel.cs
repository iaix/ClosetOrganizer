using ClosetOrganizer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosetOrganizer.ViewModel
{
    public class ClothListViewModel
    {
        public IEnumerable<ClothItem> ClothItems { get; set; }
        public string CurrentCategory { get; set; }
        public ClothingColor Color { get; set; }
        [TempData]
        public string Message { get; set; }
    }
}
