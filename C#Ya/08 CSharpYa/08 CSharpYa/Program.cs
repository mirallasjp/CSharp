using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int problema;
            string teclado;
            Console.Write("Introduzca el número del problema que desee evaluar (1-7): ");
            teclado = Console.ReadLine();
            problema = int.Parse(teclado);
            Console.Clear();
            switch (problema)
            {
                case 1:
                    // Problema 1
                    Console.WriteLine("*** Problema 1 ***");
                    int dia, mes, ano;
                    Console.WriteLine("Introduzca la fecha de hoy.");
                    Console.Write("Número de día: ");
                    teclado = Console.ReadLine();
                    dia = int.Parse(teclado);
                    Console.Write("Número de mes: ");
                    teclado = Console.ReadLine();
                    mes = int.Parse(teclado);
                    Console.Write("Número de año: ");
                    teclado = Console.ReadLine();
                    ano = int.Parse(teclado);
                    if (dia == 25 && mes == 12)
                    {
                        Console.WriteLine("¡Hoy es Navidad!");
                    } else
                    {
                        Console.WriteLine("Aún no es Navidad");
                    }
                    break;
                case 2:
                    // Problema 2
                    Console.WriteLine("*** Problema 2 ***");
                    int[] num2 = new int[3];
                    int resultado;
                    string[] posicion2 = { "primer", "segundo", "tercer"};
                    for (int i = 0; i < num2.Length; i++)
                    {
                        Console.Write("Introduzca el " + posicion2[i] + " número: ");
                        teclado = Console.ReadLine();
                        num2[i] = int.Parse(teclado);
                    }
                    if (num2[0] == num2[1] && num2[1] == num2[2])
                    {
                        resultado = (num2[0] + num2[1]) * num2[2];
                        Console.WriteLine("El resultado de la operación es: " + resultado);
                    } else
                    {
                        Console.WriteLine("Los números no son iguales");
                    }
                    break;
                case 3:
                    // Problema 3
                    Console.WriteLine("*** Problema 3 ***");
                    int[] num3 = new int[3];
                    string[] posicion3 = { "primer", "segundo", "tercer"};
                    for (int i = 0; i < num3.Length; i++)
                    {
                        Console.Write("Introduzca el " + posicion3[i] + " número: ");
                        teclado = Console.ReadLine();
                        num3[i] = int.Parse(teclado);
                    }
                    if (num3[0] < 10 && num3[1] < 10 && num3[2] < 10)
                    {
                        Console.WriteLine("Todos los números son inferiores a diez");
                    } else
                    {
                        Console.WriteLine("Alguno de los números es superior a diez");
                    }
                    break;
                case 4:
                    // Problema 4
                    Console.WriteLine("*** Problema 4 ***");
                    int[] num4 = new int[3];
                    string[] posicion4 = { "primer", "segundo", "tercer"};
                    for (int i = 0; i < num4.Length; i++)
                    {
                        Console.Write("Introduzca el " + posicion4[i] + " número: ");
                        teclado = Console.ReadLine();
                        num4[i] = int.Parse(teclado);
                    }
                    if (num4[0] < 10 || num4[1] < 10 || num4[2] < 10)
                    {
                        Console.WriteLine("Alguno de los números es menor que diez");
                    }
                    break;
                case 5:
                    // Problema 5
                    Console.WriteLine("*** Problema 5 ***");
                    int x, y;
                    Console.Write("Introduzca la coordenada 'x' de un punto del plano x/y: ");
                    teclado = Console.ReadLine();
                    x = int.Parse(teclado);
                    Console.Write("Introduzca la coordenada 'y' de un punto del plano x/y: ");
                    teclado = Console.ReadLine();
                    y = int.Parse(teclado);
                    if (x > 0 && y > 0)
                    {
                        Console.WriteLine("El punto se encuentra en el primer cuadrante");
                    } else if (x < 0 && y > 0)
                    {
                        Console.WriteLine("El punto se encuentra en el segundo cuadrante");
                    } else if (x < 0 && y < 0)
                    {
                        Console.WriteLine("El punto se encuentra en el tercer cuadrante");
                    } else if (x > 0 && y < 0)
                    {
                        Console.WriteLine("El punto se encuentra en el cuatro cuadrante");
                    } else if (x == 0 || y == 0)
                    {
                        Console.WriteLine("Alguna de las coordenadas es cero");
                    }
                    break;
                case 6:
                    // Problema 6
                    Console.WriteLine("*** Problema 6 ***");
                    int sueldo, antiguedad;
                    Console.Write("Introduzca el sueldo del operario: ");
                    teclado = Console.ReadLine();
                    sueldo = int.Parse(teclado);
                    Console.Write("Introduzca la antigüedad, en años, del operario en la empresa: ");
                    teclado = Console.ReadLine();
                    antiguedad = int.Parse(teclado);
                    if (sueldo < 500 && antiguedad >= 10)
                    {
                        Console.WriteLine("Se ha otorgado un aumento del 20%, el nuevo sueldo del operario es: " + ((float)1.20 * sueldo));
                    } else if (sueldo < 500 && antiguedad < 10)
                    {
                        Console.WriteLine("Se ha otorgado un aumento del 5%, el nuevo sueldo del operario es: " + ((float)1.05 * sueldo));
                    } else if (sueldo >= 500)
                    {
                        Console.WriteLine("El sueldo del operario es: " + sueldo);
                    }
                    break;
                case 7:
                    // Problema 7
                    Console.WriteLine("*** Problema 7 ***");
                    int[] num7 = new int[3];
                    string[] posicion7 = { "primer", "segundo", "tercer"};
                    for (int i = 0; i < num7.Length; i++)
                    {
                        Console.Write("Introduzca el " + posicion7[i] + " número: ");
                        teclado = Console.ReadLine();
                        num7[i] = int.Parse(teclado);
                    }
                    if (num7[0] > num7[1] && num7[0] > num7[2])
                    {
                        Console.WriteLine("El mayor de los tres números es: " + num7[0]);
                        if (num7[1] < num7[2])
                        {
                            Console.WriteLine("El menor de los tres números es: " + num7[1]);
                        } else
                        {
                            Console.WriteLine("El menor de los tres números es: " + num7[2]);
                        }
                    }
                    if (num7[1] > num7[0] && num7[1] > num7[2])
                    {
                        Console.WriteLine("El mayor de los tres números es: " + num7[1]);
                        if (num7[0] < num7[2])
                        {
                            Console.WriteLine("El menor de los tres números es: " + num7[0]);
                        }
                        else
                        {
                            Console.WriteLine("El menor de los tres números es: " + num7[2]);
                        }
                    }
                    if (num7[2] > num7[0] && num7[2] > num7[1])
                    {
                        Console.WriteLine("El mayor de los tres números es: " + num7[2]);
                        if (num7[0] < num7[1])
                        {
                            Console.WriteLine("El menor de los tres números es: " + num7[0]);
                        }
                        else
                        {
                            Console.WriteLine("El menor de los tres números es: " + num7[1]);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Problema no válido");
                    break;
            }
            Console.WriteLine("Fin de la aplicación");
            Console.ReadKey();
        }
    }
}