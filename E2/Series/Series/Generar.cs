using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    static class Generar
    {
        public static string Serie1 (int x)
        {
            int a = 1, b = 1, aux;
            string cad = " ";
            for(int i = 0; i < x; i++)
            {
                if (i == 0)
                    cad = cad + a;
                else if(i == 1)
                    cad = cad + " " + b;
                else
                {
                    aux = a;
                    a = b;
                    b = (aux+a) * (i - 1);
                    cad = cad + " " + b;
                }
                
            }
            return (cad);
        }
        public static string Serie2(int x)
        {
            string cad = " ";   int a = 2;
            for(int i = 0; i < x; i++) 
            { 
                cad= cad + a +" ";
                a = a * 2;
            }
            return (cad);
        }
    }
}
