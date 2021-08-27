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

            NombreArchivo();
            EscribirArchivo(direccion,linea)
            LeerArchivo(direccion)
            SalidArchivo();
            Console.ReadKey();
        }

        static void NombreArchivo(char op='n', int opcio=0)
        {
            StreamWriter arE;
            while(op!='s')
            {
                Console.WriteLine("1.Nombre");
                Console.Write("Opcion: ");
                opcion=int.Parse(Console.ReadLine());
            }

            if(opcion==1)
            {
                Console.Write("Ingrese Nombre de archivo: ");
                arE = File.AppendText(Console.ReadLine()+".txt");
            }
            
            arE.Close();
            
        }

         static void EscribirArchivo(string direccion, string dato, char op='n', int opcion = 0)
         {
                
            StreamWriter arE;
              while(op!='s')
              {
                Console.WriteLine("2.Escribir");
                Console.Write("Opcion: ");
                opcion=int.Parse(Console.ReadLine());
              }

              else if(opcion==2)
              {
                arE = File.AppendText(direccion);
                arE.WriteLine("Escriba un texto: "+ dato);
                arE.WriteLine(Console.ReadLine());
              }
            
            arE.Close();      
                
         }

        static void LeerArchivo(string direccion, char op='n', int opcion=0)
        {
            StreamReader arl;
            while(op!='s')
            {
                Console.WriteLine("3.Leer");
                Console.Write("Opcion: ");
                opcion=int.Parse(Console.ReadLine());
            }

            else if(opcion==3)
            {
                string linea = "";
                arl = File.OpenText(direccion);

                linea = arl.ReadLine();
                while (linea != null)
                {
                Console.WriteLine(linea);
                linea = arl.ReadLine();
                }
            }

            arl.Close();
        }

        static void SalidArchivo(char op='n', int opcion=0)
        {
            while(op!='s')
            {
                Console.WriteLine("4.Salir");
                Console.Write("Opcion: ");
                opcion=int.Parse(Console.ReadLine());
            }

            else if(opcion==4)
            {
                Console.Write("Desea salir[s/n]")
                op=char.Parse(Console.ReadLine());
            }
        }

        


    }       

}      
