using PrismaRectangularRecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prisma");
            Console.Write("Ingrese la altura del prisma:");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el largo del prisma:");
            int largo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el ancho del prisma:");
            int ancho = Convert.ToInt32(Console.ReadLine());
            Prisma p = new Prisma(altura,largo,ancho);

            Console.WriteLine(p.MostrarDatos());
            Console.ReadKey();
        }
    }
}
