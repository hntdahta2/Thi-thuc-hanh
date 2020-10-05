using System;

namespace KT_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetail orderDetail = new OrderDetail();
            Coffee coffee = new Coffee();
            Table table = new Table();
            int choice;
            do
            {
                Console.WriteLine("1. New Order");
                Console.WriteLine("2. Update Order");
                Console.WriteLine("3. Cancel Order");
                Console.WriteLine("4. Search");
                Console.WriteLine("5. Pay");
                Console.WriteLine("6. Exit");

                Console.WriteLine("\n Select: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Table ID: ");
                        int n = Int32.Parse(Console.ReadLine());
                        if (table.TableId == n)
                        {
                            Console.WriteLine("Table is using");
                        }
                        else
                        coffee.NewOrder();
                        Console.WriteLine("Name: ");
                        orderDetail.Name = Console.ReadLine();
                        Console.WriteLine("Price: ");
                        orderDetail.Price = long.Parse(Console.ReadLine());
                        Console.WriteLine("Count: ");
                        orderDetail.Count = Int32.Parse(Console.ReadLine());
                        coffee.NewOrder();
                        table.ShowInfo();
                        orderDetail.Show();
                        break;
                    case 2:
                        Console.WriteLine("Enter Table ID: ");
                        int a = Int32.Parse(Console.ReadLine());
                        if (table.TableId != a)
                        {
                            Console.WriteLine("Invalid Table");
                        }
                        else
                            coffee.UpdateOrder();
                        break;
                    case 3:
                        coffee.CancelOrder();
                        break;
                    case 4:
                        coffee.Search();
                        break;
                    case 5:
                        coffee.Pay();
                        break;
                    case 6: return;
                }
            }
            while (choice != 6);
        }
    }
}
