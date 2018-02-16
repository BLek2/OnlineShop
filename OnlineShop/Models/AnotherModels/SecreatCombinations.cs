using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineShop.Models.AnotherModels
{
    public class SecreatCombinations
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field is required")]
        [StringLength(20,MinimumLength =6,ErrorMessage ="The string must between 20 and 6 symbols")]
        public string SecreatCombination { get; set; }
    }
}