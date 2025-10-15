/*
 * COMPLETADO: 
 *  Refactorizado la clase para respetar principios de la programación orientada a objetos.
 *  Implementado la forma Trapecio usando Factory Pattern.
 *  Agregado el idioma Italiano al reporte usando archivos .resx.
 *  Implementado polimorfismo, principios de SOLID, y Factory Pattern.
 *  Modernizado para usar enums type-safe (TipoForma e Idioma).
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Clase que representa una forma geométrica y genera reportes HTML
    /// Implementa el patrón Wrapper/Adapter para delegar operaciones a IFormaGeometrica
    /// </summary>
    public class FormaGeometrica
    {
        private readonly IFormaGeometrica _formaInterna;

        /// <summary>
        /// Obtiene el tipo de forma geométrica
        /// </summary>
        public TipoForma Tipo { get; }

        /// <summary>
        /// Constructor que crea una forma geométrica usando el patrón Factory
        /// </summary>
        /// <param name="tipo">El tipo de forma geométrica</param>
        /// <param name="parametro">El parámetro dimensional de la forma</param>
        public FormaGeometrica(TipoForma tipo, decimal parametro)
        {
            Tipo = tipo;
            _formaInterna = FormaGeometricaFactory.CrearForma(tipo, parametro);
        }

        /// <summary>
        /// Genera el reporte de formas geométricas en formato HTML
        /// </summary>
        /// <param name="formas">Lista de formas geométricas a incluir en el reporte</param>
        /// <param name="idioma">El idioma del reporte</param>
        /// <returns>Reporte HTML con el resumen de las formas</returns>
        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var formasInternas = formas.Select(f => f._formaInterna).ToList();
            return GenerarReporte(formasInternas, idioma);
        }

        /// <summary>
        /// Genera el reporte HTML con las formas geométricas
        /// </summary>
        /// <param name="formas">Lista de formas geométricas a reportar</param>
        /// <param name="idioma">El idioma del reporte</param>
        /// <returns>Cadena HTML con el reporte formateado</returns>
        private static string GenerarReporte(List<IFormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append($"<h1>{RecursosHelper.ObtenerTexto("EmptyListMessage", idioma)}</h1>");
                return sb.ToString();
            }

            sb.Append($"<h1>{RecursosHelper.ObtenerTexto("ReportHeader", idioma)}</h1>");

            var gruposFormas = formas
                .GroupBy(f => f.TipoForma)
                .OrderBy(g => (int)g.Key);

            foreach (var grupo in gruposFormas)
            {
                var cantidad = grupo.Count();
                var areaTotal = grupo.Sum(f => f.CalcularArea());
                var perimetroTotal = grupo.Sum(f => f.CalcularPerimetro());
                
                var formaEjemplo = grupo.First();
                sb.Append(GenerarLineaForma(cantidad, areaTotal, perimetroTotal, formaEjemplo, idioma));
            }

            sb.Append($"{RecursosHelper.ObtenerTexto("Total", idioma)}<br/>");
            
            var totalFormas = formas.Count;
            var perimetroGlobal = formas.Sum(f => f.CalcularPerimetro());
            var areaGlobal = formas.Sum(f => f.CalcularArea());
            
            sb.Append($"{totalFormas} {RecursosHelper.ObtenerTexto("Formas", idioma)} ");
            sb.Append($"{RecursosHelper.ObtenerTexto("Perimetro", idioma)} {perimetroGlobal:#.##} ");
            sb.Append($"{RecursosHelper.ObtenerTexto("Area", idioma)} {areaGlobal:#.##}");

            return sb.ToString();
        }

        /// <summary>
        /// Genera una línea del reporte para un grupo de formas del mismo tipo
        /// </summary>
        /// <param name="cantidad">La cantidad de formas de este tipo</param>
        /// <param name="area">El área total de las formas</param>
        /// <param name="perimetro">El perímetro total de las formas</param>
        /// <param name="formaEjemplo">Una instancia de ejemplo para obtener el nombre</param>
        /// <param name="idioma">El idioma para el reporte</param>
        /// <returns>Cadena HTML con la línea formateada</returns>
        private static string GenerarLineaForma(int cantidad, decimal area, decimal perimetro, IFormaGeometrica formaEjemplo, Idioma idioma)
        {
            if (cantidad <= 0) return string.Empty;

            var nombreForma = formaEjemplo.ObtenerNombre(cantidad > 1, idioma);
            var textoArea = RecursosHelper.ObtenerTexto("Area", idioma);
            var textoPerimetro = RecursosHelper.ObtenerTexto("Perimetro", idioma);
            
            return $"{cantidad} {nombreForma} | {textoArea} {area:#.##} | {textoPerimetro} {perimetro:#.##} <br/>";
        }

        #region Métodos de cálculo
        
        /// <summary>
        /// Calcula el área de la forma geométrica
        /// </summary>
        /// <returns>El área de la forma</returns>
        public decimal CalcularArea()
        {
            return _formaInterna.CalcularArea();
        }

        /// <summary>
        /// Calcula el perímetro de la forma geométrica
        /// </summary>
        /// <returns>El perímetro de la forma</returns>
        public decimal CalcularPerimetro()
        {
            return _formaInterna.CalcularPerimetro();
        }

        #endregion
    }
}
