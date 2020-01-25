using System;
using System.Collections;

namespace Ejercicios_8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Arreglo = new ArrayList();
            string Cadena1, Cadena2;

            try
            {
                Console.Write("Ingrese una cadena:");
                Cadena1 = Console.ReadLine();
                Arreglo.Add(Cadena1);

                Console.Write("Ingrese la siguiente cadena:");
                Cadena2 = Console.ReadLine();
                Arreglo.Add(Cadena2);

                Console.WriteLine("Las Cadenas Ordenadas son:");
                Console.WriteLine("");

                Arreglo.Sort();

                foreach (String Cadena in Arreglo)
                {
                    Console.WriteLine("{0}", Cadena);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
