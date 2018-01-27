using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class Laptop
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The field is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The string must be between 50 and 3 symbols")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string MainImagePath { get; set; }
        public string AnotherImagesPath { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [MinLength(1,ErrorMessage ="The min value is 1")]
        [MaxLength(20,ErrorMessage ="The max value is 20")]
        public int CodeOfProduct { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [MinLength(1,ErrorMessage ="MinValue is 1")]
        public string Warrantly { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [MinLength(1, ErrorMessage = "MinValue is 1")]
        public int Price { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public bool IsOnStorage { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [MinLength(0,ErrorMessage ="The min value is 0")]
        public int Count { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Description { get; set; }
    }
}