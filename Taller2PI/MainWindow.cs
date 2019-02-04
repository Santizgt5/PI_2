using GMap.NET.WindowsForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace Taller2PI
{
    public partial class MainWindow : Form
    {
        public Principal p;
        public MainWindow()
        {
            InitializeComponent();
            p = new Principal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            addMarkers();
        }

        private void addMarkers()
        {
            GMapOverlay markers = new GMapOverlay("markers");
            ArrayList datos = p.Datos;
            for(int i = 0; i < datos.Count; i++)
            {
                ZonaMilitar z = (ZonaMilitar)datos[i];
                string[] loc = z.Location.Split('_');
                double lat = double.Parse(loc[0]);
                double lon = double.Parse(loc[1]);

                GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green_pushpin);
                markers.Markers.Add(marker);
            }
                gmap.Overlays.Add(markers);
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            string lat = item.Position.Lat+"";
            string lon = item.Position.Lng + "";
            ZonaMilitar zm = BuscarZona(lat, lon);
            Informacion inf = new Informacion(zm);
            inf.Show();
        }

        public ZonaMilitar BuscarZona(string la, string lo)
        {
            return p.BuscarZonaMil(la, lo);
        }
    }
}
