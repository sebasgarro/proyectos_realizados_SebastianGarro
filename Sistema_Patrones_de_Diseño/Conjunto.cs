using System.Collections.Generic;

namespace Practica1
{
    public class Conjunto : IColeccionable
    {
        private List <IComparable> coleccion;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena; 
        private int matriculaMaxima;

        public Conjunto(){
            coleccion = new List<IComparable>();
            matriculaMaxima=40;
        }
        public void agregar(IComparable elemento){  //EL METODO IMPLEMENTADO DE IColeccionable es el utilizado para agregar elementos en Conjunto.
            if(pertenece(elemento)){

            }else{
                if(coleccion.Count ==0){
                    coleccion.Add(elemento);
                    ordenInicio.ejecutar();
                    ordenLlegaAlumno.ejecutar(elemento);
                }
                else if(coleccion.Count == matriculaMaxima-1){
                    coleccion.Add(elemento);
                    ordenLlegaAlumno.ejecutar(elemento);
                    ordenAulaLlena.ejecutar();
                }else{
                    coleccion.Add(elemento);
                    ordenLlegaAlumno.ejecutar(elemento);
                }
            }
        }

        public void eliminar(IComparable elemento){
            int indice=0;
            foreach(IComparable elem in coleccion){
                if(elem.sosIgual(elemento)){
                    coleccion.RemoveAt(indice);
                }
                indice++;
            }
        }

        public bool pertenece(IComparable elemento){
            foreach(IComparable elem in coleccion){
                if(elem.sosIgual(elemento)){
                    return true;
                }
            }
            return false;
        }

        public List<IComparable> getElementos(){
            return coleccion;
        }


  //IMPLEMENTAMOS LA INTERFACE COLECCIONABLE
        public int cuantos()
        {
            return coleccion.Count;
        }

        public IComparable minimo()
        {
            //COMPARA EN BASE A LAS ClAVES
            IComparable min =coleccion[0];
            foreach(IComparable elem in coleccion){
                if(elem.sosMenor(min)){
                    min = elem;
                }
            }
            return min;

        }

        public IComparable maximo()
        {
            //COMPARA EN BASE A LAS ClAVES
            IComparable max =coleccion[0];
            foreach(IComparable elem in coleccion){
                if(elem.sosMayor(max)){
                    max = elem;
                }
            }
            return max;
        }

        public bool contiene(IComparable b)
        {    
            return pertenece(b);
        }

        //IMPLEMENTAMOS ITERABLE
        public Iterador_de_Coleccionables crearIterador(){
            return new Iterador_de_Conjunto(this);
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