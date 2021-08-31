namespace Practica1
{
    public class Iterador_de_Conjunto : Iterador_de_Coleccionables
    {
        private Conjunto conjunto;
        private int cont;

        public Iterador_de_Conjunto(Conjunto c){
            conjunto = c;
            cont =0;
        }

        public void primero(){
            cont=0;
        }

        public void siguiente(){
            cont++;
        }

        public bool fin(){
            return conjunto.cuantos()==cont;
        }

        public IComparable actual(){
            return conjunto.getElementos()[cont];
        }


    }
}