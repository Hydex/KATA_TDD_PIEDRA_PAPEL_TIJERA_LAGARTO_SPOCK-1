namespace Piedra_Papel_Tijera_Lagarto_Spock.Clases
{
    public class Juego : IJuego
    {
        public enum Elemento { Piedra, Papel, Tijera, Lagarto, Spock };

        public static string Empate = "EMPATE";
        public static string GanaJugador1 = "GANA JUGADOR 1";
        public static string GanaJugador2 = "GANA JUGADOR 2";

        public string ObtenerResultado(Elemento jugador1, Elemento jugador2) {
            var resultado = string.Empty;
          if (!jugador1.Equals(jugador2))
          {
            switch (jugador1)
            {
              case Elemento.Piedra:
                resultado = (jugador2 == Elemento.Lagarto || jugador2 == Elemento.Tijera)
                              ? GanaJugador1
                              : GanaJugador2;
                break;
              case Elemento.Papel:
                resultado = (jugador2 == Elemento.Piedra || jugador2 == Elemento.Spock)
                              ? GanaJugador1
                              : GanaJugador2;
                break;
              case Elemento.Tijera:
                resultado = (jugador2 == Elemento.Papel || jugador2 == Elemento.Lagarto)
                              ? GanaJugador1
                              : GanaJugador2;
                break;
              case Elemento.Lagarto:
                resultado = (jugador2 == Elemento.Spock || jugador2 == Elemento.Papel)
                              ? GanaJugador1
                              : GanaJugador2;
                break;
              case Elemento.Spock:
                resultado = (jugador2 == Elemento.Tijera || jugador2 == Elemento.Piedra)
                              ? GanaJugador1
                              : GanaJugador2;
                break;
            }
          }
          else
            resultado = Empate;
          return resultado;
        }
    }
}
