using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    /// <summary>
    /// Representa un triángulo equilátero (todos los lados iguales)
    /// </summary>
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _lado;

        /// <summary>
        /// Constructor del triángulo equilátero
        /// </summary>
        /// <param name="lado">La longitud del lado del triángulo</param>
        /// <exception cref="ArgumentException">Se lanza cuando el lado es menor o igual a cero</exception>
        public TrianguloEquilatero(decimal lado)
        {
            if (lado <= 0)
                throw new ArgumentException("El lado debe ser mayor que cero", nameof(lado));
            
            _lado = lado;
        }

        public TipoForma TipoForma => TipoForma.TrianguloEquilatero;

        /// <summary>
        /// Calcula el área del triángulo equilátero
        /// Fórmula: (√3 / 4) * lado²
        /// </summary>
        /// <returns>El área del triángulo</returns>
        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        /// <summary>
        /// Calcula el perímetro del triángulo equilátero
        /// Fórmula: lado * 3
        /// </summary>
        /// <returns>El perímetro del triángulo</returns>
        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }

        /// <summary>
        /// Obtiene el nombre del triángulo en el idioma especificado
        /// </summary>
        /// <param name="esPlural">Indica si el nombre debe estar en plural</param>
        /// <param name="idioma">El idioma en el que se desea el nombre</param>
        /// <returns>El nombre del triángulo en el idioma especificado</returns>
        public string ObtenerNombre(bool esPlural, Idioma idioma)
        {
            return RecursosHelper.ObtenerNombreForma(TipoForma.TrianguloEquilatero, esPlural, idioma);
        }
    }
}