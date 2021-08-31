namespace Practica1
{
    public abstract class Fabrica_de_Comparables
    {
        
        public static IComparable crearAleatorio(string opcion){
            Fabrica_de_Comparables fabrica = null;

            if(opcion =="Numero"){
                fabrica = new Fabrica_de_Numero();
            }
            if(opcion =="Alumno"){
                fabrica = new Fabrica_de_Alumnos();
            }
            if(opcion =="AlumnoMuyEstudioso"){
                fabrica = new Fabrica_de_AlumnoMuyEstudioso();
            }
            if(opcion =="AlumnoTodoDecorado"){
                fabrica = new Fabrica_de_AlumnoTodoDecorado();
            }
            if(opcion =="AlumnoMuyEstudiosoTodoDecorado"){
                fabrica = new Fabrica_de_AlumnoMuyEstudiosoTodoDecorado();
            }
            if(opcion =="AlumnoProxy"){
                fabrica = new Fabrica_de_AlumnoProxy();
            }
            if(opcion =="AlumnoCompuesto"){
                fabrica = new Fabrica_de_AlumnoCompuesto();
            }
            if(opcion =="Vendedor"){
                fabrica = new Fabrica_de_Vendedores();
            }
            if(opcion =="Carta"){
                fabrica = new Fabrica_de_Cartas();
            }

            return fabrica.crearAleatorio();
        }

        public static IComparable crearPorTeclado(string opcion){
            Fabrica_de_Comparables fabrica = null;

            if(opcion =="Numero"){
                fabrica = new Fabrica_de_Numero();
            }
            if(opcion =="Alumno"){
                fabrica = new Fabrica_de_Alumnos();
            }
            if(opcion =="AlumnoMuyEstudioso"){
                fabrica = new Fabrica_de_AlumnoMuyEstudioso();
            }
            if(opcion =="AlumnoTodoDecorado"){
                fabrica = new Fabrica_de_AlumnoTodoDecorado();
            }
            if(opcion =="AlumnoMuyEstudiosoTodoDecorado"){
                fabrica = new Fabrica_de_AlumnoMuyEstudiosoTodoDecorado();
            }
            if(opcion =="AlumnoProxy"){
                fabrica = new Fabrica_de_AlumnoProxy();
            }
            if(opcion =="AlumnoCompuesto"){
                fabrica = new Fabrica_de_AlumnoCompuesto();
            }
            if(opcion =="Vendedor"){
                fabrica = new Fabrica_de_Vendedores();
            }
            if(opcion =="Carta"){
                fabrica = new Fabrica_de_Cartas();
            }

            return fabrica.crearPorTeclado();
        }
        public abstract IComparable crearAleatorio();
        public abstract IComparable crearPorTeclado();
        
    }
}