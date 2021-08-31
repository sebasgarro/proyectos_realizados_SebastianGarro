namespace Practica1
{
    public class Fabrica_de_AlumnoMuyEstudiosoTodoDecorado: Fabrica_de_AlumnoMuyEstudioso
    {
        public override IComparable crearAleatorio(){

            IAlumno alumnoDecorado = (Alumno)base.crearAleatorio();
            alumnoDecorado = new Decorado_Aprobacion(alumnoDecorado);
            alumnoDecorado = new Decorado_NotaEscrita(alumnoDecorado);
            alumnoDecorado = new Decorado_Legajo(alumnoDecorado);
            return new Decorado_Recuadro(alumnoDecorado);

        }

        public override IComparable crearPorTeclado(){

            IAlumno alumnoDecorado = (Alumno)base.crearPorTeclado();
            alumnoDecorado = new Decorado_Aprobacion(alumnoDecorado);
            alumnoDecorado = new Decorado_NotaEscrita(alumnoDecorado);
            alumnoDecorado = new Decorado_Legajo(alumnoDecorado);
            return new Decorado_Recuadro(alumnoDecorado);
        }
    }
}