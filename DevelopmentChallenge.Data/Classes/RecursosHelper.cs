using System.Globalization;
using DevelopmentChallenge.Data.Resources;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Helper class para manejar recursos con diferentes idiomas
    /// Usa directamente la clase Textos generada automáticamente por Visual Studio
    /// </summary>
    public static class RecursosHelper
    {
        /// <summary>
        /// Obtiene un texto desde los recursos en el idioma especificado
        /// </summary>
        /// <param name="clave">La clave del recurso a buscar</param>
        /// <param name="idioma">El idioma del texto solicitado</param>
        /// <returns>El texto localizado o la clave si no se encuentra</returns>
        public static string ObtenerTexto(string clave, Idioma idioma)
        {
            var cultura = ObtenerCultura(idioma);
            return Textos.ResourceManager.GetString(clave, cultura) ?? clave;
        }

        /// <summary>
        /// Obtiene el nombre de una forma geométrica en el idioma especificado
        /// </summary>
        /// <param name="tipoForma">El tipo de forma geométrica</param>
        /// <param name="esPlural">Indica si el nombre debe estar en plural</param>
        /// <param name="idioma">El idioma del nombre solicitado</param>
        /// <returns>El nombre de la forma en el idioma especificado</returns>
        public static string ObtenerNombreForma(TipoForma tipoForma, bool esPlural, Idioma idioma)
        {
            var sufijo = esPlural ? "Plural" : "Singular";
            var clave = $"{tipoForma}{sufijo}";
            return ObtenerTexto(clave, idioma);
        }

        /// <summary>
        /// Obtiene la cultura correspondiente al idioma especificado
        /// </summary>
        /// <param name="idioma">El idioma para el cual obtener la cultura</param>
        /// <returns>La cultura correspondiente al idioma</returns>
        private static CultureInfo ObtenerCultura(Idioma idioma)
        {
            switch (idioma)
            {
                case Idioma.Castellano:
                    return new CultureInfo("es");
                case Idioma.Ingles:
                    return new CultureInfo("en");
                case Idioma.Italiano:
                    return new CultureInfo("it");
                default:
                    return new CultureInfo("es");
            }
        }
    }
}