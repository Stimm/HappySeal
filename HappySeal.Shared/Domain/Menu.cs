using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappySeal.Shared.Domain
{
    public class Menu
    {
        public int MenuId{ get; set; }
        public List<MenuItem> MenueItems{ get; set; } = new List<MenuItem>();
    }
}
