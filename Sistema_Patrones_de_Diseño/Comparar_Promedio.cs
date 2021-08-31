namespace Practica1
{
    public class Comparar_Promedio : Estrategia_de_Comparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            IAlumno a1 = (IAlumno)a;
            IAlumno a2 = (IAlumno)b;
            if(a1.GetPromedio()==a2.GetPromedio()){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            IAlumno a1 = (IAlumno)a;
            IAlumno a2 = (IAlumno)b;
            if(a1.GetPromedio()>a2.GetPromedio()){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            IAlumno a1 = (IAlumno)a;
            IAlumno a2 = (IAlumno)b;
            if(a1.GetPromedio()<a2.GetPromedio()){
                return true;
            }else{
                return false;
            }
        }
    }
}