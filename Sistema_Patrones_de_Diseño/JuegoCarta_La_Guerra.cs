using System;
namespace Practica1
{
    public class JuegoCarta_La_Guerra: Juego_de_Cartas
    {
        public JuegoCarta_La_Guerra(Persona p1, Persona p2)
        :base(p1,p2){
            Console.WriteLine("Juego: La Guerra. \n"+ 
            "   Este juego de cartas consiste en 3 rondas, cada ronda tiene 5 turnos por jugador\n"+
            "   En cada turno la carta con mayor número gana. El que gana más turnos gana la ronda\n"+
            "   GANA la PARTIDA quien GANE 2 o 3 rondas en TOTAL.\n\n");
        }

        public override void RepartirCartas(){
            //Repartimos 5 cartas a cada jugador
            for(int cont=0;cont<5;cont++) {
                jugador1.tomarCarta((Carta)base.mazo.pop());
                jugador2.tomarCarta((Carta)base.mazo.pop());
            }
            Console.WriteLine("***Se repartieron las cartas para una Ronda***\n");
        }
        public override void JugarMano(){
            int puntaje_de_mano=0; //Cero empate, positivo gana jugador 2, negativo gana jugador 1
            for(int cont=0;cont<5;cont++){
                Carta c1 = jugador1.descartarCarta();
                Carta c2 = jugador2.descartarCarta();
                Console.WriteLine("Turno del Jugador 1: "+jugador1.GetNombre()+"\n**************\n"+c1.informar()+"\n**************\n");
                Console.WriteLine("Turno del Jugador 2: "+jugador2.GetNombre()+"\n**************\n"+c2.informar()+"\n**************\n");

                if(c1.sosMayor(c2)){
                    puntaje_de_mano--;
                    Console.WriteLine("|||JUGADOR 1 GANA LA MANO|||\n");
                }
                else if(c1.sosMenor(c2)){
                    puntaje_de_mano++;
                    Console.WriteLine("|||JUGADOR 2 GANA LA MANO|||\n");
                }
                else{
                    Console.WriteLine("|||SE EMPATÓ LA MANO|||\n");
                } 
            }
            if(puntaje_de_mano<0){
                base.conteo_ganador--;
                Console.WriteLine("!!**||JUGADOR 1 GANA UNA RONDA||**!!\n\n");
            }
            else if(puntaje_de_mano>0){
                base.conteo_ganador++;
                Console.WriteLine("!!**||JUGADOR 2 GANA UNA RONDA||**!!\n\n");
            }
            else{
                Console.WriteLine("!!**||SE EMPATA LA RONDA||**!!\n\n");
            }

            base.cantidad_rondas++;

        }
        public override bool ChequearGanador(){ //SI hay Ganador Devuelve true, sino false;
            if(base.cantidad_rondas==3){
                if(base.conteo_ganador<0){
                    base.ganador=jugador1;
                    Console.WriteLine("***//FIN DEL JUEGO//***");
                    Console.WriteLine("***//JUGADOR 1 GANA LA PARTIDA//***");
                    return true;
                }
                else if(base.conteo_ganador>0){
                    base.ganador=jugador2;
                    Console.WriteLine("***//FIN DEL JUEGO//***");
                    Console.WriteLine("***//JUGADOR 2 GANA LA PARTIDA//***");
                    return true;
                }
                else{
                    Console.WriteLine("***//FIN DEL JUEGO//***");
                    Console.WriteLine("***//LA PARTIDA TERMINA EN EMPATE//***");
                    return true;
                }
            }
            else{
                return false;
            }
        }
        
    }
}