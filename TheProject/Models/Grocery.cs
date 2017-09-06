using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheProject.Models
{
    public class Grocery {
        public int GroceryID { get; set; }
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
