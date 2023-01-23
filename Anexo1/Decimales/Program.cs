using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace Arrays
{
    internal class Decimales
    {
        static void Main(string[] args)
        {
            decimal num = 0;
            int opcion = -1;

            do
            {
                Console.WriteLine("1. Redondear el numero al alza");
                Console.WriteLine("2. Eliminar los decimales");
                Console.WriteLine("3. Dados tres coeficientes. Ejecutar la ecuacion de 2ndo grado");
                Console.WriteLine("0. Salir");
                Console.Write("Introduce una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Introduce un numero decimal: ");

                        num = Convert.ToDecimal(Console.ReadLine());

                        decimal resultado = Math.Ceiling(num);
                        Console.Write("El numero {0} elevado al alza es = {1}", num, resultado);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Introduce un numero decimal: ");
                        num = Convert.ToDecimal(Console.ReadLine());

                        num = Math.Truncate(num);
                        Console.Write("El numero sin decimales es = {0}", num);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        double valor1, valor2, valor3;
                        Console.Write("Introduce el primer valor [x2] = ");
                        valor1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Introduce el primer valor [x] = ");
                        valor2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Introduce el primer valor [1] = ");
                        valor3 = Convert.ToDouble(Console.ReadLine());

                        double x_1, x_2;

                        x_1 = ((-1 * valor2) + (Math.Sqrt(Math.Pow(valor2, 2) - (4 * (valor1) * (valor3))))) / (2 * valor1);
                        x_2 = ((-1 * valor2) - (Math.Sqrt(Math.Pow(valor2, 2) - (4 * (valor1) * (valor3))))) / (2 * valor1);

                        Console.WriteLine("{0}x2 + ({1}x) + ({2})\n x = {3}\n x = {4}", valor1, valor2, valor3, x_1, x_2);
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción incorrecta");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

                Console.WriteLine();
            } while (opcion != 0);
        }
    }
}
