namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Enumera los tipos de formas geométricas disponibles
    /// </summary>
    public enum TipoForma
    {
        /// <summary>
        /// Cuadrado - polígono regular de 4 lados iguales
        /// </summary>
        Cuadrado = 1,

        /// <summary>
        /// Círculo - figura plana con todos los puntos equidistantes del centro
        /// </summary>
        Circulo = 2,

        /// <summary>
        /// Triángulo equilátero - triángulo con todos los lados iguales
        /// </summary>
        TrianguloEquilatero = 3,

        /// <summary>
        /// Trapecio - cuadrilátero con al menos dos lados paralelos
        /// </summary>
        Trapecio = 4
    }

    /// <summary>
    /// Enumera los idiomas disponibles para los reportes
    /// </summary>
    public enum Idioma
    {
        /// <summary>
        /// Idioma español (castellano)
        /// </summary>
        Castellano = 1,

        /// <summary>
        /// Idioma inglés
        /// </summary>
        Ingles = 2,

        /// <summary>
        /// Idioma italiano
        /// </summary>
        Italiano = 3
    }
}