using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_23
{
    public class CDI
    {
        private string txt = "Empty";
        public CDI()
        {
            Console.WriteLine("CDI: конструктор");
        }
        public string Set(string s)
        {
            Console.WriteLine(this.txt = s);
            return this.txt;
        }
        public string Get()
        {
            Console.WriteLine(this.txt);
            return this.txt;
        }
    }
}
