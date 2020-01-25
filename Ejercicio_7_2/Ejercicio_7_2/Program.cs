using System;
using System.Collections;

namespace Ejercicio_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada;
            Hashtable Tabla = new Hashtable();
            int Cantidad;
            string Clave, Definicion;

            try
            {
                Console.WriteLine("Ingrese la cantidad de palabras que Desea guardar  Con su definicion");
                Entrada = Console.ReadLine();
                Cantidad = Convert.ToInt32(Entrada);

                for (int i = 0; i < Cantidad; i++)
                {
                    Console.Write("Ingrese la palabra " + (i + 1) + ":");
                    Clave = Console.ReadLine();
                    Console.Write("Ingrese la definicion de la palabra " + (i + 1) + ":");
                    Definicion = Console.ReadLine();
                    Tabla.Add(Clave, Definicion);
                }

                Console.WriteLine("Las palabras guardadas en Tabla Hash son:\n\n");

                foreach (DictionaryEntry Dato in Tabla)
                {
                    Console.WriteLine("{0} : {1}", Dato.Key, Dato.Value);
                }
            }
            catch (Exception)
            { 
                Console.WriteLine("Error...");
            }
        }
    }
}
