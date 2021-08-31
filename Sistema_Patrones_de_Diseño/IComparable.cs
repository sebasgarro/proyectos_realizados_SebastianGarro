namespace Practica1
{
    public interface IComparable
    {
         bool sosIgual(IComparable objeto);
         bool sosMenor(IComparable objeto);
         bool sosMayor(IComparable objeto);
         string informar();
         void setEstrategia(Estrategia_de_Comparacion estrategia);
    }
}