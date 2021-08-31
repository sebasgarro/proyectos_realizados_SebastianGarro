using System;
namespace Practica1
{
    public class AlumnoProxy : IAlumno
    {
        private string nombre;
        private int dni;
        private int legajo;
        private double promedio;
        private double calificacion;
        private Estrategia_de_Comparacion estrategia;
        private IAlumno alumno;

        public AlumnoProxy(string n, int d, int l, double p ){
            nombre = n;
            dni = d;
            legajo = l;
            promedio = p;
            calificacion=0;
            estrategia = new Comparar_DNI();
        }
        public string GetNombre(){
            return nombre;
        }

        public int GetDNI(){
            return dni;
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
            calificacion = c;
        }
        public int responderPregunta(int pregunta){
            if(alumno == null){
                Console.WriteLine("ºººº INSTANCIANDO ALUMNO REAL ºººº");
                alumno = new Alumno(nombre,dni,legajo,promedio);
            }
            return alumno.responderPregunta(pregunta);
        }
        public string mostrarCalificacion(){
            return this.GetNombre()+"     "+this.GetCalificacion();
        }
        public bool sosIgual(IComparable objeto){
            return estrategia.sosIgual(this,objeto);
        }
        public bool sosMenor(IComparable objeto){
            return estrategia.sosMenor(this,objeto);
        }
        public bool sosMayor(IComparable objeto){
            return estrategia.sosMayor(this,objeto);
        }
        public string informar(){
            return "Alumno \n"+"          Nombre: "+nombre+"\n"+"          Promedio: "+promedio+"\n          Legajo: "+legajo+"\n          DNI: "+dni;
        }
        public void setEstrategia(Estrategia_de_Comparacion estrategia){
            this.estrategia = estrategia;
        }
    }
}