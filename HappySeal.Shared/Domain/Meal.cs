using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HappySeal.Shared.Domain
{
    public class Meal
    {
        public int MealId { get; set; }
        public Cuisene Cuisene { get; set; }
        public string Instructions { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CookingTime { get; set; }
        public int Spicyness { get; set; }
        public int Difficulty { get; set; }
        public string Discription { get; set; }
        public string ImageSmall { get; set; }
        public string Image { get; set; }
        public Recipe Recipe{ get; set; }
    }
}
