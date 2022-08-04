using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力:");
            int a = int.Parse(Console.ReadLine());
            if (a != 4)
            {
                Console.WriteLine("4ではありません。");
            }
        }
    }
}
