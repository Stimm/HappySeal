using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySeal.Shared.Domain
{
    public class Component
    {
        public int ComponentId { get; set; }
        public int RecipeId { get; set; }
        public Ingredient? Ingredient { get; set; }
        public int IngredientId { get; set; }
        [Required]
        public int amount { get; set; }
        [Required]
        public string Measurement { get; set; } = string.Empty;
    }
}
