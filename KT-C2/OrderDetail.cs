using System;
using System.Collections.Generic;
using System.Text;

namespace KT_C2
{
    class OrderDetail : Table
    {
        public string Name { get; set; }
        public long Price { get; set; }
        public int Count { get; set; }
        public long Total { get { return GetTotal; } }
        public long GetTotal { get; set; }

        public void Show()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Count: " + Count);
        }

        public void CalculatorTotal()
        {
            GetTotal = (long)Price * Count;
        }
    }
}
