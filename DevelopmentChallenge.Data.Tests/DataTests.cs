using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idioma.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idioma.Ingles));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new FormaGeometrica(TipoForma.Cuadrado, 5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new FormaGeometrica(TipoForma.Cuadrado, 5),
                new FormaGeometrica(TipoForma.Cuadrado, 1),
                new FormaGeometrica(TipoForma.Cuadrado, 3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, Idioma.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(TipoForma.Cuadrado, 5),
                new FormaGeometrica(TipoForma.Circulo, 3),
                new FormaGeometrica(TipoForma.TrianguloEquilatero, 4),
                new FormaGeometrica(TipoForma.Cuadrado, 2),
                new FormaGeometrica(TipoForma.TrianguloEquilatero, 9),
                new FormaGeometrica(TipoForma.Circulo, 2.75m),
                new FormaGeometrica(TipoForma.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(TipoForma.Cuadrado, 5),
                new FormaGeometrica(TipoForma.Circulo, 3),
                new FormaGeometrica(TipoForma.TrianguloEquilatero, 4),
                new FormaGeometrica(TipoForma.Cuadrado, 2),
                new FormaGeometrica(TipoForma.TrianguloEquilatero, 9),
                new FormaGeometrica(TipoForma.Circulo, 2.75m),
                new FormaGeometrica(TipoForma.TrianguloEquilatero, 4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idioma.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        // Nuevos tests para funcionalidad agregada

        [TestCase]
        public void TestResumenListaVaciaEnItaliano()
        {
            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), Idioma.Italiano));
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var trapecios = new List<FormaGeometrica> { new FormaGeometrica(TipoForma.Trapecio, 5) };

            var resumen = FormaGeometrica.Imprimir(trapecios, Idioma.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 16 | Perimetro 16,25 <br/>TOTAL:<br/>1 formas Perimetro 16,25 Area 16", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(TipoForma.Cuadrado, 5),
                new FormaGeometrica(TipoForma.Circulo, 3),
                new FormaGeometrica(TipoForma.TrianguloEquilatero, 4),
                new FormaGeometrica(TipoForma.Trapecio, 3)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idioma.Italiano);

            Assert.AreEqual(
                "<h1>Rapporto di Forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>1 Cerchio | Area 7,07 | Perimetro 9,42 <br/>1 Triangolo | Area 6,93 | Perimetro 12 <br/>1 Trapezio | Area 5,76 | Perimetro 9,75 <br/>TOTALE:<br/>4 forme Perimetro 51,17 Area 44,76",
                resumen);
        }

        [TestCase]
        public void TestResumenConTrapecios()
        {
            var formas = new List<FormaGeometrica>
            {
                new FormaGeometrica(TipoForma.Trapecio, 4),
                new FormaGeometrica(TipoForma.Trapecio, 6),
                new FormaGeometrica(TipoForma.Cuadrado, 2)
            };

            var resumen = FormaGeometrica.Imprimir(formas, Idioma.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>1 Square | Area 4 | Perimeter 8 <br/>2 Trapezoids | Area 33,28 | Perimeter 32,49 <br/>TOTAL:<br/>3 shapes Perimeter 40,49 Area 37,28",
                resumen);
        }
    }
}
