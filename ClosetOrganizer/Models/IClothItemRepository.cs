using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosetOrganizer.Models
{
    interface IClothItemRepository
    {
        IEnumerable<ClothItem> AllClothes { get; }
        ClothItem GetClothById(int clothId);
    }
}
