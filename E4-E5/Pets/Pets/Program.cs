using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascota_adoptada m1= new Mascota_adoptada();
            Mascota_adoptada m2= new Mascota_adoptada();
            Mascota_adoptada m3= new Mascota_adoptada();
            Mascota_adoptada m4= new Mascota_adoptada();
            Mascota_adoptada m5= new Mascota_adoptada();
            Mascota_adoptada m6 = new Mascota_adoptada();
            Mascota_adoptada m7 = new Mascota_adoptada();
            Mascota_adoptada m8 = new Mascota_adoptada();
            Mascota_adoptada m9 = new Mascota_adoptada();
            Mascota_adoptada m10 = new Mascota_adoptada();
            m1.Nombre_Mascota = "Nemo"; m1.Edad = 2; m1.Raza = "Golden"; m1.Sexo = 'm'; m1.Nombre_Dueno = "Juan";
            m2.Nombre_Mascota = "Rocky"; m2.Edad = 1; m2.Raza = "Dalmata"; m2.Sexo = 'm'; 
            m3.Nombre_Mascota = "Coco"; m3.Edad = 0; m3.Raza = "Bobtail"; m3.Sexo = 'h';
            m4.Nombre_Mascota = "Winston"; m4.Edad = 2; m4.Raza = "Beagle"; m4.Sexo = 'm';
            m5.Nombre_Mascota = "Tom"; m5.Edad = 5; m5.Raza = "Carlino"; m5.Sexo = 'm';
            m6.Nombre_Mascota = "Max"; m6.Edad = 4; m6.Raza = "Chihuahua"; m6.Sexo = 'm';
            m7.Nombre_Mascota = "Milo"; m7.Edad = 2; m7.Raza = "Pug"; m7.Sexo = 'm';
            m8.Nombre_Mascota = "Cookie"; m8.Edad = 1; m8.Raza = "Chow Chow"; m8.Sexo = 'h';
            m9.Nombre_Mascota = "Princesa"; m9.Edad = 0; m9.Raza = "Collie"; m9.Sexo = 'h';
            m10.Nombre_Mascota = "Dante"; m10.Edad = 7; m10.Raza = "Galgo"; m10.Sexo = 'm';
            List<Mascota_adoptada> mascotas= new List<Mascota_adoptada>();
            mascotas.Add(m1);
            mascotas.Add(m2);
            mascotas.Add(m3);
            mascotas.Add(m4);
            mascotas.Add(m5);
            mascotas.Add(m6);
            mascotas.Add(m7);
            mascotas.Add(m8);
            mascotas.Add(m9);
            mascotas.Add(m10);

        }
    }
}
