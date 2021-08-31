using System;
namespace Practica1
{
    public class Aula
    {
        private Teacher teacher;
        private Student student;

        public void comenzar(){
            Console.WriteLine("!!!!!Creando un Teacher!!!!!");
            teacher = new Teacher();
        }

        public void nuevoAlumno(IComparable alumno){
            //Si usamos Diccionario el IComparable es un ClaveValor, y queremos solo el Valor
            if(alumno.GetType() == Type.GetType("Practica1.ClaveValor")){
                alumno = ((ClaveValor)alumno).getValor();
            }
            //CREARMOS UN ADAPTADOR PORQUE LOS MÉTODOS DE Teacher son para Students
            student = new StudentAdapter((IAlumno)alumno);
            teacher.goToClass(student);
        }

        public void claseLista(){
            teacher.teachingAClass();
        }
    }
}