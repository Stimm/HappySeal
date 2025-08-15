using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySeal.Shared.Domain
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public int MenuId { get; set; }
        public Meal Meal { get; set; }
        public DateTime DateLastUsed { get; set; }

    }
}
