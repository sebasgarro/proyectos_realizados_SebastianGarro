using System.Collections.Generic;

namespace Practica1
{
    public class Diccionario: IColeccionable
    {
        private Conjunto conjunto;

        public Diccionario(){
            conjunto = new Conjunto();
        }
        public void Agregar(IComparable clave, IComparable valor){
            ClaveValor elemento = new ClaveValor(clave,valor);
            bool reemplazado=false;
            foreach(ClaveValor elem in conjunto.getElementos()){
                //El sosIgual() de ClaveValor compara las Claves
                if(elem.sosIgual(elemento)){
                    elem.setValor(elemento.getValor());
                    reemplazado = true;
                }
            }
            if(! reemplazado){
                conjunto.agregar(elemento);
            }

        }

         public IComparable valorDe(IComparable clave){
            foreach(ClaveValor elem in conjunto.getElementos()){
                if(elem.sosIgual(clave)){
                    return elem.getValor();
                }
            }

            return null;
        }

        public List<IComparable> getDiccionario(){
            return conjunto.getElementos();
        }

    //IMPLEMENTAMOS INTERFAZ IColeccionable
        public void agregar(IComparable a)
        {   //NOS ASEGURAMOS DE QUE LA CLAVE GENERICA NO SE REPITA
            Numero clave_generica = new Numero(1);
            while(valorDe(clave_generica)!=null){
                clave_generica.incrementar();
            }
            Agregar(clave_generica, a);
        }

        public bool contiene(IComparable b)
        {
            return conjunto.contiene(b);
        }

        public int cuantos()
        {
            return conjunto.cuantos();
        }

        public IComparable maximo()
        {
            return conjunto.maximo();
        }

        public IComparable minimo()
        {
            return conjunto.minimo();
        }

        //IMPLEMENTAMOS ITERABLE

        public Iterador_de_Coleccionables crearIterador(){
            return new Iterador_de_Diccionario(this);
        }

        //IMPLEMENTAMOS IOrdenable

        public void setOrdenInicio(IOrdenEnAula1 orden){
            conjunto.setOrdenInicio(orden);
        }
        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden){
            conjunto.setOrdenLlegaAlumno(orden);
        }
        public void setOrdenAulaLlena(IOrdenEnAula1 orden){
            conjunto.setOrdenAulaLlena(orden);
        }

        public void SetMatriculaMaxima(int matricula){
            conjunto.SetMatriculaMaxima(matricula);
        }

       
    }
}