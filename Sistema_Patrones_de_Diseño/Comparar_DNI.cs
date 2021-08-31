namespace Practica1
{
    public class Comparar_DNI : Estrategia_de_Comparacion
    {
        public bool sosIgual(IComparable a, IComparable b)
        {
            IAlumno p1 = (IAlumno)a;
            IAlumno p2 = (IAlumno)b;
            if(p1.GetDNI()==p2.GetDNI()){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            IAlumno p1 = (IAlumno)a;
            IAlumno p2 = (IAlumno)b;
            if(p1.GetDNI()>p2.GetDNI()){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            IAlumno p1 = (IAlumno)a;
            IAlumno p2 = (IAlumno)b;
            if(p1.GetDNI()<p2.GetDNI()){
                return true;
            }else{
                return false;
            }
        }
    }
}