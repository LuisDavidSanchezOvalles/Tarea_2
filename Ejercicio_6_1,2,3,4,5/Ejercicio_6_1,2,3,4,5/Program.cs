using System;

namespace Ejercicio_6_1_2_3_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArregloDeEstudianteJagged AJ = new ArregloDeEstudianteJagged();
            AJ.ComienzoDeEstudiantes();
        }

        public class ArregloDeEstudianteJagged
        {
            private double PromedioCalificaciones = 0.0;
            private int numSalones = 0, numEstudiantes = 0;
            private int Opcion;
            private string Entrada;

            public void ComienzoDeEstudiantes()
            {
                //Cantidad de Salones
                Console.Write("Ingrese la cantidad de Salones:");
                numSalones = Convert.ToInt32(Console.ReadLine());

                double[][] calificaciones = new double[numSalones][];

                //Cantidad de estudiantes por salon 
                for (int i = 0; i < numSalones; i++)
                {
                    Console.Write("\nIngrese la cantidad de Estudiantes para el Salon {0}:", i + 1);
                    numEstudiantes = Convert.ToInt32(Console.ReadLine());
                    calificaciones[i] = new double[numEstudiantes];
                }

                RellenarCalificaciones(calificaciones);

                Console.WriteLine("1. Ejercicio_6_1= Promedio");
                Console.WriteLine("2. Ejercicio_6_2= Mayor Calificacion");
                Console.WriteLine("3. Ejercicio_6_3= Menor Calificacion");
                Console.WriteLine("4. Ejercicio_6_5= Recibir Arreglo jagged");
                Console.Write("Opcion: ");

                try
                {
                    Entrada = Console.ReadLine();
                    Opcion = Convert.ToInt32(Entrada);
                }
                catch(Exception)
                {
                    Console.WriteLine("Error...");
                }

                switch (Opcion)
                {
                    case 1:
                        CalcularPromedio(calificaciones);
                        break;
                    case 2:
                        CalcularMayorCalificacion(calificaciones);
                        break;
                    case 3:
                        CalcularMenorCalificacion(calificaciones);
                        break;
                    case 4:
                        RecibirArregloJagged(calificaciones);
                        break;
                    default:
                        Console.WriteLine("No existe...");
                        Console.ReadKey();
                        break;
                }

            }
            private void RellenarCalificaciones(double[][] calificaciones)
            {
                //Calificacion a cada estudiante de su respectivo salon
                for (int x = 0; x < numSalones; x++)
                {
                    for (int y = 0; y < numEstudiantes; y++)
                    {
                        Console.Write("\nIngrese la calificacion del Estudiante " + (y + 1) + " del Salon " + (x + 1) + ":");
                        calificaciones[x][y] = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }

            private void CalcularPromedio(double[][] calificaciones)
            {
                double AcumPromedio = 0.0;
                int AcumEstudiantes = 0;

                for (int i = 0; i < calificaciones.Length; i++)
                {
                    AcumEstudiantes += calificaciones[i].GetLength(0);
                    for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        AcumPromedio += calificaciones[i][j];
                    }
                }

                PromedioCalificaciones = AcumPromedio / (calificaciones.Length * AcumEstudiantes);
                Console.WriteLine("El promedio de calificaciones es: {0}", Math.Round(PromedioCalificaciones, 2));
            }

            private void CalcularMayorCalificacion(double[][] calificaciones)
            {
                double maximo = 0.0;

                for (int i = 0; i < calificaciones.Length; i++)
                {
                    for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        if (calificaciones[i][j] > maximo)
                        {
                            maximo = calificaciones[i][j];
                        }
                    }
                }
                Console.WriteLine("La calificaciones mas alta es: {0}", maximo);
                Console.ReadKey();
            }

            private void CalcularMenorCalificacion(double[][] calificaciones)
            {
                double minimo = 100;

                for (int i = 0; i < calificaciones.Length; i++)
                {
                    for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        if (calificaciones[i][j] < minimo)
                        {
                            minimo = calificaciones[i][j];
                        }
                    }
                }
                Console.WriteLine("La calificaciones mas alta es: {0}", minimo);
            }

            private void RecibirArregloJagged(double[][] calificaciones)
            {
                for (int i = 0; i < calificaciones.Length; i++)
                {
                    for (int j = 0; j < calificaciones.GetLength(0); j++)
                    {
                        Console.WriteLine("La Calificacion del Estudiante {0} del salon {1} es: {2}", (j + 1), (i + 1), calificaciones[i][j]);
                    }
                }

                Console.WriteLine("\n\nEstas calificaciones fueron pasados a un metodo");
            }
        }
    }
}
