namespace Practica1
{
    public class Iterador_de_Cola : Iterador_de_Coleccionables
    {
        private Cola cola;
        private Cola cola_recuperadora;

        public Iterador_de_Cola(Cola c){
            cola = c;
            cola_recuperadora = new Cola();
        }

        public void primero(){
            //VUELVE A LLENAR LA COLA EN EL ORDEN QUE ESTABA INICIALMENTE, PERO LAS MOFIFICACIONES HECHAS A SUS ELEMENTOS SE MANTIENEN
            for(int i=cola_recuperadora.cuantos();i>0;i--){
                    cola.encolar(cola_recuperadora.desencolar());
                }

        }
        public void siguiente(){
            cola_recuperadora.encolar(cola.desencolar());
        }
        public bool fin(){
            if(cola.IsEmpty()){
                //UNA VEZ ITERADA TODA LA COLA; LA RECUEPERAMOS
                for(int i=cola_recuperadora.cuantos();i>0;i--){
                    cola.encolar(cola_recuperadora.desencolar());
                }
                return true;
            }
            else{
                return false;
            }
        }

        public IComparable actual(){
            return cola.pull();
        }
        
    }
}