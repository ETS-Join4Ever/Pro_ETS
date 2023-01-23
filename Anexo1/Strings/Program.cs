using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            
                Console.WriteLine("1. Devolver si el string es un palíndromo");
                Console.WriteLine("2. Escribir el nombre todo en mayúsculas y todo en minúsculas");
                Console.WriteLine("3. Devolver el número de ocurrencias de una letra");
                Console.WriteLine("4. Dados dos Strings distintos, hacer que se repitan las veces que informe el usuario.");
                Console.WriteLine("5. Dado un String, repetir cada ocurrencia de su letra");
                Console.WriteLine("6. Dado dos Strings, borrar del primero las apariencias del segundo.");
                Console.WriteLine("0. Salir");
                Console.Write("Introduce una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    
                    case 1:
                        int i = 0, j = 0;
                        bool isPalin = true;
                        Console.WriteLine("Enter a word:");
                        string chain = Console.ReadLine();
                        j = chain.Length - 1;
                        while (i < j && isPalin)
                        {
                            if (chain[i] != chain[j])
                            {
                                isPalin = false;
                            }
                            else
                            {
                                i++;
                                j--;
                            }
                        }
                        if (isPalin)
                        {
                            Console.WriteLine("Is a palindrome");
                        }
                        else
                        {
                            Console.WriteLine("Is NOT a palindrome");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Escribe tu nombre: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Tu nombre en mayúscula es: {0}, y tu nombre en minúscula es: {1}.", name.ToUpper(), name.ToLower());
                        break;
                    case 3:
                        int cont = 0;
                        Console.WriteLine("Introduce una frase: ");
                        string phrase = Console.ReadLine();
                        Console.WriteLine("Introduce la letra a comparar");
                        char ocurr = Convert.ToChar(Console.ReadLine());
                        for (i = 0; i < phrase.Length; i++)
                        {
                            if (phrase[i] == ocurr)
                            {
                                cont++;
                            }
                        }
                        Console.WriteLine("La letra {0} se repite {1} veces.", ocurr, cont);
                        break;
                    case 4:
                        Console.WriteLine("Introduce el primer string: ");
                        string string1 = Console.ReadLine();
                        Console.WriteLine("Introduce el segundo string: ");
                        string string2 = Console.ReadLine();
                        string stringF = string1 + " " + string2;
                        int repes;
                        do
                        {
                            Console.WriteLine("¿Cuántas veces repetimos el string?");
                        } while (!Int32.TryParse(Console.ReadLine(), out repes));
                        for (i = 0; i < repes; i++)
                        {
                            Console.WriteLine(stringF + " ");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Introduce una palabra o frase: ");
                        string frase = Console.ReadLine();
                        for (i = 0; i < frase.Length; i++)
                        {
                            Console.Write(frase[i]);
                            Console.Write(frase[i]);
                        }
                        break;
                    case 6:
                        cont = 0;
                        Console.WriteLine("Enter a string");
                        string chain1 = Console.ReadLine();
                        Console.WriteLine("Enter another string");
                        string chain2 = Console.ReadLine();
                        string aux_ch1 = "";//for overwrite the ch1
                        string aux_ch2 = "";//for overwrite the ch2
                        j = 0;//for run the chain2
                        for (i = 0; i < chain1.Length && chain2.Length != j; i++)
                        {
                            if (chain1[i] == chain2[j])
                            {
                                j++;
                                aux_ch2 += chain1[i];
                            }
                            else
                            {
                                aux_ch1 += chain1[i];
                            }
                            if (aux_ch2 == chain2)
                            {

                                cont++;
                                j = 0;//returns to 0 to start the loop again
                                aux_ch2 = "";// we have to safe the new aux again in order to restart the comprobation 
                            }
                        }
                        Console.WriteLine(aux_ch1);
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