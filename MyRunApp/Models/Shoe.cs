using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyRunApp.Models
{
    public class Shoe
    {
        // EF will instruct the database to automatically generate this value
        public int ShoeId { get; set; }

        [Required(ErrorMessage = "Please enter a Brand.")]
        public string Brand { get; set; }


        [Required(ErrorMessage = "Please enter a Name.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter shoe use; Road or Trail.")]
        public string Use { get; set; }


        [Required(ErrorMessage = "Pleasse enter a support Type; Neutral or Stability.")]
        public string Support { get; set; }

        [Required(ErrorMessage = "Pleasse enter a Color.")]
        public string ColorId { get; set; }
        public Color Color { get; set; }

        //[Required(ErrorMessage = "Please enter a size.")]
        //[Range(5, 14, ErrorMessage = "Size must be between 5 and 14.")]
        //public int? Size { get; set; }


        //public string Slug =>
        //Name?.Replace(' ', '-').ToLower() + '-' + Size?.ToString();
    }
}
