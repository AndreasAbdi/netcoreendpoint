using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Domain.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public IList<Product> Products { get; set; } = new List<Product>();
    }
}
