using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("0から100までの数値を入力してください:");
            int a = int.Parse(Console.ReadLine());
            if (0 <= a && a <= 100)
            {
                if (a >= 20 && a < 80)
                {
                    Console.WriteLine("20以上80未満です。");
                }
                else
                {
                    Console.WriteLine("20未満か、80以上です。");
                }
            }
            else
            {
                Console.WriteLine("範囲外です。");
            }
        }
    }
}
