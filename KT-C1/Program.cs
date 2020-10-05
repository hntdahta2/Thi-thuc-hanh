using System;
using System.Text;
using System.Collections.Generic;

namespace KT_C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Program program = new Program();
            int[] arr = new int[100];
            int choice = 0;
            do
            {
                Menu();
                Console.WriteLine("\nChọn: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Console.OutputEncoding = Encoding.UTF8;
                        int n = 0;
                        while (n <= 0)
                        {
                            Console.WriteLine("Nhập số phần tử mảng: ");
                            n = Convert.ToInt32(Console.ReadLine());
                            arr = new int[n];
                        }
                        CreateArray(arr); break;
                    
                    case 2:
                        bool doixung = IsSymmetryArray(arr);
                        if (doixung)
                        {
                            Console.WriteLine("Mảng đối xứng");
                        }
                        else Console.WriteLine("Mảng không đối xứng");
                        break;
                    case 3:
                        BubbleSort(arr); break;
                    case 4:
                        Find(arr); break;
                    case 5:
                        return;
                }
            } while (choice != 5);
        }
        static void CreateArray(int[] array)
        {
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(30, 60);
            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static bool IsSymmetryArray(int[] array)
        {
            int n = array.Length / 2;
            for (int i = 0; i <= n; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int arr = array[i];
                        array[i] = array[j];
                        array[j] = arr;
                    }
                }
            }
            Console.WriteLine("Mảng sau khi sắp xếp: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Find(int[] array)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập phần tử cần tìm: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                if (n.Equals(array[i]))
                {
                    Console.WriteLine($"Phần tử [{n}] nằm ở vị trí {i}"); break;
                }
                else Console.WriteLine("Không tìm thấy!");
            }
        }
        static void Menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Tạo mảng");
            Console.WriteLine("2. Kiểm tra mảng đối xứng");
            Console.WriteLine("3. Sắp xếp mảng");
            Console.WriteLine("4. Tìm kiếm mảng");
            Console.WriteLine("5. Thoát");
        }
    }
}
