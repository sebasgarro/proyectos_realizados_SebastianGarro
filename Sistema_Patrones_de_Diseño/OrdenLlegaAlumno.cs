namespace Practica1
{
    public class OrdenLlegaAlumno : IOrdenEnAula2
    {
        
        private Aula aula;

        public OrdenLlegaAlumno(Aula a){
            aula =  a;
        }

        public void ejecutar(IComparable comparable){
            aula.nuevoAlumno(comparable);
        }
    }
}