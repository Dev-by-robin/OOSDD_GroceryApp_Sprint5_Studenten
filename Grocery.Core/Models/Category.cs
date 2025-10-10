using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery.Core.Models
{
    public class Category : Model
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name) : base(id, name) 
        {
            // Category class constructor
            Id = id;
            CategoryName = name;

        }
    }
}
