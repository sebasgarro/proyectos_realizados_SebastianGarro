namespace Practica1
{
    public abstract class ManejadorDeDatos
    {
        static ManejadorDatos m1 = new LectorDeDatos(null);
        static ManejadorDatos manejador = new GeneradorDeDatosAleatorios(m1);


        public static int numeroAleatorio(int min, int max){
            return manejador.numeroAleatorio(min,max);
        }

        public static string stringAleatorio(int cantidad){
            return manejador.stringAleatorio(cantidad);
        }

        public static string nombreAleatorio(){
            return manejador.nombreAleatorio();
        }

        public static int numeroPorTeclado(string indicador){
            return manejador.numeroPorTeclado(indicador);
        }

        public static string stringPorTeclado(string indicador){
            return manejador.stringPorTeclado(indicador);
        }
        
    }
}