using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    internal class Mascota
    {
        public string Nombre_Mascota { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public char Sexo { get; set; }
        public virtual void Mostrar_Mascota() { }
    }
}
