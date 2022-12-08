using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    internal class ProductForList
    {
        public int ID { get; set; } 
        public string Name { get; set; }    
        public double Price { get; set; }   
        public Category Category { get; set; }

     public override string ToString() => $@"
id = {Id},
name = {Name},
price = {Price},
category = {Category}";
    }
}
