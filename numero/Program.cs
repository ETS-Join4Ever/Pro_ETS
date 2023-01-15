using System;
class numeros
{
    static void Main(string [] args)
    {
        int opcion;
        do
        {
            
            Console.WriteLine("1. Número primo");
            Console.WriteLine("2. Calcular el factorial");
            Console.WriteLine("3. devolver un número en segundos, en horas y minutos");
            Console.WriteLine("4. devolver los primeros números de la serie de Pell");
            Console.WriteLine("5. Devolver si un número es un número de Armstrong o no");
            Console.WriteLine("6. Devolver si un número tiene todos sus dígitos diferentes");
            Console.WriteLine("0. Salir");
            Console.Write("Introduce una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Introduce un numero entero.");
                    int num = Convert.ToInt32(Console.ReadLine());

                    int cont = 0;

                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            cont++;
                        }
                    }

                    if (cont > 2)
                    {
                        Console.WriteLine("El numero no es primo.");
                    }
                    else
                    {
                        Console.WriteLine("El numero es primo.");
                    }
                    break;

                    case 2:
                    Console.WriteLine("Introduce un numero.");

                    decimal numFact = Convert.ToDecimal(Console.ReadLine());

                    decimal fact = 1;

                    for (int i = 1; i <= numFact; i++)
                    {
                        fact *= i;
                    }

                    Console.WriteLine("El factorial de {0} es {1}", numFact, fact);
                    break;

                case 3:
                    int hor, min, seg;
                    int segundos = 0;

                    Console.WriteLine("Introduce una cantidad ENTERA de segundos.");
                    segundos = Convert.ToInt32(Console.ReadLine());

                    hor = (segundos / 3600);
                    min = ((segundos - hor * 3600) / 60);
                    seg = segundos - (hor * 3600 + min * 60);

                    Console.WriteLine("{0} Segundos son:\n{1} Horas\n{2} Minutos\n{3} Segundos", segundos, hor, min, seg);
                    break;
                case 4:
                    int n1 = 0;
                    int n2 = 1;
                    int n3;

                    Console.Write(n1 + " " + n2 + " ");

                    for (int i = 2; i < 15; ++i)
                    {
                        n3 = n1 + 2 * n2;
                        Console.Write(n3 + " ");
                        n1 = n2;
                        n2 = n3;
                    }
                    Console.Clear();
                    break;
                    
                case 5:
                    Console.WriteLine("Ingresa un numero");
                    string numeroTeclado = Console.ReadLine();

                    int cifras = numeroTeclado.Length;
                    int numAms = Convert.ToInt32(numeroTeclado);

                    int suma = 0, iteracion = 10, corte = 10;

                    for (int i = 0; i < cifras; i++)
                    {
                        if (i == 0)
                        {
                            suma += Convert.ToInt32(Math.Pow((numAms % iteracion), cifras));
                            iteracion *= 10;
                        }
                        else
                        {
                            suma += Convert.ToInt32(Math.Pow(((numAms % iteracion) / corte), cifras));
                            iteracion *= 10;
                            corte *= 10;
                        }
                        // Para el numero 123 serÃ¡:
                        // 1 vuelta | suma = 0 + 3^3;
                        // 2 vuelta | suma = 3^3 + 2^3;
                        // 3 vuelta | suma = 3^3 + 2^3 + 1^3;

                    }

                    if (suma == numAms)
                    {
                        Console.WriteLine("Es un numero narcisista.");
                    }
                    else
                    {
                        Console.WriteLine("NO es un numero narcisista.");
                    }
                    
                    break;

                case 6:
                    int numero;
                    Console.Write("Introduzca un número entero: ");
                    if (!int.TryParse(Console.ReadLine(), out numero))
                        Console.WriteLine("Has introducido un dato no valido.");
                    else
                    {
                        // Inicializamos un booleano para comprobar si todos los dígitos son diferentes
                        bool diferentes = true;

                        // Guardamos el número entero introducido como una cadena de caracteres
                        string numeroString = numero.ToString();

                        // Recorremos la cadena de caracteres
                        for (int i = 0; i < numeroString.Length - 1; i++)
                        {
                            // Vamos comparando los dígitos con cada uno del resto de la cadena
                            for (int j = i + 1; j < numeroString.Length; j++)
                            {
                                // Si alguno de los dígitos coincide, cambiamos el valor de la variable bool
                                if (numeroString[i] == numeroString[j])
                                    diferentes = false;
                            }
                        }

                        if (diferentes) Console.WriteLine("Todos los dígitos del número son diferentes.");
                        else Console.WriteLine("Algunos dígitos del número son iguales.");
                    }
                        break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción incorrecta");
                    break;
            }

        } while (opcion != 0);
    }
}


