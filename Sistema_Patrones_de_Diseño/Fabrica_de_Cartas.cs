using System;
namespace Practica1
{
    public class Fabrica_de_Cartas: Fabrica_de_Comparables
    {
        private static int contador =1;
        private static string[] palos={"Basto","Oro","Copa","Espada"};
        private static int indice=0;
        public override IComparable crearAleatorio(){
            Numero numero_carta= new Numero(contador);
            Carta carta= new Carta(numero_carta, palos[indice]);
            indice++;
            contador++;
            if(contador==41){
                contador=1;
            }
            if(indice==4){
                indice=0;
            }
            return carta;

        }

        public override IComparable crearPorTeclado(){     
            Console.WriteLine("Ingrese el numero de la carta: ");
            Numero numero_carta = new Numero(ControlarExcepcion.ComprobarValorNumerico(Console.ReadLine()));
            Console.WriteLine("Ingrese el palo de la carta: ");
            return new Carta(numero_carta,Console.ReadLine());
        }
        
    }
}