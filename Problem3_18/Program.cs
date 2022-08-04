using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10～35):");
            int num = int.Parse(Console.ReadLine());
            if (-10 <= num && num <= 35)
            {
                Console.WriteLine("摂氏{0}度", num);
                Console.WriteLine();
                if (num >= 30)
                {
                    Console.WriteLine("真夏日です。");
                }
                else if (num >= 25 && num < 30)
                {
                    Console.WriteLine("夏日です。");
                }
                else if (num < 0)
                {
                    Console.WriteLine("真冬日です。");
                }
            }
            else
            {
                Console.WriteLine("適正な値を入力してください。");
            }
        }
    }
}
