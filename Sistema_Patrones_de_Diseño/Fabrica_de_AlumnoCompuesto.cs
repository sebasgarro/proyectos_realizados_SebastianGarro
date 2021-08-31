namespace Practica1
{
    public class Fabrica_de_AlumnoCompuesto: Fabrica_de_Comparables
    {
        public override IComparable crearAleatorio(){
            AlumnoCompuesto alumnoCompuesto =new AlumnoCompuesto();
            for(int x=0;x<5;x++){
                 IAlumno alumno = (IAlumno)Fabrica_de_Comparables.crearAleatorio("AlumnoProxy");
                 alumnoCompuesto.agregarAlumno(alumno);
            }
            return alumnoCompuesto;
        }

        public override IComparable crearPorTeclado()
        {
            AlumnoCompuesto alumnoCompuesto =new AlumnoCompuesto();
            for(int x=0;x<5;x++){
                 IAlumno alumno = (IAlumno)Fabrica_de_Comparables.crearPorTeclado("AlumnoProxy");
                 alumnoCompuesto.agregarAlumno(alumno);
            }
            return alumnoCompuesto;
        }

        
    }
}