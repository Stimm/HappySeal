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
        public string Instructions { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "First Name can't exceed 50 characters")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int CookingTime { get; set; }
        [Required]
        public int Spicyness { get; set; }
        [Required]
        public int Difficulty { get; set; }
        [Required]
        public string Discription { get; set; }
        public string ImageSmall { get; set; }
        public string Image { get; set; }
        public Recipe Recipe { get; set; }
    }
}
