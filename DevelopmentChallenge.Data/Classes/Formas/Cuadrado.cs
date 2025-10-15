using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    /// <summary>
    /// Representa un cuadrado (todos los lados iguales y ángulos de 90°)
    /// </summary>
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;

        /// <summary>
        /// Constructor del cuadrado
        /// </summary>
        /// <param name="lado">La longitud del lado del cuadrado</param>
        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public TipoForma TipoForma => TipoForma.Cuadrado;

        /// <summary>
        /// Calcula el área del cuadrado
        /// Fórmula: lado²
        /// </summary>
        /// <returns>El área del cuadrado</returns>
        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        /// <summary>
        /// Calcula el perímetro del cuadrado
        /// Fórmula: lado * 4
        /// </summary>
        /// <returns>El perímetro del cuadrado</returns>
        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        /// <summary>
        /// Obtiene el nombre del cuadrado en el idioma especificado
        /// </summary>
        /// <param name="esPlural">Indica si el nombre debe estar en plural</param>
        /// <param name="idioma">El idioma en el que se desea el nombre</param>
        /// <returns>El nombre del cuadrado en el idioma especificado</returns>
        public string ObtenerNombre(bool esPlural, Idioma idioma)
        {
            return RecursosHelper.ObtenerNombreForma(TipoForma.Cuadrado, esPlural, idioma);
        }
    }
}