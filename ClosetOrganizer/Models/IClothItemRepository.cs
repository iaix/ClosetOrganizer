using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosetOrganizer.Models
{
    public interface IClothItemRepository
    {
        IEnumerable<ClothItem> AllClothes { get; }
        ClothItem GetClothById(int clothId);
        IEnumerable<ClothItem> WearableClothes { get; }
        //IEnumerable<ClothItem> GetClothByName(string name);
        ClothItem Create(ClothItem newClothItem);
        ClothItem Update(ClothItem updatedClothItem);
        ClothItem Delete(int id);
        int Commit();

    }
}
