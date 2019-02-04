using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2PI
{
    public partial class Informacion : Form
    {
        private ZonaMilitar z;
        public Informacion(ZonaMilitar zm)
        {
            z = zm;
            InitializeComponent();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            valueDireccion.Text = z.Direccion;
            string[] loc = z.Location.Split('_');
            valueLocacion.Text = "Latitud: " + loc[0] + "   Longitud: " + loc[1];
            valueZona.Text = z.Zona+"";
            valueZonaDm.Text = z.ZonaDim;
            valueTelefono.Text = z.Telefono;
            valueCiudad.Text = z.Ciudad;
        }

    
    }
}
