namespace Practica1
{
    public class Comparar_Bonus : Estrategia_de_Comparacion
    {
         public bool sosIgual(IComparable a, IComparable b)
        {
            Vendedor p1 = (Vendedor)a;
            Vendedor p2 = (Vendedor)b;
            if(p1.GetBonus()==p2.GetBonus()){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMayor(IComparable a, IComparable b)
        {
            Vendedor p1 = (Vendedor)a;
            Vendedor p2 = (Vendedor)b;
            if(p1.GetBonus()>p2.GetBonus()){
                return true;
            }else{
                return false;
            }
        }

        public bool sosMenor(IComparable a, IComparable b)
        {
            Vendedor p1 = (Vendedor)a;
            Vendedor p2 = (Vendedor)b;
            if(p1.GetBonus()<p2.GetBonus()){
                return true;
            }else{
                return false;
            }
        }
    }
}