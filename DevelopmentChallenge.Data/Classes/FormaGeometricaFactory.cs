using System;
using DevelopmentChallenge.Data.Classes.Formas;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Factory para crear instancias de formas geométricas
    /// Implementa el patrón Factory Method
    /// </summary>
    public static class FormaGeometricaFactory
    {
        /// <summary>
        /// Crea una instancia de forma geométrica según el tipo especificado
        /// </summary>
        /// <param name="tipo">El tipo de forma a crear</param>
        /// <param name="parametro">El parámetro dimensional de la forma (lado, diámetro, etc.)</param>
        /// <returns>Una instancia de la forma geométrica solicitada</returns>
        /// <exception cref="ArgumentOutOfRangeException">Se lanza cuando el tipo de forma no es soportado</exception>
        public static IFormaGeometrica CrearForma(TipoForma tipo, decimal parametro)
        {
            switch (tipo)
            {
                case TipoForma.Cuadrado:
                    return new Cuadrado(parametro);
                case TipoForma.Circulo:
                    return new Circulo(parametro);
                case TipoForma.TrianguloEquilatero:
                    return new TrianguloEquilatero(parametro);
                case TipoForma.Trapecio:
                    return new Trapecio(parametro);
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, "Tipo de forma no soportado");
            }
        }
    }
}