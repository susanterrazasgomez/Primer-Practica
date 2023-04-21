using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numliteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("numero: ");
            x= int.Parse(Console.ReadLine());
            Console.WriteLine(Numero.Literal(x));
            Console.ReadKey();
        }
    }
}
