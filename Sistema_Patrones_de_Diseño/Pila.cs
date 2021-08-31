using System;
using System.Collections.Generic;
namespace Practica1
{
    public class Pila : IColeccionable
    {
        private List<IComparable> pila;
        private IOrdenEnAula1 ordenInicio;
        private IOrdenEnAula2 ordenLlegaAlumno;
        private IOrdenEnAula1 ordenAulaLlena; 
        private int matriculaMaxima;

        public Pila(){

            pila = new List<IComparable>();
            matriculaMaxima=40;
        }


        public void push(IComparable compa){

            pila.Add(compa);
        }

        public IComparable pop(){

            
            IComparable objeto = pila[pila.Count-1];

            pila.RemoveAt(pila.Count-1);

            return objeto;
        }

        public IComparable pull(){

            return pila[pila.Count-1];

        }


        public bool IsEmpty(){

            if (pila.Count==0){

                return true;
            }

            else{

                return false;
            }
        }


        // Implementando infertace IColeccionable

        public int cuantos()
        {
            return pila.Count;
        }

        public IComparable minimo()
        {
            IComparable min = pila[0];

            foreach(IComparable elemento in pila){

                if(elemento.sosMenor(min)){

                    min = elemento;
                }
            }

            return min;
        }

        public IComparable maximo()
        {

           IComparable max = pila[0];

            foreach(IComparable elemento in pila){

                if(elemento.sosMayor(max)){

                    max = elemento;
                }
            }

            return max;
        }

        public void agregar(IComparable a)
        {
            if(a.GetType()==Type.GetType("Practica1.IAlumno")){

                if(pila.Count ==0){
                    pila.Add(a);
                    ordenInicio.ejecutar();
                    ordenLlegaAlumno.ejecutar(a);
                }
                else if(pila.Count == matriculaMaxima-1){
                    pila.Add(a);
                    ordenLlegaAlumno.ejecutar(a);
                    ordenAulaLlena.ejecutar();
                }
                else{
                    pila.Add(a);
                    ordenLlegaAlumno.ejecutar(a);

                }
            }
            else{
                pila.Add(a);
            }
        }

        public bool contiene(IComparable b)
        {
            foreach(IComparable elemento in pila){

                if(elemento.sosIgual(b)) {

                    return true;
                }
            }

            return false;
        }

        //IMPLEMENTAMOS Iterable

        public Iterador_de_Coleccionables crearIterador(){
            return new Iterador_de_Pila(this);
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