using System.Collections.Generic;
namespace Practica1
{
    public class AlumnoCompuesto : IAlumno
    {
        private List<IAlumno> alumnos_hijos;

        public AlumnoCompuesto()
        {
            alumnos_hijos = new List<IAlumno>();
        }

        public void agregarAlumno(IAlumno alumno){
            alumnos_hijos.Add(alumno);
        }

        public double GetCalificacion()
        {
            foreach(IAlumno alumno in alumnos_hijos){
                return alumno.GetCalificacion();
            }
            return 0;
        }

        public int GetDNI()
        {
            foreach(IAlumno alumno in alumnos_hijos){
                return alumno.GetDNI();
            }
            return 0;
        }

        public int GetLegajo()
        {
            foreach(IAlumno alumno in alumnos_hijos){
                return alumno.GetLegajo();
            }
            return 0;
        }

        public string GetNombre()
        {
                foreach(IAlumno alumno in alumnos_hijos){
                    return alumno.GetNombre();
                }
                return "No hay hijos en este compuesto";
        }

        public double GetPromedio()
        {
            foreach(IAlumno alumno in alumnos_hijos){
                return alumno.GetPromedio();
            }
            return 0;
        }

        public string informar()
        {
            foreach(IAlumno alumno in alumnos_hijos){
                return alumno.informar();
            }
            return "No tiene hijos";
        }

        public string mostrarCalificacion()
        {
            foreach(IAlumno alumno in alumnos_hijos){
                return alumno.mostrarCalificacion();
            }
            return "No tiene hijos";
        }

        public int responderPregunta(int pregunta)
        {
            List<int[]> respuestas = new List<int[]>();
            foreach(IAlumno alumno in alumnos_hijos){
                int respuestaActual = alumno.responderPregunta(pregunta);
                int[] respuesta_y_contador={respuestaActual,1};
                if(respuestas.Count==0){
                    respuestas.Add(respuesta_y_contador);
                }else{
                    bool noEstaba=true;
                    foreach(int[] respuesta in respuestas){
                        if(respuesta[0]==respuestaActual){
                            respuesta[1]++;
                            noEstaba=false;
                        }
                    }
                    if(noEstaba){
                        respuestas.Add(respuesta_y_contador);
                    }
                }
            }
            int[] masVotada=respuestas[0];
            foreach(int[] respuesta in respuestas){
                if(respuesta[1]>masVotada[1]){
                    masVotada =respuesta;
                }
            }
            return masVotada[0];

        }

        public void SetCalificacion(double c)
        {
            foreach(IAlumno alumno in alumnos_hijos){
                alumno.SetCalificacion(c);
            }
        }

        public void setEstrategia(Estrategia_de_Comparacion estrategia)
        {
            foreach(IAlumno alumno in alumnos_hijos){
                alumno.setEstrategia(estrategia);
            }
        
        }

        public bool sosIgual(IComparable objeto)
        {
            foreach(IAlumno alumno in alumnos_hijos){
                if(alumno.sosIgual(objeto)){
                    return true;
                }
            }

            return false;
        }

        public bool sosMayor(IComparable objeto)
        {
            foreach(IAlumno alumno in alumnos_hijos){
                if(objeto.sosMayor(alumno)){
                    return false;
                }
                if(objeto.sosIgual(alumno)){
                    return false;
                }
            }

            return true;
        }

        public bool sosMenor(IComparable objeto)
        {
            foreach(IAlumno alumno in alumnos_hijos){
                if(objeto.sosMenor(alumno)){
                    return false;
                }
                if(objeto.sosIgual(alumno)){
                    return false;
                }
            }

            return true;
        }
    }
}