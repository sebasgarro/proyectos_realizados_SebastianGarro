using System;
namespace Practica1
{
    public class GeneradorDeDatosAleatorios: ManejadorDatos
    {
        private static string[] nombres = new string[]{"Natalia","Guillermina","Pamela","Agustin","Luciano","Diego","Solange","Gladys","Gisela","Enrique","Marcela", "David","Pablo", "Jimena","Maria","Ramon","Joaquin","Romina","Sonia","Claudia","Sebastian","Monica","Luna","Vanesa","Tobias"};
        private static Random valor_random = new Random();

        public GeneradorDeDatosAleatorios(ManejadorDatos s)
        :base(s){}

        public override int numeroAleatorio(int min, int max){

            return valor_random.Next(min,max+1);

        }

        public override string stringAleatorio(int cantidad){
            string cadena="";
            for(int cont=0;cont<cantidad;cont++){
                cadena=cadena+(char)valor_random.Next(97,123);
            }
            return cadena;
        }

        public override string nombreAleatorio(){
            
            return nombres[valor_random.Next(0,25)];
        }
    }
}