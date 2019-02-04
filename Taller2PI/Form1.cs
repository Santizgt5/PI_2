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

namespace Taller2PI
{
    public partial class Form1 : Form
    {
        public Principal p;
        public Form1()
        {
            InitializeComponent();
            p = new Principal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            addMarkers();
        }

        private void addMarkers()
        {
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            ArrayList datos = p.Datos;
            for(int i = 0; i < datos.Count; i++)
            {
                ZonaMilitar z = (ZonaMilitar)datos[i];
                string[] loc = z.Location.Split('_');
                double lat = double.Parse(loc[0]);
                Console.Write(lat);
                double lon = double.Parse(loc[1]);
                Console.Write(lon);


                GMap.NET.WindowsForms.GMapMarker marker =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new GMap.NET.PointLatLng(lat, lon),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                markers.Markers.Add(marker);
                gmap.Overlays.Add(markers);
            }
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            MessageBox.Show("Clicked");
        }
    }
}
