using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    internal class Mascota_adoptada: Mascota
    {
        public string Nombre_Dueno { get; set; }
        public double Pago_mascota { get; set; }
        public DateTime Fecha_Adopcion { get; set; }
        public override void Mostrar_Mascota() { }
    }
}
