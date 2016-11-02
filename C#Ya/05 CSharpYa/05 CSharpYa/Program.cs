using System;

namespace Leccion05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema 1
            Console.WriteLine("*** Problema 1 ***");
            int lado, perimetro;
            string teclado1;
            Console.Write("Introduzca el lado de un cuadrado: ");
            teclado1 = Console.ReadLine();
            lado = int.Parse(teclado1);
            perimetro = 4 * lado;
            Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
            Console.ReadKey();
            
            // Problema 2
            Console.WriteLine("*** Problema 2 ***");
            int[] num2 = new int[4];
            string[] posicion2 = new string[4] { "primer", "segundo", "tercer", "cuarto" };
            string teclado2;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduzca el " + posicion2[i] + " número: ");
                teclado2 = Console.ReadLine();
                num2[i] = int.Parse(teclado2);
            }
            Console.WriteLine("La suma de los dos primeros números es: " + (num2[0]+num2[1]));
            Console.WriteLine("El producto del tercer y cuarto número es: " + (num2[2]*num2[3]));
            Console.ReadKey();

            // Problema 3
            Console.WriteLine("*** Problema 3 ***");
            int[] num3 = new int[4];
            int suma = 0;
            float promedio = 0;
            string[] posicion3 = { "primer", "segundo", "tercer", "cuarto"};
            string teclado3;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduzca el " + posicion3[i] + " número: ");
                teclado3 = Console.ReadLine();
                num3[i] = int.Parse(teclado3);
                suma += num3[i];
            }
            promedio = (float)suma / num3.Length;
            Console.WriteLine("La suma de los números es: " + suma);
            Console.WriteLine("El promedio de los números es: " + promedio);
            Console.ReadKey();

            // Problema 4
            Console.WriteLine("*** Problema 4 ***");
            float precioUnidad, precio;
            int cantidad;
            string teclado4;
            Console.Write("Introduzca el precio del artículo: ");
            teclado4 = Console.ReadLine();
            precioUnidad = float.Parse(teclado4);
            Console.Write("Introduzca la cantidad de artículos: ");
            teclado4 = Console.ReadLine();
            cantidad = int.Parse(teclado4);
            precio = precioUnidad * cantidad;
            Console.WriteLine("El precio final es: " + precio);
            Console.ReadKey();

        }
    }
}