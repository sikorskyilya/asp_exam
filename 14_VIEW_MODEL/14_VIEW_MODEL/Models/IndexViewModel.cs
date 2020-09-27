using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A14_VIEW_MODEL.Models
{
    public class IndexViewModel //модель представления
    {
        //С помощью этой модели мы сможем передать в представление список смартфонов.
        public IEnumerable<Phone> Phones { get; set; }
    }
}