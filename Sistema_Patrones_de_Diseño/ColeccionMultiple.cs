namespace Practica1
{
    public class ColeccionMultiple : IColeccionable
    {
        private IColeccionable pila;
        private IColeccionable cola;
        private int matriculaMaxima;

        public ColeccionMultiple(IColeccionable p, IColeccionable c){

            pila = p;

            cola = c;

        }


        // Implementamos la interfaz IColeccionable.



        //El método agregar no hace nada.
        public void agregar(IComparable a)
        {
            throw new System.NotImplementedException();
        }

        public bool contiene(IComparable b)
        {
            if( pila.contiene(b) | cola.contiene(b)){

                return true;
            }

            else{

                return false;
            }
        }

        public int cuantos()
        {
            return (pila.cuantos() + cola.cuantos() );
        }

        public IComparable maximo()
        {
            if (pila.maximo().sosMayor(cola.maximo()) ){

                return pila.maximo();

            }

            else{

                return cola.maximo();
            }
        }

        public IComparable minimo()
        {
             if (pila.minimo().sosMenor(cola.minimo()) ){

                return pila.minimo();

            }

            else{

                return cola.minimo();
            }
        }

        //IMPLEMENTAMOS Iterable PROVISIONAL

        public Iterador_de_Coleccionables crearIterador(){
            return new Iterador_de_Pila((Pila)pila);
        }

        //IMPLEMENTAMOS IOrdenable PROVISIONAL

        public void setOrdenInicio(IOrdenEnAula1 orden){
            pila.setOrdenInicio(orden);
        }
        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden){
            pila.setOrdenLlegaAlumno(orden);
        }
        public void setOrdenAulaLlena(IOrdenEnAula1 orden){
            pila.setOrdenAulaLlena(orden);
        }
        public void SetMatriculaMaxima(int matricula){
            matriculaMaxima=matricula;
        }
    }
}