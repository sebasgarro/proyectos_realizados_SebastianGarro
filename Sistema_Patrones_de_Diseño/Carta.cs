namespace Practica1
{
    public class Carta:IComparable
    {
        private Numero numero;
        private string palo;
        private Estrategia_de_Comparacion estrategia;

        public Carta(Numero n,string p){
            numero = n;
            palo =p;
            estrategia = new Comparar_NumeroCarta();
        }

        public Numero GetNumero(){
            return numero;
        }
        public string GetPalo(){
            return palo;
        }

        public bool sosIgual(IComparable objeto){
            return estrategia.sosIgual(this,objeto);
        }
        public bool sosMenor(IComparable objeto){
            return estrategia.sosMenor(this,objeto);
        }
        public bool sosMayor(IComparable objeto){
            return estrategia.sosMayor(this,objeto);
        }
        public string informar(){
            return "Carta: "+numero.informar()+"\nPalo: "+palo;
        }
        public void setEstrategia(Estrategia_de_Comparacion estrategia){
            this.estrategia = estrategia;
        }

    }
}