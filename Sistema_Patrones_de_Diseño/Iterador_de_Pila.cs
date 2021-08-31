namespace Practica1
{
    public class Iterador_de_Pila : Iterador_de_Coleccionables
    {
        private Pila pila;
        private Pila pila_recuperadora;

        public Iterador_de_Pila(Pila p){
            pila = p;
            pila_recuperadora = new Pila();
        }

        public void primero(){
            //VUELVE A LLENAR LA PILA EN EL ORDEN QUE ESTABA INICIALMENTE, PERO LAS MOFIFICACIONES HECHAS A SUS ELEMENTOS SE MANTIENEN
            for(int i=pila_recuperadora.cuantos();i>0;i--){
                    pila.push(pila_recuperadora.pop());
                }

        }

        public void siguiente(){
            pila_recuperadora.push(pila.pop());
        }

        public IComparable actual(){
            return pila.pull();
        }

        public bool fin(){
            if(pila.IsEmpty()){
                //UNA VEZ ITERADA TODA LA PILA; LA RECUEPERAMOS
                for(int i=pila_recuperadora.cuantos();i>0;i--){
                    pila.push(pila_recuperadora.pop());
                }
                return true;
            }
            else{
                return false;
            }
        }
    }
}