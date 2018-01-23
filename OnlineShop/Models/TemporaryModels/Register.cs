using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models.TemplateModels
{
    public class Register
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="Max value is 20")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Not correct email ")]
        public string Email { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage ="Max value is 50")]
        public string Password { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Max value is 50")]
        public string RepeatPassword { get; set; }
        [Required]
        public DateTime DatimeRegister { get; set; }

    }
}