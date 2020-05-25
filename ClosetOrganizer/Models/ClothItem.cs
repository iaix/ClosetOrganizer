using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClosetOrganizer.Models
{
    public class ClothItem
    {
        public int ClothItemId { get; set; }
        [Required(ErrorMessage ="Please enter the name")]
        [Display(Name ="Name")]
        [StringLength(32)]
        public string Name { get; set; }
        [StringLength(500)]
        public string ShortDescription { get; set; }
        [Required]
        public ClothingStyle Style { get; set; }
        [Required]
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
