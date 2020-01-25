using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Aplicada1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capitulo5");
            public static int Ejercicio4(int n)
            {
                if (n < 2) return n;
                return (n * Ejercicio4(n - 1));

            }
            Console.WriteLine("Ejericio5");
            public static String Ejercicio5(int numero)

            {
                switch (numero)
                {
                    case 0:
                        return "cero";
                    case 1:
                        return "uno";
                    case 2:
                        return "dos";
                    case 3:
                        return "tres";
                    case 4:
                        return "cuatro";
                    case 5:
                        return "cinco";
                    case 6:
                        return "seis";
                    case 7:
                        return "siete";
                    case 8:
                        return "ocho";
                    case 9:
                        return "nueve";
                    default:
                        return "Numero incorrecto";
                }
            }
            Console.WriteLine("Capitulo6");
            public static void Ejercicio1()
            {
                int nalumnos = 0, nsalon = 0;
                float acum = 0.0f;
                float promedio = 0.0f;

                Console.Write("Salones: ");
                nsalon = Convert.ToInt32(Console.ReadLine());

                float[][] calificaciones = new float[nsalon][];

                for (int i = 0; i < nsalon; i++)
                {
                    Console.Write("Alumnos en Curso: " + (i + 1));

                    nalumnos = Convert.ToInt32(Console.ReadLine());

                    calificaciones[i] = new float[nalumnos];
                }

                for (int i = 0; i < nsalon; i++)
                {
                    Console.WriteLine("Salon: " + (i + 1));
                    for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        Console.Write("Estudiante  " + (1 + j));
                        calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                    }

                }

                for (int i = 0; i < nsalon; i++)
                {
                    for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        acum += (float)calificaciones[i][j];

                    }
                }
                promedio = acum / (nalumnos * nsalon);
                Console.WriteLine("El promedio es:" + promedio);
            }

            Console.WriteLine("Ejercicio2");

            public static void Ejercicio2()
            {
                int nalumnos = 0, ncursos = 0, i = 0, j = 0;
                float minima = 100.0f;

                Console.Write("Cantidad Cursos: ");

                ncursos = Convert.ToInt32(Console.ReadLine());

                float[][] calificaciones = new float[ncursos][];

                for (i = 0; i < ncursos; i++)
                {
                    Console.Write("Salon " + (i + 1) + " Cantidad estudiantes: ");
                    nalumnos = Convert.ToInt32(Console.ReadLine());
                    calificaciones[i] = new float[nalumnos];
                }

                for (i = 0; i < ncursos; i++)
                {
                    Console.WriteLine("Aula: " + (i + 1));
                    for (j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        Console.Write("Nota: ");
                        calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                    }

                }

                for (i = 0; i < ncursos; i++)
                {
                    for (j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        if (calificaciones[i][j] < minima)
                        {
                            minima = calificaciones[i][j];
                        }
                    }
                }
                Console.WriteLine("Nota Minima: " + minima);
            }
            Console.WriteLine("Ejercicio3");

            public static void Ejercicio3()
            {
                int nalumnos = 0, ncursos = 0, i = 0, j = 0;
                float maxima = 0;
                Console.Write("Cantidad Cursos: ");
                ncursos = Convert.ToInt32(Console.ReadLine());
                float[][] calificaciones = new float[ncursos][];
                for (i = 0; i < ncursos; i++)
                {
                    Console.Write("Salon " + (i + 1) + " Cantidad estudiantes: ");
                    nalumnos = Convert.ToInt32(Console.ReadLine());
                    calificaciones[i] = new float[nalumnos];
                }

                for (i = 0; i < ncursos; i++)
                {
                    Console.WriteLine("Aula: " + (i + 1));
                    for (j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        Console.Write("Nota: ");
                        calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                    }

                }

                for (i = 0; i < ncursos; i++)
                {
                    for (j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        if (calificaciones[i][j] > maxima)
                        {
                            maxima = calificaciones[i][j];
                        }
                    }
                }
                Console.WriteLine("Nota Maxima: " + maxima);
            }

            Console.WriteLine("Ejercicio4");
            public static void Ejercicio4()
            {
                int nalumnos = 0, nsalon = 0;
                float acum = 0.0f;
                float promedio = 0.0f;
                Console.Write("Cantidad Aulas:  ");
                nsalon = Convert.ToInt32(Console.ReadLine());

                float[][] calificaciones = new float[nsalon][];

                for (int i = 0; i < nsalon; i++)
                {
                    Console.Write("Estudiantes para aula: " + (i + 1));

                    nalumnos = Convert.ToInt32(Console.ReadLine());

                    calificaciones[i] = new float[nalumnos];
                }

                for (int i = 0; i < nsalon; i++)
                {
                    Console.WriteLine("Para el aula:  " + (i + 1));
                    for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        Console.Write("Nota estudiante: " + (1 + j));
                        calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                    }

                }

                for (int i = 0; i < nsalon; i++)
                {
                    for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                    {
                        acum += calificaciones[i][j];

                    }
                }
                promedio = acum / (nalumnos * nsalon);
                Console.WriteLine("Promedio es: " + promedio);
            }
            Console.WriteLine("Ejercicio5");
            public static void Ejercicio5(int[][] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.GetLength(0); j++)
                    {
                        Console.WriteLine("{0}", a[i][j]);
                    }
                }
            }
            Console.WriteLine("Capitulo7");
            public static void Ejercicio2()
            {
                Hashtable dic = new Hashtable();
                Console.WriteLine("Cantidad de conceptos a agregar:");
                int j = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < j; i++)
                {
                    Console.WriteLine("Palabra: ");
                    String palabra = Console.ReadLine();
                    Console.WriteLine("Significado: ");
                    String definicion = Console.ReadLine();
                    dic.Add(palabra, definicion);
                }
                foreach (DictionaryEntry d in dic)
                {
                    Console.WriteLine("{0}: {1}", d.Key, d.Value);
                }
            }
            Console.WriteLine("Ejercicio5");

            public static void Ejercicio5()
            {
                Hashtable contactos = new Hashtable();
                Console.WriteLine("Cantidad Contactos: ");
                int j = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < j; i++)
                {
                    Console.WriteLine("Nombre: ");
                    String nombre = Console.ReadLine();
                    Console.WriteLine("Numero telefonico: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    contactos.Add(nombre, numero);
                }
                foreach (DictionaryEntry d in contactos)
                {
                    Console.WriteLine("{0}: {1}", d.Key, d.Value);
                }
            }
            Console.WriteLine("Capitulo8");
            public static void Ejercicio3()
            {
                Console.WriteLine(DateTime.Now.ToString("hh:mm tt yyyy/dd/MM"));
        }   }          








