using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Taller2PI
{
    public class Principal
    {
        private ArrayList datos;

        public Principal()
        {
            datos = new ArrayList();

            String line;
            try
            {
                StreamReader sr = new StreamReader("..\\..\\data.csv");
                while((line = sr.ReadLine()) != null && !line.Equals(""))
                {
                    String[] d = line.Split(',');
                    int z = Int32.Parse(d[0]);
                    ZonaMilitar zm = new ZonaMilitar(z, d[1], d[2], d[3], d[5]);
                    datos.Add(zm);
                }

                sr.Close();

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
