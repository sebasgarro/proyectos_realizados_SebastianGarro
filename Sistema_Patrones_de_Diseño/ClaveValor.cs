
namespace Practica1
{
    public class ClaveValor: IComparable
    {
        private IComparable clave;
        private IComparable valor;

        public ClaveValor(IComparable c, IComparable v){
            clave = c;
            valor = v;
        }

        public IComparable getClave(){
            return clave;
        }

        public IComparable getValor(){
            return valor;
        }

        public void setClave(Numero c){
            clave = c;
        }

        public void setValor(IComparable v){
            valor = v;
        }

//IMPLEMENTACION DE INTERFAZ COMPARABLE

        public bool sosIgual(IComparable objeto){
            return objeto.sosIgual(clave);
        }

        public bool sosMenor(IComparable objeto){
            return objeto.sosMenor(valor);
        }

        public bool sosMayor(IComparable objeto){
            return objeto.sosMayor(valor);
        }

        public string informar(){
            return "ClaveValor\n   Clave: "+clave.informar()+"\n   Valor: "+valor.informar();
        }

        public void setEstrategia(Estrategia_de_Comparacion estrategia){

            valor.setEstrategia(estrategia);

        }
    }
}