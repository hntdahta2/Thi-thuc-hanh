using System;
using System.Collections.Generic;
using System.Text;

namespace KT_C2
{
    class Table : ITable
    {
        public int TableId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public long SumTotal { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        
        public void ShowInfo()
        {
            Console.WriteLine("Table Id: " + TableId);
            Console.WriteLine("Start Time: " + StartTime);
            Console.WriteLine("End Time: " + EndTime);


        }
        
        public void Pay()
        {
            foreach (OrderDetail item in orderDetails)
                SumTotal =+ item.Total;
        }
    }
}
