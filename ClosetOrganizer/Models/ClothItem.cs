using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClosetOrganizer.Models
{
    public class ClothItem
    {
        public int ClothId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public ClothingStyle Style { get; set; }
        public ClothingColor Color { get; set; }
        public Category Category { get; set; }
        public bool IsWearable { get; set; }

    }


    public enum ClothingStyle
    {
        None,
        Casual,
        BusinessCasual,
        Formal,
        Vintage
    }

    public enum ClothingColor
    {
        None,
        Black,
        White,
        Blue,
        Pink
    }
}
