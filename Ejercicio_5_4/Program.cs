using System;

namespace Ejercicio_5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada;
            int Num;

            try
            {
                Console.Write("Ingresa Un número al Cual se le aplicará el factorial: ");
                Entrada = Console.ReadLine();
                Num = Convert.ToInt32(Entrada);

                MostrarFactorial(Num);
            }
            catch(Exception)
            {
                Console.WriteLine("Error...");
            }
        }

        public static void MostrarFactorial(int Num)
        {
            double Result = 1;
            for (int i = 1; i <= Num; i++)
            {
                Result = Result * i;
            }

            Console.WriteLine("El factorial de {0} es: {1}",Num ,Math.Round(Result, 2));
        }
    }
}
