namespace Practica1
{
    public interface Jugador
    {
        void prepararse(); //Para instanciar la Pila de Cartas
        void tomarCarta(Carta carta);
        Carta descartarCarta();
        int CuanasCartas();
    }
}