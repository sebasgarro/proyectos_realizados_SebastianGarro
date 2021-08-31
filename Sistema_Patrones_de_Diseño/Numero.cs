namespace Practica1
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int v){

            valor= v;
        }


        public int getValor(){

            return valor;

        }
        public void setValor(int v){
            valor = v;
        }

        public void incrementar(){
            //INCREMENTA EN 1 EL VALOR DEL NUMERO
            valor++;
        }

        // Implementamos la interfaz IComparable

        public bool sosIgual(IComparable objeto)
        {
            Numero numero = (Numero) objeto;

            if(numero.getValor() == valor){

                return true;
            }

            else{

                return false;
            }
        }

        public bool sosMayor(IComparable objeto)
        {
            Numero numero = (Numero) objeto;

            if(numero.getValor() < valor){

                return true;
            }

            else{

                return false;
            }
        }

        public bool sosMenor(IComparable objeto)
        {
            Numero numero = (Numero) objeto;

            if(numero.getValor() > valor){

                return true;
            }

            else{

                return false;
            }
        }

        public string informar(){

            return "Numero "+valor;
        }

        public void setEstrategia(Estrategia_de_Comparacion estrategia){

        }
    }
}