using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema 1
            Console.WriteLine("*** Problema 1 ***");
            int num1, num2;
            string teclado1;
            Console.Write("Introduzca el primer número: ");
            teclado1 = Console.ReadLine();
            num1 = int.Parse(teclado1);
            Console.Write("Introduzca el segundo número: ");
            teclado1 = Console.ReadLine();
            num2 = int.Parse(teclado1);
            if (num1 > num2)
            {
                Console.WriteLine("La suma de los números es: " + (num1+num2));
                Console.WriteLine("La diferencia de los números es : " + (num1-num2));
            } else
            {
                Console.WriteLine("El producto de los números es: " + num1*num2);
                Console.WriteLine("La división del primero respecto al segundo es: " + (float)num1/num2);
            }
            Console.ReadKey();

            // Problema 2
            Console.WriteLine("*** Problema 2 ***");
            int[] notas = new int[3];
            int suma = 0;
            int promedio;
            string teclado2;
            string[] posicion = { "primera", "segunda", "tercera"};
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Introduzca la " + posicion[i] + " nota: ");
                teclado2 = Console.ReadLine();
                notas[i] = int.Parse(teclado2);
                suma += notas[i];
            }
            promedio = suma / notas.Length;
            if (promedio >= 5)
            {
                Console.WriteLine("Aprobado");
            } else {
                Console.WriteLine("Suspenso");
            }
            Console.ReadKey();

            // Problema 3
            Console.WriteLine("*** Problema 3 ***");
            int num3;
            string teclado3;
            bool exit = false;
            while (exit == false)
            {
                Console.Write("Introduzca un número entero de uno o dos dígitos: ");
                teclado3 = Console.ReadLine();
                num3 = int.Parse(teclado3);
                if (num3 < 10 && num3 > 0)
                {
                    Console.WriteLine("El número tiene un dígito");
                    exit = true;
                } else if (num3 > 9 && num3 < 100)
                {
                    Console.WriteLine("El número tiene dos dígitos");
                    exit = true;
                } else
                {
                    Console.WriteLine("Error");
                }
            }
            Console.ReadKey();

        }
    }
}
