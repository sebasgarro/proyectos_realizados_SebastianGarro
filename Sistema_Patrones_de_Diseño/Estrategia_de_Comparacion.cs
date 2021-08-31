namespace Practica1
{
    public interface Estrategia_de_Comparacion
    {
         bool sosIgual(IComparable a, IComparable b);
         bool sosMenor(IComparable a, IComparable b);
         bool sosMayor(IComparable a, IComparable b);
    }
}