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
                Console.WriteLine("5. Ordenar un Array");
                Console.WriteLine("6. Calcular la desviación típica de un array");
                Console.WriteLine("7. Binarizar un array devolviendo 0 si es menor que n y 1 en caso contrario");
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
                    case 5:
                        int elements = 0;
                        Console.WriteLine("¿De Cuántos números es el Array?");
                        elements = Convert.ToInt32(Console.ReadLine());
                        int[] intArray = new int[elements];
                        int temp = 0;
                        for(int i = 0; i < intArray.Length; i++)
                        {
                            do
                            {
                                Console.WriteLine("Enter the number {0}",i+1);
                            } while (!Int32.TryParse(Console.ReadLine(),out intArray[i]));
                        }

                        for (int i = 0; i < intArray.Length; i++)
                        {
                            for (int j = i + 1; j < intArray.Length; j++)
                            {
                                if (intArray[i] > intArray[j])
                                {
                                    temp = intArray[i];
                                    intArray[i] = intArray[j];
                                    intArray[j] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Array ordenado: ");
                        for (int i = 0; i < intArray.Length; i++)
                        {
                            Console.Write(intArray[i] + " ");
                        }
                        break;
                    case 6:
                        Console.WriteLine("¿Cuántos números tiene el Array?");
                        int elementos = Convert.ToInt32(Console.ReadLine());
                        decimal[] numeros = new decimal[elementos];
                        int k;
                        decimal sum = 0;
                        for (k = 0; k < elementos; k++)
                        {
                            do
                            {
                                Console.WriteLine("Enter the number {0}",k+1);
                            } while (!Decimal.TryParse(Console.ReadLine(),out numeros[k]));
                            sum += numeros[k];
                        }
                        decimal avg = sum / elementos;
                        decimal sum_temp = 0;
                        for(int i = 0; i < elementos; i++)
                        {
                            sum_temp += + (numeros[i] - avg) * (numeros[i]-avg) ;
                        }
                        decimal desviación= (decimal)Math.Sqrt((double)(sum_temp / elementos));
                        Console.WriteLine("La desviación típica de este array de números es: {0}",desviación);

                        break;
                    case 7:
                        Console.WriteLine("\n");
                        elements = 0;
                        do
                        {
                            Console.WriteLine("numbers of the array: ");
                        } while (!Int32.TryParse(Console.ReadLine(),out elements));
                        int[] binary=new int[elements];
                        for(int i = 0; i < elements; i++)
                        {
                            do
                            {
                                Console.WriteLine("Enter the number {0}",i+1);
                            } while (!Int32.TryParse(Console.ReadLine(), out binary[i]));
                        }
                        int reference = 0;
                        do
                        {
                            Console.WriteLine("Write the reference number: ");
                        } while (!Int32.TryParse(Console.ReadLine(), out reference));
                        for(int j = 0; j < elements; j++)
                        {
                            if(binary[j] >= reference)
                            {
                                binary[j] = 1;
                                Console.Write(binary[j]+" ");
                            }
                            else
                            {
                                binary[j] = 0;
                                Console.Write(binary[j]+" ");
                            }
                        }
                        Console.WriteLine("\n");
                        
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
