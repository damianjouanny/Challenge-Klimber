namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Define el contrato para todas las formas geométricas
    /// </summary>
    public interface IFormaGeometrica
    {
        /// <summary>
        /// Calcula el área de la forma geométrica
        /// </summary>
        /// <returns>El área de la forma</returns>
        decimal CalcularArea();

        /// <summary>
        /// Calcula el perímetro de la forma geométrica
        /// </summary>
        /// <returns>El perímetro de la forma</returns>
        decimal CalcularPerimetro();

        /// <summary>
        /// Obtiene el tipo de forma geométrica
        /// </summary>
        TipoForma TipoForma { get; }

        /// <summary>
        /// Obtiene el nombre de la forma en el idioma especificado
        /// </summary>
        /// <param name="esPlural">Indica si el nombre debe estar en plural</param>
        /// <param name="idioma">El idioma en el que se desea el nombre</param>
        /// <returns>El nombre de la forma en el idioma especificado</returns>
        string ObtenerNombre(bool esPlural, Idioma idioma);
    }
}