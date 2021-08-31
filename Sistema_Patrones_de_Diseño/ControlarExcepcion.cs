using System;
namespace Practica1
{
    public class ControlarExcepcion
    {
        
        public static int ComprobarValorNumerico(string valor){
            //Funcion para comprobar que los valores no superan a int32
            //Comprobar que no se ingresan letras
            //Manejo de Excepcion
            while(true){
            try{

                int v = int.Parse(valor);
                Console.WriteLine("Se proceso el valor correctamente");

                return v;

            
            }

            catch{

                Console.WriteLine("Algo anduvo mal...\nSolo se permiten valores numericos de no más de 9 digitos \n"+"Por favor, intentelo nuevamente");
                valor = Console.ReadLine();
            }

            }

            
        }
    }
}