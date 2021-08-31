using System;
namespace Practica1
{
    public class JuegoCartas_Recoleccion: Juego_de_Cartas
    {
        private Pila cartasEnLaMesa;
        private int puntosJugador1;
        private int puntosJugador2;

        public JuegoCartas_Recoleccion(Persona p1, Persona p2)
        :base(p1,p2){
            cartasEnLaMesa = new Pila();
            puntosJugador1=0;
            puntosJugador2=0;
            Console.WriteLine("Juego de Carta: Recoleccion. \n"+ 
            "   Este juego de cartas consiste en colocar 20 cartas en la MESA\n"+
            "   En cada RONDA el JUGADOR 1 toma las que son del palo ORO y BASTO\n"+
            "   Mientras que el JUGADOR 2 toma las que son de palo ESPADA y COPA.\n"+
            "   El que tiene más cartas en la mano gana la RONDA, y se le suma un punto\n"+
            "   Si tienen la misma cantidad es empate y nadie suma puntos.\n"+
            "   El primero en llegar a los 10 PUNTOS GANA LA PARTIDA.");
        }

        public override void RepartirCartas(){
                Console.WriteLine("***Colocando Cartas En La Mesa***\n");
                for(int cont=0;cont<20;cont++){
                    Carta carta=(Carta)mazo.pop();
                    Console.WriteLine(carta.informar());
                    cartasEnLaMesa.push(carta);
                    
                }
                Console.WriteLine("***Se Termino de Colocar las Cartas***\n");
        
        }
        public override void JugarMano(){
            //SI EL PALO ES BASTO U ORO LA TOMA EL JUGADOR 1. SI ES ESPADA O COPA LA TOMA EL JUGADOR 2
            Console.WriteLine("\n***LOS JUGADORES ESTÁN TOMANDO LAS CARTAS CORRESPONDIENTES...***\n");
            while(!cartasEnLaMesa.IsEmpty()){
                Carta carta=(Carta)cartasEnLaMesa.pop();
                if(carta.GetPalo()=="Oro" || carta.GetPalo()=="Basto"){
                    jugador1.tomarCarta(carta);
                    base.conteo_ganador--;
                }
                else{
                    jugador2.tomarCarta(carta);
                    base.conteo_ganador++;
                }
            }
            if(base.conteo_ganador<0){
                puntosJugador1++;
                Console.WriteLine("****PUNTO PARA EL JUGADOR 1****");
                Console.WriteLine("Puntos: "+puntosJugador1);
            }
            else if(base.conteo_ganador>0){
                puntosJugador2++;
                Console.WriteLine("****PUNTO PARA EL JUGADOR 2****");
                Console.WriteLine("Puntos: "+puntosJugador2);
            }
            else{
                Console.WriteLine("***SE EMPATÓ LA RONDA****");
            }

            //SE DEVUELVEN LAS CARTAS AL MAZO
            while(jugador1.CuanasCartas()!=0){
                mazo.push(jugador1.descartarCarta());
            }
            while(jugador2.CuanasCartas()!=0){
                mazo.push(jugador2.descartarCarta());
            }

            base.cantidad_rondas++;

            Console.WriteLine("***TERMINÓ LA RONDA NUMERO "+base.cantidad_rondas+"\n\n");

        }
        public override bool ChequearGanador(){ //SI hay Ganador Devuelve true, sino false;
            if(puntosJugador1==10){
                ganador=jugador1;
                Console.WriteLine("****GANA EL JUGADOR 1****");
                return true;
            }
            else if(puntosJugador2==10){
                ganador=jugador2;
                Console.WriteLine("****GANA EL JUGADOR 2****");
                return true;
            }
            else{
                return false;
            }
        }
        
    }
}