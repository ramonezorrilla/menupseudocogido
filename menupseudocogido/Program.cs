using System;

namespace menupseudocogido
{

    class Program
    {
        static void Main()
        {
            int opcion;
            double num1, num2, suma;
            string nombre, apellido;
            int inicio;

            bool continuar = true;

            do
            {
                Console.WriteLine("Selecciona una opción:");
                Console.WriteLine("1. Sumar dos números");
                Console.WriteLine("2. Capturar nombre y apellido");
                Console.WriteLine("3. Imprimir números pares a partir de un número");
                Console.WriteLine("4. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el primer número:");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el segundo número:");
                        num2 = double.Parse(Console.ReadLine());
                        suma = num1 + num2;
                        Console.WriteLine("La suma es: " + suma);
                        break;

                    case 2:
                        Console.WriteLine("Ingresa tu nombre:");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingresa tu apellido:");
                        apellido = Console.ReadLine();
                        Console.WriteLine("Nombre completo: " + nombre + " " + apellido);
                        break;

                    case 3:
                        Console.WriteLine("Ingresa un número para comenzar:");
                        inicio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Números pares a partir de " + inicio + ":");
                        for (int i = inicio; i <= inicio + 20; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.");
                        break;
                }

                // Preguntar al usuario si desea limpiar la pantalla
                if (continuar)
                {
                    Console.WriteLine("¿Deseas limpiar la pantalla? (s/n)");
                    char limpiar = char.Parse(Console.ReadLine().ToLower());
                    if (limpiar == 's')
                    {
                        Console.Clear(); // Comando para limpiar la pantalla
                    }
                }
            } while (continuar);
        }
    }
}