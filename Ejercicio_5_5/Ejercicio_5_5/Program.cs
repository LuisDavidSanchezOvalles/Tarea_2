using System;

namespace Ejercicio_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada;
            int Numero;

            try
            {
                Console.Write("Ingrese un Numero entero de un digito Positivo: ");
                Entrada = Console.ReadLine();
                Numero = Convert.ToInt32(Entrada);

                NumLetra(Numero);
            }
            catch (Exception)
            {
                Console.WriteLine("Error...");
            }
        }

        public static void NumLetra(int Num)
        {
            switch (Num)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;
                case 6:
                    Console.WriteLine("Seis");
                    break;
                case 7:
                    Console.WriteLine("Siete");
                    break;
                case 8:
                    Console.WriteLine("Ocho");
                    break;
                case 9:
                    Console.WriteLine("Nueve");
                    break;
                default:
                    Console.WriteLine("Solo se Permite de un digito Positivo");
                    break;
            }
        }
    }
}