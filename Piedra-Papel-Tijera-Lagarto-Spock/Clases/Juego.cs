namespace Piedra_Papel_Tijera_Lagarto_Spock.Clases
{
    public class Juego : Piedra_Papel_Tijera_Lagarto_Spock.Clases.IJuego
    {
        public enum Elemento { Piedra, Papel, Tijera, Lagarto, Spock };

        public static string EMPATE = "EMPATE";
        public static string GANA_JUGADOR_1 = "GANA JUGADOR 1";
        public static string GANA_JUGADOR_2 = "GANA JUGADOR 2";

        public string ObtenerResultado(Elemento jugador1, Elemento jugador2) {
            string resultado = string.Empty;
            if (jugador1.Equals(jugador2))
                resultado = EMPATE;
            else {
                switch (jugador1)
                {
                    case Elemento.Piedra:
                        resultado = (jugador2 == Elemento.Lagarto || jugador2 == Elemento.Tijera) ?
                            GANA_JUGADOR_1 : GANA_JUGADOR_2;
                        break;
                    case Elemento.Papel:
                        resultado = (jugador2 == Elemento.Piedra || jugador2 == Elemento.Spock) ?
                            GANA_JUGADOR_1 : GANA_JUGADOR_2;
                        break;
                    case Elemento.Tijera:
                        resultado = (jugador2 == Elemento.Papel || jugador2 == Elemento.Lagarto) ? 
                            GANA_JUGADOR_1 : GANA_JUGADOR_2;
                        break;
                    case Elemento.Lagarto:
                        resultado = (jugador2 == Elemento.Spock || jugador2 == Elemento.Papel) ? 
                            GANA_JUGADOR_1 : GANA_JUGADOR_2;
                        break;
                    case Elemento.Spock:
                        resultado = (jugador2 == Elemento.Tijera || jugador2 == Elemento.Piedra) ? 
                            GANA_JUGADOR_1 : GANA_JUGADOR_2;
                        break;
                }
            }
            return resultado;
        }
    }
}
