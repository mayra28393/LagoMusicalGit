using LagoMusical.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagoMusical
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Datos> sound = new List<Datos>();

            GeneraCancion gc = new GeneraCancion();
                     

            String sonido="";
            Console.WriteLine("\t**************************LAGO************************");
            Console.WriteLine("\n\t\t\t\tSONIDOS DE ANIMALES");
            Console.WriteLine("\n\tRana: brr, birip, brrah, croac");
            Console.WriteLine("\n\tLibelula: fiu, plop, pep");
            Console.WriteLine("\n\tGrillo: cric-cric, trri-trri, bri-bri");
            Console.Write("\n\n\tIngrese el sonido de uno de los animales de la lista: ");
            sonido = Console.ReadLine();

            gc.LlenarLista(out sound);
            gc.Cancion1(sonido, sound);
            
            Console.ReadKey();
            
        }
    }
}
