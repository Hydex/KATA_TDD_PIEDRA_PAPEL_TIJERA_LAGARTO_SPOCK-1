using NUnit.Framework;

namespace Test_Piedra_Papel_Tijera_Lagarto_Spock
{
    public class TestJuego
    {
        [TestFixture]
        public class TestMismosElementos
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera);
            }
            [Test]
            public void Empate()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Empate);
            }
        }

        [TestFixture]
        public class TestTijerasCortanPapel {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT = 
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup() {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel);
            }
            [Test]
            public void Gana_Tijera_A_Papel() {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador1);
            }
        }

        [TestFixture]
        public class TestPapelCubrePiedra
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra);
            }
            [Test]
            public void Gana_Papel_A_Piedra()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador1);
            }
        }

        [TestFixture]
        public class TestPiedraAplastaLagarto
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto);
            }
            [Test]
            public void Gana_Piedra_A_Lagarto()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador1);
            }
        }

        [TestFixture]
        public class TestLagartoEnvenenaSpock
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Lagarto_A_Spock()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador1);
            }
        }

        [TestFixture]
        public class TestSpockDestrozaTijeras
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Spock_A_Tijeras()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador2);
            }
        }

        [TestFixture]
        public class TestTijerasDecapitanLagarto
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto);
            }
            [Test]
            public void Gana_Tijeras_A_Lagarto()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador1);
            }
        }

        [TestFixture]
        public class TestLagartoComePapel
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto);
            }
            [Test]
            public void Gana_Lagarto_A_Papel()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador2);
            }
        }

        [TestFixture]
        public class TestPapelRefutaSpock
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Papel_A_Spock()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador1);
            }
        }

        [TestFixture]
        public class TestSpockVaporizaPiedra
        {
          readonly Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Spock_A_Piedra()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador2);
            }
        }

        [TestFixture]
        public class TestPiedraAplastaTijeras
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string _resultado;
            [SetUp]
            public void Setup()
            {
                _resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera);
            }
            [Test]
            public void Gana_Piedra_A_Tijera()
            {
                Assert.AreEqual(_resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GanaJugador1);
            }
        }
    }
}
