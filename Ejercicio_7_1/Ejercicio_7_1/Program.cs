using System;
using System.Collections;

namespace Ejercicio_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int salida = 0, cont = 0;
            float calificacion, maxima = 0.0f, minima = 100.0f, promedio = 0.0f;

            ArrayList Calificaciones = new ArrayList();

            try
            {
                while (salida != -2) //toma de calificaciones
                {
                    Console.Write("\nIngrese la Calificacion {0}:", cont + 1, ":");
                    calificacion = Convert.ToSingle(Console.ReadLine());

                    Calificaciones.Add(calificacion);

                    if (calificacion > maxima)
                        maxima = calificacion;
                    if (calificacion < minima)
                        minima = calificacion;
                    Console.Write("Para terminar el programa ingrese -2 para continuar cualquier otro: ");
                    salida = Convert.ToInt32(Console.ReadLine());
                    cont++;
                    Console.WriteLine("");
                }
                
                foreach (float dato in Calificaciones)//suma de las calificaciones almacenadas
                {
                    promedio += dato;
                }

                Console.WriteLine("El promedio de calificaciones es: {0}", (Math.Round(promedio / Calificaciones.Count, 2)));
                Console.WriteLine("La calificacion mas alta es: {0}", maxima);
                Console.WriteLine("La calificacion mas baja es: {0}", minima);
            }
            catch (Exception)
            {
                Console.WriteLine("Error...");
            }
        }
    }
}
