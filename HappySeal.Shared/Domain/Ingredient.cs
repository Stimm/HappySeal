using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySeal.Shared.Domain
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "First Name can't exceed 50 characters")]
        public string Name { get; set; } = string.Empty;
    }
}
