using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("numero:");
            x= int.Parse(Console.ReadLine());
            Console.WriteLine($"Serie 1: {Generar.Serie1(x)}");
            Console.WriteLine($"Serie 2: { Generar.Serie2(x) }");
            Console.ReadKey();
        }
    }
}
