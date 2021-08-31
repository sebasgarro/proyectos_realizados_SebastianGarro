using System.Collections.Generic;
namespace Practica1
{
    public class Cola : IColeccionable
    {
        private List <IComparable> cola;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena; 
        private int matriculaMaxima;


        public Cola(){

            cola = new List<IComparable>();
            matriculaMaxima=40;
        }


        public void encolar(IComparable compa){

            cola.Add(compa);
        }

        public IComparable desencolar(){

            
            IComparable objeto = cola[0];

            cola.RemoveAt(0);

            return objeto;
        }

        public IComparable pull(){

            return cola[0];

        }


        public bool IsEmpty(){

            if (cola.Count==0){

                return true;
            }

            else{

                return false;
            }
        }


        // Implementando infertace IColeccionable

        public int cuantos()
        {
            return cola.Count;
        }

        public IComparable minimo()
        {
            IComparable min = cola[0];

            foreach(IComparable elemento in cola){

                if(elemento.sosMenor(min)){

                    min = elemento;
                }
            }

            return min;
        }

        public IComparable maximo()
        {

           IComparable max = cola[0];

            foreach(IComparable elemento in cola){

                if(elemento.sosMayor(max)){

                    max = elemento;
                }
            }

            return max;
        }

        public void agregar(IComparable elemento)
        {
            if(cola.Count ==0){
                cola.Add(elemento);
                ordenInicio.ejecutar();
                ordenLlegaAlumno.ejecutar(elemento);
            }
            else if(cola.Count == matriculaMaxima-1){
                cola.Add(elemento);
                ordenLlegaAlumno.ejecutar(elemento);
                ordenAulaLlena.ejecutar();
            }
            else{
                cola.Add(elemento);
                ordenLlegaAlumno.ejecutar(elemento);

            }
        }

        public bool contiene(IComparable b)
        {
            foreach(IComparable elemento in cola){

                if(elemento.sosIgual(b)) {

                    return true;
                }
            }

            return false;
        }

        //IMPLEMENTAMOS ITERABLE

        public Iterador_de_Coleccionables crearIterador(){
            return new Iterador_de_Cola(this);
        }

        //IMPLEMENTAMOS IOrdenable

        public void setOrdenInicio(IOrdenEnAula1 orden){
            ordenInicio = orden;
        }
        public void setOrdenLlegaAlumno(IOrdenEnAula2 orden){
            ordenLlegaAlumno = orden;
        }
        public void setOrdenAulaLlena(IOrdenEnAula1 orden){
            ordenAulaLlena = orden;
        }

        public void SetMatriculaMaxima(int matricula){
            matriculaMaxima=matricula;
        }


    }
}