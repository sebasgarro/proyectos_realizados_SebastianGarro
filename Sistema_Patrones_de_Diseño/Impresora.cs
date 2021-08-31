using System;
namespace Practica1
{
    public class Impresora
    {
         public static void imprimirElementos(Iterable c){
            Iterador_de_Coleccionables iterador = c.crearIterador();
            
            while(! iterador.fin()){
                Console.WriteLine(iterador.actual().informar());
                iterador.siguiente();
            }
            
        }
    }
}