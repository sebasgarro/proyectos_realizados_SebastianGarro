namespace Practica1
{
    public class Comparar_NumeroCarta: Estrategia_de_Comparacion
    {
        public bool sosIgual(IComparable a, IComparable b){
            Numero n1 = ((Carta)a).GetNumero();
            Numero n2 = ((Carta)b).GetNumero();
            return n1.sosIgual(n2);
        }
        public bool sosMenor(IComparable a, IComparable b){
            Numero n1 = ((Carta)a).GetNumero();
            Numero n2 = ((Carta)b).GetNumero();
            return n1.sosMenor(n2);
        }
        public bool sosMayor(IComparable a, IComparable b){
            Numero n1 = ((Carta)a).GetNumero();
            Numero n2 = ((Carta)b).GetNumero();
            return n1.sosMayor(n2);
        }
        
    }
}