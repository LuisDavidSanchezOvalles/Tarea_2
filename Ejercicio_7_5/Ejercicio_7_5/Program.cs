using System;
using System.Collections;

namespace Ejercicio_7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable AgendaHash = new Hashtable();
            int Cantidad;
            double Numero;
            string Nombre;
            String Entrada;

            try
            {
                Console.WriteLine("Ingrese la cantidad de Personas a guardar en la Agenda:");
                Entrada = Console.ReadLine();
                Cantidad = Convert.ToInt32(Entrada);
                for (int i = 0; i < Cantidad; i++)
                {
                    Console.Write("Nombre de la persona " + (i + 1) + ":");
                    Nombre = Console.ReadLine();
                    Console.Write("Numero de la persona " + (i + 1) + ":");
                    Numero = Convert.ToDouble(Console.ReadLine());
                    AgendaHash.Add(Numero, Nombre);
                }

                Console.WriteLine("\n\nLas personas y numeros guardados son:\n");
                foreach (DictionaryEntry Dato in AgendaHash)
                {
                    Console.WriteLine("{0}: {1}", Dato.Key, Dato.Value);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
