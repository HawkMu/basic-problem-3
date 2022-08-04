using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("点数(1-100):");
            int a = int.Parse(Console.ReadLine());
            if (1 <= a && a <= 100)
            {
                if (a >= 80)
                {
                    Console.WriteLine("優");
                }
                else if (a < 80 && a >= 70)
                {
                    Console.WriteLine("良");
                }
                else if (a < 70 && a >= 60)
                {
                    Console.WriteLine("可");
                }
                else if (a < 60)
                {
                    Console.WriteLine("不可");
                }
            }
            else
            {
                Console.WriteLine("範囲外");
            }
        }
    }
}
