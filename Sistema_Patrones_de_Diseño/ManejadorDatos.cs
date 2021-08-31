namespace Practica1
{
    public abstract class ManejadorDatos
    {
        private ManejadorDatos sucesor;

        public ManejadorDatos(ManejadorDatos s){
            sucesor = s;
        }

        public virtual int numeroAleatorio(int min, int max){
            if(sucesor!=null){
                return sucesor.numeroAleatorio(min,max);
            }
            return 0;
        }

        public virtual string stringAleatorio(int cantidad){
            if(sucesor!=null){
                return sucesor.stringAleatorio(cantidad);
            }
            return "";
            
        }

        public virtual string nombreAleatorio(){
            if(sucesor!=null){
                return sucesor.nombreAleatorio();
            }
            return "";
        }

        public virtual int numeroPorTeclado(string indicador){
            if(sucesor!=null){
                return sucesor.numeroPorTeclado(indicador);
            }
            return 0;
        }

        public virtual string stringPorTeclado(string indicador){
            if(sucesor!=null){
                return sucesor.stringPorTeclado(indicador);
            }
            return "";
        }
        
    }
}