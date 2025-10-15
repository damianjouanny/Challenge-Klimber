using System;

namespace DevelopmentChallenge.Data.Classes.Formas
{
    /// <summary>
    /// Representa un trapecio isósceles
    /// </summary>
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _ladoIzquierdo;
        private readonly decimal _ladoDerecho;

        /// <summary>
        /// Constructor que crea un trapecio isósceles proporcional basado en un lado
        /// </summary>
        /// <param name="lado">La longitud de la base mayor del trapecio</param>
        public Trapecio(decimal lado)
        {
            _baseMayor = lado;
            _baseMenor = lado * 0.6m;
            _altura = lado * 0.8m;            
            var diferenciaBases = (_baseMayor - _baseMenor) / 2;
            var ladoOblicuo = (decimal)Math.Sqrt((double)(diferenciaBases * diferenciaBases + _altura * _altura));
            _ladoIzquierdo = _ladoDerecho = ladoOblicuo;
        }

        /// <summary>
        /// Constructor que crea un trapecio con dimensiones específicas
        /// </summary>
        /// <param name="baseMayor">La longitud de la base mayor</param>
        /// <param name="baseMenor">La longitud de la base menor</param>
        /// <param name="altura">La altura del trapecio</param>
        /// <param name="ladoIzquierdo">La longitud del lado izquierdo</param>
        /// <param name="ladoDerecho">La longitud del lado derecho</param>
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoIzquierdo, decimal ladoDerecho)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            _ladoIzquierdo = ladoIzquierdo;
            _ladoDerecho = ladoDerecho;
        }

        public TipoForma TipoForma => TipoForma.Trapecio;

        /// <summary>
        /// Calcula el área del trapecio
        /// Fórmula: ((base mayor + base menor) * altura) / 2
        /// </summary>
        /// <returns>El área del trapecio</returns>
        public decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) * _altura) / 2;
        }

        /// <summary>
        /// Calcula el perímetro del trapecio
        /// Fórmula: base mayor + base menor + lado izquierdo + lado derecho
        /// </summary>
        /// <returns>El perímetro del trapecio</returns>
        public decimal CalcularPerimetro()
        {
            return _baseMayor + _baseMenor + _ladoIzquierdo + _ladoDerecho;
        }

        /// <summary>
        /// Obtiene el nombre del trapecio en el idioma especificado
        /// </summary>
        /// <param name="esPlural">Indica si el nombre debe estar en plural</param>
        /// <param name="idioma">El idioma en el que se desea el nombre</param>
        /// <returns>El nombre del trapecio en el idioma especificado</returns>
        public string ObtenerNombre(bool esPlural, Idioma idioma)
        {
            return RecursosHelper.ObtenerNombreForma(TipoForma.Trapecio, esPlural, idioma);
        }
    }
}