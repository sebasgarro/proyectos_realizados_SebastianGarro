using System;
namespace Practica1
{
    public class Fabrica_de_Numero: Fabrica_de_Comparables
    {
        public override IComparable crearAleatorio(){
            Random valor = new Random();
            return new Numero(valor.Next());
        }

        public override IComparable crearPorTeclado(){
            Console.Write("::::CREANDO NUMERO POR TECLADO::::\nIngrese el valor: ");
            int valor = ControlarExcepcion.ComprobarValorNumerico(Console.ReadLine());
            return new Numero(valor);
        }
    }
}