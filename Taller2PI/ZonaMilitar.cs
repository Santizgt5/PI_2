using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2PI
{
    class ZonaMilitar
    {

        private int zona;
        private string zonaDim;
        private string direccion;
        private string telefono;
        private string location;

        public ZonaMilitar(int zona, string zonaDim, string direccion, string telefono, string location)
        {
            this.Zona = zona;
            this.ZonaDim = zonaDim;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Location = location;
        }

        public int Zona { get => zona; set => zona = value; }
        public string ZonaDim { get => zonaDim; set => zonaDim = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Location { get => location; set => location = value; }
    }
}
