using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    internal class Mascota_perdida: Mascota
    {
        public string motivo { get; set; }
        public DateTime Fecha_perdida { get; set; }
        public override void Mostrar_Mascota() { }

    }
}
