namespace Practica1
{
    public class OrdenAulaLlena : IOrdenEnAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula a){
            aula = a;
        }

        public void ejecutar(){
            aula.claseLista();
        }
    }
}