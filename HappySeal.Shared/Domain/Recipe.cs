using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySeal.Shared.Domain
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public int MealId { get; set; }
        
        public List<Component> Components { get; set; }

    }
}
