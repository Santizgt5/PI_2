using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2PI
{
    class Principal
    {

        private ArrayList datos;

        public Principal()
        {
            Datos = new ArrayList();

            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\data.csv");
                while((line = sr.ReadLine()) != null)
                {
                    String[] d = line.Split(',');
                    int z = Int32.Parse(d[0]);
                    ZonaMilitar zm = new ZonaMilitar(z, d[1], d[2], d[3], d[4]);
                    datos.Add(zm);
                }

            }catch(Exception e)
            {

            }
        }

        public ArrayList Datos { get => datos; set => datos = value; }

        /*public static void Main(String[] args)
        {
            Principal e = new Principal();
            for (int i = 0; i < e.datos.Count; i++)
            {
                ZonaMilitar m =  (ZonaMilitar) e.datos[i];
                Console.WriteLine("{1},{2},{3},{4},{5},", m.Zona, m.ZonaDim, m.Direccion, m.Telefono, m.Location);
            }
        }
        */
    }

    


}
