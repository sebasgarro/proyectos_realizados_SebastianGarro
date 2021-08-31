namespace Practica1
{
    public interface IColeccionable : Iterable, IOrdenable
    {
         int cuantos();

         IComparable minimo();

         IComparable maximo();

         void agregar(IComparable elemento);

         bool contiene(IComparable elemento);
         
    }
}