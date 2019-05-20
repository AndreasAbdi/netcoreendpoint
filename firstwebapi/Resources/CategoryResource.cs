using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstwebapi.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public CategoryResource(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
