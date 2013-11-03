using NUnit.Framework;

namespace Test_Piedra_Papel_Tijera_Lagarto_Spock
{
    public class TestJuego
    {
        [TestFixture]
        public class Test_Mismos_Elementos
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera);
            }
            [Test]
            public void Empate()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.EMPATE);
            }
        }

        [TestFixture]
        public class Test_Tijeras_Cortan_Papel {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT = 
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup() {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel);
            }
            [Test]
            public void Gana_Tijera_A_Papel() {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_1);
            }
        }

        [TestFixture]
        public class Test_Papel_Cubre_Piedra
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra);
            }
            [Test]
            public void Gana_Papel_A_Piedra()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_1);
            }
        }

        [TestFixture]
        public class Test_Piedra_Aplasta_Lagarto
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto);
            }
            [Test]
            public void Gana_Piedra_A_Lagarto()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_1);
            }
        }

        [TestFixture]
        public class Test_Lagarto_Envenena_Spock
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Lagarto_A_Spock()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_1);
            }
        }

        [TestFixture]
        public class Test_Spock_Destroza_Tijeras
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Spock_A_Tijeras()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_2);
            }
        }

        [TestFixture]
        public class Test_Tijeras_Decapitan_Lagarto
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto);
            }
            [Test]
            public void Gana_Tijeras_A_Lagarto()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_1);
            }
        }

        [TestFixture]
        public class Test_Lagarto_Come_Papel
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Lagarto);
            }
            [Test]
            public void Gana_Lagarto_A_Papel()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_2);
            }
        }

        [TestFixture]
        public class Test_Papel_Refuta_Spock
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Papel,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Papel_A_Spock()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_1);
            }
        }

        [TestFixture]
        public class Test_Spock_Vaporiza_Piedra
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Spock);
            }
            [Test]
            public void Gana_Spock_A_Piedra()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_2);
            }
        }

        [TestFixture]
        public class Test_Piedra_Aplasta_Tijeras
        {
            Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego SUT =
                new Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego();

            private string resultado;
            [SetUp]
            public void Setup()
            {
                resultado = SUT.ObtenerResultado
                    (Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Piedra,
                    Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.Elemento.Tijera);
            }
            [Test]
            public void Gana_Piedra_A_Tijera()
            {
                Assert.AreEqual(resultado, Piedra_Papel_Tijera_Lagarto_Spock.Clases.Juego.GANA_JUGADOR_1);
            }
        }
    }
}
