namespace Practica1
{
    public class Comparar_Nombre : Estrategia_de_Comparacion
    {
       
       
        //PARA COMPARAR MAYOR QUE Y MENOR QUE USAMOS EL CRITERIO ALFABETICO DE LA PRIMERA LETRA DEL NOMBRE
        public bool sosIgual(IComparable a, IComparable b)
        {
            IAlumno a1 = (IAlumno)a;
            IAlumno a2 = (IAlumno)b;
            if(a1.GetNombre().ToUpper().Equals(a2.GetNombre().ToUpper())){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            IAlumno a1 = (IAlumno)a;
            IAlumno a2 = (IAlumno)b;
            if(a1.GetNombre().ToUpper()[0] > a2.GetNombre().ToUpper()[0]){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            IAlumno a1 = (IAlumno)a;
            IAlumno a2 = (IAlumno)b;
            if(a1.GetNombre().ToUpper()[0] < a2.GetNombre().ToUpper()[0]){
                return true;
            }else{
                return false;
            }
        }
    }
}