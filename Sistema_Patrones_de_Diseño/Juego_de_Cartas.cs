using System;
namespace Practica1
{
    public abstract class Juego_de_Cartas
    {
        protected Persona jugador1;
        protected Persona jugador2;
        protected Persona ganador;
        protected int conteo_ganador;
        protected int cantidad_rondas;
        protected Pila mazo;
        private Pila mezcladora1;
        private Pila mezcladora2;
        public Juego_de_Cartas(Persona p1, Persona p2){
            jugador1 = p1;
            jugador2 = p2;
            conteo_ganador=0;
            cantidad_rondas=0;
            mazo = new Pila();
            Program.llenarColeccionable(mazo,"Carta"); //llena 20 cartas
            Program.llenarColeccionable(mazo,"Carta");
            Console.WriteLine("!!!!SACANDO EL MAZO DE LA CAJA, VERIFICANDO CARTAS...!!!!");
            Impresora.imprimirElementos(mazo);
            Console.WriteLine("!!!!CARTAS VERIFICADAS CORRECTAMENTE!!!!");
        }
        public void MezclarMazo(){
            int veces = ManejadorDeDatos.numeroAleatorio(1,7);
            mezcladora1=new Pila();
            mezcladora2=new Pila();
            int cartasEnMazo = mazo.cuantos();
            //Mezclamos una cantidad de veces random, de 1 a 5.
            for(int mezclaActual=0; mezclaActual<veces;mezclaActual++){
                //Repartimos la mitad de las cartas en 1 mezclador y la otra mitad en otro
                for(int cont=0;cont<cartasEnMazo;cont++){
                    if(cont<(cartasEnMazo/2)){
                        mezcladora1.push(mazo.pop());
                    }
                    else{
                        mezcladora2.push(mazo.pop());
                    }
                }
                //Devolvemos las cartas al maso alternando entre los mezcladores
                while(!mezcladora1.IsEmpty()){
                    mazo.push(mezcladora1.pop());
                    mazo.push(mezcladora2.pop());
                }
            }   
        }

        public Persona ComenzarPartida(){
            jugador1.prepararse(); //Instancia la Pila de cartas en Persona;
            jugador2.prepararse();
            MezclarMazo();
            while(!ChequearGanador()){
                RepartirCartas();
                JugarMano();
                MezclarMazo();
            }
            return ganador;
            
        }

        public abstract void RepartirCartas();
        public abstract void JugarMano(); //tomar y descar cartas
        public abstract bool ChequearGanador(); 
        
    }
}