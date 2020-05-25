using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosetOrganizer.Models
{
    public class ClothItemRepository : IClothItemRepository
    {
        private readonly AppDbContext appDbContext;

        public ClothItemRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<ClothItem> AllClothes
        {
            get
            {
                return appDbContext.ClothItems.Include(c => c.Category);
            }
        }

        public IEnumerable<ClothItem> WearableClothes
        {
            get
            {
                return appDbContext.ClothItems.Where(c => c.IsWearable);
            }
        }

        public int Commit()
        {
            return appDbContext.SaveChanges();
        }

        public ClothItem Create(ClothItem newClothItem)
        {
            appDbContext.Add(newClothItem);
            appDbContext.SaveChanges();
            return newClothItem;
        }

        public ClothItem Delete(int id)
        {
            var cloth = GetClothById(id);
            if (cloth!= null)
            {
                appDbContext.ClothItems.Remove(cloth);
            }
            appDbContext.SaveChanges();

            return cloth;
        }

        public ClothItem GetClothById(int clothId)
        {

                return appDbContext.ClothItems.FirstOrDefault(i => i.ClothItemId == clothId);
            
        }

        //public IEnumerable<ClothItem> GetClothByName(string name)
        //{
        //    var query = from c in appDbContext.ClothItems
        //                where c.Name.ToLower().StartsWith(name.ToLower()) || string.IsNullOrEmpty(name)
        //                orderby c.Name
        //                select c;
        //    return query;
        //}

        public ClothItem Update(ClothItem updatedClothItem)
        {
            var entity = appDbContext.ClothItems.Attach(updatedClothItem);
            entity.State = EntityState.Modified;
            appDbContext.SaveChanges();

            return updatedClothItem;
        }
    }
}
