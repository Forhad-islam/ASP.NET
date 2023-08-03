using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Produ.Models
{
    public class productmodel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
    }
}