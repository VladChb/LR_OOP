using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr1_3
{
    class stra
    {
        public string Type { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime FDate { get; set; }
        public DateTime LDate { get; set; }
        public decimal Price { get; set; }

        public stra(string type, string number, string name, DateTime first, DateTime last, decimal price)
        {
            Type = type;
            Number = number;
            Name = name;
            FDate = first;
            LDate = last;
            Price = price;
        }
    }

}
