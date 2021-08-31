namespace Practica1
{
    public abstract class AdicionalDecorador : IAlumno
    {

        protected IAlumno adicional;

        public AdicionalDecorador(IAlumno ad){
            adicional = ad;
        }

        public virtual string mostrarCalificacion(){
            return adicional.mostrarCalificacion();
        }

        public string GetNombre(){

            return adicional.GetNombre();
        }

        public int GetDNI(){
            return adicional.GetDNI();
        }

        public int GetLegajo(){
            return adicional.GetLegajo();
        }
        public double GetPromedio(){
            return adicional.GetPromedio();
        }
        public double GetCalificacion(){
            return adicional.GetCalificacion();
        }
        public void SetCalificacion(double c){
            adicional.SetCalificacion(c);
        }
        public int responderPregunta(int pregunta){
            return adicional.responderPregunta(pregunta);
        }

        //IComparable

        public bool sosIgual(IComparable objeto){
            return adicional.sosIgual(objeto);
        }

        public bool sosMayor(IComparable objeto){
            return adicional.sosMayor(objeto);
        }

        public bool sosMenor(IComparable objeto){
            return adicional.sosMenor(objeto);
        }

        public string informar(){
            return adicional.informar();
        }

        public void setEstrategia(Estrategia_de_Comparacion estrategia){
            adicional.setEstrategia(estrategia);
        }

        

        
        
    }
}