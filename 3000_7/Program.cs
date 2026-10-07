using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3000_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.WriteLine(rnd.Next(1,11));

            Console.WriteLine(Math.Min(5,10)); //5
            Console.WriteLine(Math.Max(5, 10)); //10
            Console.WriteLine(Math.Pow(2,3)); //2^3 = 8
            Console.WriteLine(Math.Sqrt(9)); //3
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
                                             

        }
    }
}
