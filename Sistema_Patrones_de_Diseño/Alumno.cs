using System;
namespace Practica1
{
    public class Alumno: Persona, IAlumno 
    {
        private int legajo;
        private double promedio;
        private double calificacion;
        private Estrategia_de_Comparacion estrategia;

        public Alumno(string n, int d, int l, double p)
            : base(n,d)
        {
            legajo = l;
            promedio= p;
            estrategia = new Comparar_Calificacion();

        }

        public new string GetNombre(){
            return base.GetNombre();
        }

        public int GetLegajo(){

            return legajo;
        }

        public double GetPromedio(){

            return promedio;
        }

        public double GetCalificacion(){
            return calificacion;
        }
        public void SetCalificacion(double c){
            calificacion=c;
        }


        public virtual int responderPregunta(int pregunta){
             return ManejadorDeDatos.numeroAleatorio(1,3);
             
        }
        public string mostrarCalificacion(){
            return this.GetNombre()+"     "+this.GetCalificacion();
        }


      //RE- implementamos los métodos de la interface Comparable

         public override bool sosIgual(IComparable objeto){
             return estrategia.sosIgual(this,objeto);
         }

         public override bool sosMenor(IComparable objeto){
             return estrategia.sosMenor(this,objeto);
         }

         public override bool sosMayor(IComparable objeto){
             return estrategia.sosMayor(this,objeto);
         }

         public override string informar(){

             return "Alumno \n"+"          Nombre: "+this.GetNombre()+"\n"+"          Promedio: "+promedio+"\n          Legajo: "+legajo+"\n          DNI: "+this.GetDNI();
         }

         public override void setEstrategia(Estrategia_de_Comparacion estrategia){
             this.estrategia = estrategia;
         }
    }
}