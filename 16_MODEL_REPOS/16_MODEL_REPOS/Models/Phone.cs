using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _16_MODEL_REPOS.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
    }
}