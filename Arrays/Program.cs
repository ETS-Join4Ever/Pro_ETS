using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion, longitud, maximo, minimo, suma, media, mediana, aux;
            int[] array;

            do
            {
                Console.WriteLine("1. Máximo");
                Console.WriteLine("2. Mínimo");
                Console.WriteLine("3. Media");
                Console.WriteLine("4. Mediana");
                Console.WriteLine("0. Salir");
                Console.Write("Introduce una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Introduce la longitud del array: ");
                        longitud = Convert.ToInt32(Console.ReadLine());
                        array = new int[longitud];
                        maximo = 0;

                        for (int i = 0; i < longitud; i++)
                        {
                            Console.Write("Introduce un número: ");
                            array[i] = Convert.ToInt32(Console.ReadLine());

                            if (array[i] > maximo)
                            {
                                maximo = array[i];
                            }
                        }

                        Console.WriteLine("El valor máximo es {0}", maximo);
                        break;
                    case 2:
                        Console.Write("Introduce la longitud del array: ");
                        longitud = Convert.ToInt32(Console.ReadLine());
                        array = new int[longitud];
                        minimo = 0;

                        for (int i = 0; i < longitud; i++)
                        {
                            Console.Write("Introduce un número: ");
                            array[i] = Convert.ToInt32(Console.ReadLine());

                            if (array[i] < minimo)
                            {
                                minimo = array[i];
                            }
                        }

                        Console.WriteLine("El valor mínimo es {0}", minimo);
                        break;
                    case 3:
                        Console.Write("Introduce la longitud del array: ");
                        longitud = Convert.ToInt32(Console.ReadLine());
                        array = new int[longitud];
                        suma = 0;

                        for (int i = 0; i < longitud; i++)
                        {
                            Console.Write("Introduce un número: ");
                            array[i] = Convert.ToInt32(Console.ReadLine());

                            suma += array[i];
                        }

                        media = suma / longitud;
                        Console.WriteLine("La media es {0}", media);
                        break;
                    case 4:
                        Console.Write("Introduce la longitud del array: ");
                        longitud = Convert.ToInt32(Console.ReadLine());
                        array = new int[longitud];
                        mediana = 0;

                        for (int i = 0; i < longitud; i++)
                        {
                            Console.Write("Introduce un número: ");
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        for (int i = 0; i < longitud; i++)
                        {
                            for (int j = 0; j < longitud - 1; j++)
                            {
                                if (array[j] > array[j + 1])
                                {
                                    aux = array[j];
                                    array[j] = array[j + 1];
                                    array[j + 1] = aux;
                                }
                            }
                        }

                        if (longitud % 2 == 0)
                        {
                            mediana = (array[longitud / 2] + array[longitud / 2 - 1]) / 2;
                        }
                        else
                        {
                            mediana = array[longitud / 2];
                        }

                        Console.WriteLine("La mediana es {0}", mediana);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 0);
        }
    }
}
