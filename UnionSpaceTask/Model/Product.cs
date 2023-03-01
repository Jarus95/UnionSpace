using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionSpaceTask.Model
{
    public class Product
    {
        public bool IsChange { get; set; }
        public int Id { get; set; }
        public string? Article { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        
    }
}
