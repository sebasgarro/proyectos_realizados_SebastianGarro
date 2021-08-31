namespace Practica1
{
    public class Iterador_de_Diccionario: Iterador_de_Coleccionables
    {
        private Diccionario dic;
        private int cont;

        public Iterador_de_Diccionario(Diccionario d){
            dic = d;
            cont =0;
        }

        public void primero(){
            cont=0;
        }

        public void siguiente(){
            cont++;
        }

        public IComparable actual(){
            return dic.getDiccionario()[cont];
        }

        public bool fin(){
            return dic.cuantos()==(cont);
        }
    }
}