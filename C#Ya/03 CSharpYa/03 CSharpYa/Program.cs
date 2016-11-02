using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion03
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            float precioHora;
            float sueldo;
            string teclado;
            Console.Write("Horas trabajadas por el operario: ");
            teclado = Console.ReadLine();
            horas = int.Parse(teclado);
            Console.Write("Precio por hora trabajada: ");
            teclado = Console.ReadLine();
            precioHora = float.Parse(teclado);
            sueldo = horas * precioHora;
            Console.WriteLine("El sueldo del operario es: " + sueldo);
            Console.ReadKey();
        }
    }
}
