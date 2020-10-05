using System;
using System.Collections.Generic;

namespace KT_C2
{
    class Coffee
    {
        int count = 0;
        Dictionary<int, Table> tCoffee = new Dictionary<int, Table>();
        public void NewOrder()
        {
            Table table = new Table();
            table.TableId = count;
            Console.WriteLine("Start Time: ");
            table.StartTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("End Time: ");
            table.EndTime = DateTime.Parse(Console.ReadLine());
            tCoffee.Add(count, table);
        }
        public void UpdateOrder()
        {
            Table table = new Table();
            OrderDetail orderDetail = new OrderDetail();
            Console.WriteLine("Enter a table ID you want to update: ");
            int n = Int32.Parse(Console.ReadLine());
            foreach (Table item in tCoffee.Values)
            {
                if (n.Equals(item.TableId))
                {
                    orderDetail.TableId = n;
                    Console.WriteLine("Name: ");
                    orderDetail.Name = Console.ReadLine();
                    Console.WriteLine("Price: ");
                    orderDetail.Price = long.Parse(Console.ReadLine());
                    Console.WriteLine("Count: ");
                    orderDetail.Count = int.Parse(Console.ReadLine());
                    tCoffee.Remove(n);
                    tCoffee.Add(n, table);
                    break;
                }
            }
        }
        public void CancelOrder()
        {
            Console.WriteLine("Please enter a table ID you want to delete: ");
            int n = Int32.Parse(Console.ReadLine());
            foreach (var item in tCoffee.Values)
                if (n.Equals(item.TableId))
                {
                    tCoffee.Remove(n);
                    Console.WriteLine("Removed Success!!");
                    break;
                }
                else Console.WriteLine("Not Found!");
        }
        public void Search()
        {
            Table table = new Table();
            bool search = false;
            Console.WriteLine("Please enter a Table ID: ");
            int n = Int32.Parse(Console.ReadLine());
            foreach (var item in tCoffee.Values)
            {
                if (n.Equals(item.TableId))
                {
                    search = true;
                    table.ShowInfo();
                }
                if (search == false)
                    Console.WriteLine("Invalid table.");
            }
        }
        public void Pay()
        {
            Console.WriteLine("Nhập ID thanh toán: ");
            int n = Int32.Parse(Console.ReadLine());
            Table table = new Table();
            OrderDetail orderDetail = new OrderDetail();
            foreach (var item in tCoffee.Values)
            {
                if (n.Equals(item.TableId))
                {
                    Console.WriteLine(orderDetail.Total);
                    Console.WriteLine(table.SumTotal);
                    Console.WriteLine(table.EndTime);
                    tCoffee.Remove(n);
                }
            }
        }
        public void Show()
        {
            foreach (var item in tCoffee.Values)
            {
                item.ShowInfo();
            }
        }
    }
}
