using System;
namespace Practica1
{
    public class LectorDeDatos: ManejadorDatos
    {
        public LectorDeDatos(ManejadorDatos s)
        :base(s){}

        public override int numeroPorTeclado(string indicador){
            Console.Write(indicador);
            int numero = ControlarExcepcion.ComprobarValorNumerico(Console.ReadLine());
            return numero;
        }

        public override string stringPorTeclado(string indicador){
            Console.Write(indicador);
            string cadena = Console.ReadLine();
            return cadena;
        }


    }
}