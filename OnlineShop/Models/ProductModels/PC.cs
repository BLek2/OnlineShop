using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class PC
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "The string must be between 50 and 3 symbols")]
        public string Title { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string MainImagePath { get; set; }
        public string AnotherImagesPath { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public int? CodeOfProduct { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public int? Warrantly { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [Range(1, 999999, ErrorMessage = "Ivalid field")]
        public int? Price { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public bool IsOnStorage { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [Range(1, 10000, ErrorMessage = "Ivalid field")]
        public int? Count { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Description { get; set; }
    }
}