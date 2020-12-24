using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите положительное число");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];
                bool f = true;
                Console.WriteLine("Введите массив:");
                for (int i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                int b = a[1] - a[0];

                for (int i = 0; i < n; i++)
                {
                    if (a[i] != (a[0] + (i) * b))
                    {
                        f = false;
                        break;
                    }
                }
                if (f == false)
                    Console.WriteLine($"Разность прогрессии: {b}");
                else
                    Console.WriteLine($"Не образуют");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
