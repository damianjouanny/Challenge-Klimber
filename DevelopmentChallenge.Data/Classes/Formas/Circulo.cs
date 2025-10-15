using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    /// <summary>
    /// Representa un círculo
    /// </summary>
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _diametro;

        /// <summary>
        /// Constructor del círculo
        /// </summary>
        /// <param name="diametro">El diámetro del círculo</param>
        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public TipoForma TipoForma => TipoForma.Circulo;

        /// <summary>
        /// Calcula el área del círculo
        /// Fórmula: π * radio²
        /// </summary>
        /// <returns>El área del círculo</returns>
        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_diametro / 2) * (_diametro / 2);
        }

        /// <summary>
        /// Calcula el perímetro (circunferencia) del círculo
        /// Fórmula: π * diámetro
        /// </summary>
        /// <returns>El perímetro del círculo</returns>
        public decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }

        /// <summary>
        /// Obtiene el nombre del círculo en el idioma especificado
        /// </summary>
        /// <param name="esPlural">Indica si el nombre debe estar en plural</param>
        /// <param name="idioma">El idioma en el que se desea el nombre</param>
        /// <returns>El nombre del círculo en el idioma especificado</returns>
        public string ObtenerNombre(bool esPlural, Idioma idioma)
        {
            return RecursosHelper.ObtenerNombreForma(TipoForma.Circulo, esPlural, idioma);
        }
    }
}