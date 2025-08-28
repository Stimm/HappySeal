using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HappySeal.Shared.Domain
{
    public class Meal
    {
        public int MealId { get; set; }
        [Required]
        public int CuiseneId { get; set; }
        public Cuisene Cuisene { get; set; }
        //[Required]
        public string Instructions { get; set; } = string.Empty;
        [Required]
        [StringLength(60, ErrorMessage = "First Name can't exceed 50 characters")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int CookingTime { get; set; }
        [Required]
        public int Spicyness { get; set; }
        [Required]
        public int Difficulty { get; set; }
        
        public string Discription { get; set; } = string.Empty;
        public string ImageSmall { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public Recipe Recipe { get; set; }
    }
}
