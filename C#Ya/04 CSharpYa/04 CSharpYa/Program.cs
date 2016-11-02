using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion04
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int superficie;
            string teclado;
            Console.Write("Introduzca el lado de un cuadrado: ");
            teclado = Console.ReadLine();
            lado = int.Parse(teclado);
            superficie = lado * lado;
            Console.WriteLine("La superficie del cuadrado es: " + superficie);
            Console.ReadKey();
        }
    }
}
