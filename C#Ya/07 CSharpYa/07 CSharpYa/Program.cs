using System;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema 1
            Console.WriteLine("*** Problema 1 ***");
            int num11, num12, num13;
            string teclado1;
            Console.Write("Introduzca el primer número: ");
            teclado1 = Console.ReadLine();
            num11 = int.Parse(teclado1);
            Console.Write("Introduzca el segundo número: ");
            teclado1 = Console.ReadLine();
            num12 = int.Parse(teclado1);
            Console.Write("Introduzca el tercer número: ");
            teclado1 = Console.ReadLine();
            num13 = int.Parse(teclado1);
            if (num11 > num12 && num11 > num13)
            {
                Console.WriteLine("El mayor de los tres número es " + num11);
            } else if (num12 > num13)
            {
                Console.WriteLine("El mayor de los tres número es " + num12);
            } else
            {
                Console.WriteLine("El mayor de los tres número es " + num13);
            }
            Console.ReadKey();

            // Problema 2
            Console.WriteLine("*** Problema 2 ***");
            int num2;
            string teclado2;
            Console.Write("Introduzca un número entero: ");
            teclado2 = Console.ReadLine();
            num2 = int.Parse(teclado2);
            if (num2 > 0)
            {
                Console.WriteLine("El número es positivo");
            } else if (num2 < 0)
            {
                Console.WriteLine("El número es negativo");
            } else
            {
                Console.WriteLine("El número es nulo");
            }
            Console.ReadKey();

            // Problema 3
            Console.WriteLine("*** Problema 3 ***");
            int num3;
            string teclado3;
            Console.Write("Introduzca un número entero positivo de hasta tres cifras: ");
            teclado3 = Console.ReadLine();
            num3 = int.Parse(teclado3);
            if (num3 > 0 && num3 < 10)
            {
                Console.WriteLine("El número tiene una cifra");
            } else if (num3 > 9 && num3 < 100)
            {
                Console.WriteLine("El número tiene dos cifras");
            } else if (num3 > 99 && num3 < 1000)
            {
                Console.WriteLine("El número tiene tres cifras");
            } else
            {
                Console.WriteLine("Error: El número introducido no es válido");
            }
            Console.ReadKey();

            // Problema 4
            Console.WriteLine("*** Problema 4 ***");
            int preguntas, acertadas;
            float calificacion;
            string teclado4;
            Console.Write("Introduzca el número de preguntas totales del test: ");
            teclado4 = Console.ReadLine();
            preguntas = int.Parse(teclado4);
            Console.Write("Introduzca el número de preguntas acertadas: ");
            teclado4 = Console.ReadLine();
            acertadas = int.Parse(teclado4);
            calificacion = 100 * (float)acertadas / preguntas;
            if (calificacion >= 90)
            {
                Console.WriteLine("Nivel máximo");
            } else if (calificacion >= 75 && calificacion < 90)
            {
                Console.WriteLine("Nivel medio");
            } else if (calificacion >= 50 && calificacion < 75)
            {
                Console.WriteLine("Nivel regular");
            } else
            {
                Console.WriteLine("Fuera de nivel");
            }
            Console.ReadKey();
        }
    }
}