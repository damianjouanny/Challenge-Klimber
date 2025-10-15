using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Test básico - lista vacía en castellano
                var resultadoVacio = FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idioma.Castellano);
                Console.WriteLine("Test 1 - Lista vacía en castellano:");
                Console.WriteLine(resultadoVacio);
                Console.WriteLine();

                // Test básico - lista vacía en inglés
                var resultadoVacioIngles = FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idioma.Ingles);
                Console.WriteLine("Test 2 - Lista vacía en inglés:");
                Console.WriteLine(resultadoVacioIngles);
                Console.WriteLine();

                // Test básico - lista vacía en italiano (nuevo)
                var resultadoVacioItaliano = FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idioma.Italiano);
                Console.WriteLine("Test 3 - Lista vacía en italiano:");
                Console.WriteLine(resultadoVacioItaliano);
                Console.WriteLine();

                // Test con formas
                var formas = new List<FormaGeometrica>
                {
                    new FormaGeometrica(TipoForma.Cuadrado, 5),
                    new FormaGeometrica(TipoForma.Circulo, 3),
                    new FormaGeometrica(TipoForma.TrianguloEquilatero, 4),
                    new FormaGeometrica(TipoForma.Trapecio, 4) // Nuevo trapecio
                };

                var resultadoFormasEsp = FormaGeometrica.Imprimir(formas, Idioma.Castellano);
                Console.WriteLine("Test 4 - Formas en español:");
                Console.WriteLine(resultadoFormasEsp);
                Console.WriteLine();

                var resultadoFormasEng = FormaGeometrica.Imprimir(formas, Idioma.Ingles);
                Console.WriteLine("Test 5 - Formas en inglés:");
                Console.WriteLine(resultadoFormasEng);
                Console.WriteLine();

                var resultadoFormasIta = FormaGeometrica.Imprimir(formas, Idioma.Italiano);
                Console.WriteLine("Test 6 - Formas en italiano:");
                Console.WriteLine(resultadoFormasIta);
                Console.WriteLine();

                Console.WriteLine("Todos los tests completados exitosamente!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
            }

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}