using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numliteral
{
    static class Numero
    {
        public static string Literal(int x)
        {
            int a,c=0;
            if (x >= 0)
            {
                if (x == 0)
                    return "cero";
                else
                {
                    a = x;
                    while (a != 0)
                    {
                        a = a / 10;
                        c++;
                    }
                    string lit = " ";
                    if (c == 3)
                    {
                        switch (x / 100)
                        {
                            case 1: lit = "Cien"; break;
                            case 2: lit = "Docientos "; break;
                            case 3: lit = "Trescientos "; break;
                            case 4: lit = "Cuatrocientos "; break;
                            case 5: lit = "Quinientos "; break;
                            case 6: lit = "Seiscientos "; break;
                            case 7: lit = "Setecientos "; break;
                            case 8: lit = "Ochocientos"; break;
                            case 9: lit = "Novecientos"; break;
                        }
                        x = x % 100;
                        c--;
                    }
                    if (c == 2)
                    {
                        switch (x / 10)
                        {
                            case 1:
                                if (x % 10 == 0) { lit += "Diez"; c--; }
                                else if (x % 10 == 1) { lit += "Once"; c--; }
                                else if (x % 10 == 2) { lit += "Doce"; c--; }
                                else if (x % 10 == 3) { lit += "Trece"; c--; }
                                else if (x % 10 == 4) { lit += "Catorce"; c--; }
                                else if (x % 10 == 5) { lit += "Quince"; c--; }
                                else { lit = "Dieci"; }
                                break;
                            case 2:
                                if (x % 10 == 0) { lit += "Veinte "; c--; }
                                else { lit += "Veinti"; }
                                break;
                            case 3:
                                if (x % 10 == 0) { lit += "Treinta "; c--; }
                                else { lit += "Treinta y "; }
                                break;
                            case 4:
                                if (x % 10 == 0) { lit += "Cuarenta "; c--; }
                                else { lit += "Cuarenta y "; }
                                break;
                            case 5:
                                if (x % 10 == 0) { lit += "Cincuenta "; c--; }
                                else { lit += "Cincuenta y "; }
                                break;
                            case 6:
                                if (x % 10 == 0) { lit += "Sesenta "; c--; }
                                else { lit += "Sesenta y "; }
                                break;
                            case 7:
                                if (x % 10 == 0) { lit += "Setenta "; c--; }
                                else { lit += "Setenta y "; }
                                break;
                            case 8:
                                if (x % 10 == 0) { lit += "Ochenta "; c--; }
                                else { lit += "Ochenta y "; }
                                break;
                            case 9:
                                if (x % 10 == 0) { lit += "Noventa "; c--; }
                                else { lit += "Noventa y "; }
                                break;
                        }
                        x = x % 10;
                        c--;
                    }
                    if (c == 1)
                    {
                        switch (x)
                        {
                            case 1: lit += "Uno"; break;
                            case 2: lit += "Dos"; break;
                            case 3: lit += "Tres"; break;
                            case 4: lit += "Cuatro"; break;
                            case 5: lit += "Cinco"; break;
                            case 6: lit += "Seis"; break;
                            case 7: lit += "Siete"; break;
                            case 8: lit += "Ocho"; break;
                            case 9: lit += "Nueve"; break;
                        }
                    }
                    return (lit);
                }
            }
            else
                return "no es un numero valido";
           
        }
    }
}
