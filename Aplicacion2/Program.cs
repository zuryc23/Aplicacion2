using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            string direccion = "Aplicacion2.txt";
            string linea = "";
            /*
            Console.Write("Escriba un texto: ");
            linea = Console.ReadLine();
            EscribirArchivo(direccion, linea);
            */
            LeerArchivo(direccion);
            Console.ReadKey();
        }

        static void EscribirArchivo(string ruta, string dato)
        {
            StreamWriter ar;
            ar = File.AppendText(ruta);
            ar.WriteLine(dato);
            ar.Close();
        }

        static void LeerArchivo(string ruta)
        {
            StreamReader ar;
            string linea = "";
            ar = File.OpenText(ruta);

            linea = ar.ReadLine();
            while (linea != null)
            {
                Console.WriteLine(linea);
                linea = ar.ReadLine();
            }

            ar.Close();

        }
    }
}
