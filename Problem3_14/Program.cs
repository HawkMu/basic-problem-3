using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,bに1から10までの数値を入力してください。");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            if (1 <= a && a <= 10 && 1 <= b && b <= 10)
            {
                if (a > b)
                {
                    Console.WriteLine("aの方が大きいです。");
                }
                else if (a < b)
                {
                    Console.WriteLine("bの方が大きいです。");
                }
                else
                {
                    Console.WriteLine("等しいです。");
                }
            }
            else
            {
                Console.WriteLine("範囲外です。");
            }
        }
    }
}
