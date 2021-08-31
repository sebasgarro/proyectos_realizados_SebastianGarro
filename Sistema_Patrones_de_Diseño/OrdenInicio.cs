namespace Practica1
{
    public class OrdenInicio : IOrdenEnAula1
    {
        private Aula aula;

        public OrdenInicio(Aula a){
            aula  = a;
        }

        public void ejecutar(){
            aula.comenzar();
        }
    }
}