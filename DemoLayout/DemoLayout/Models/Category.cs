using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoLayout.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Category() { }
        public Category(int id, string name)
        {
            CategoryId = id;
            CategoryName = name;
        }
    }
}
