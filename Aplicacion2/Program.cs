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
            char op ='n';
            int opcion = 0;

              while (op != 'n')
              {
                Console.WriteLine("1.- Nombre\n2.Leer archivo\n3.- Salir");
                Console.Write("Opcion: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                      Console.Write("Nombre del archivo: " + EscribirArchivo(direccion,linea));
                      linea=Console.ReadLine();
                }

                else if (opcion == 2)
                {
                      Console.WriteLine("Escriba un texto: " + LeerArchivo(direccion));
                      linea=Console.ReadLine();
                }

                else if (opcion == 3)
                {
                    Console.Write("Desea Salir[s/n]");
                    op = char.Parse(Console.ReadLine());
                }

              }

         
            Console.ReadKey();
        }

         static void EscribirArchivo(string ruta, string dato)
         {
                
            StreamWriter arE;
            arE = File.AppendText(ruta);
            arE.WriteLine(dato);
            arE.WriteLine(Console.ReadLine());
            arE.Close();      
                
         }

        static void LeerArchivo(string ruta)
        {
            StreamReader arl;
            string linea = "";
            arl = File.OpenText(ruta);

            linea = arl.ReadLine();
            while (linea != null)
            {
                Console.WriteLine(linea);
                linea = arl.ReadLine();
            }

            arl.Close();
        }

        


    }       

}      
