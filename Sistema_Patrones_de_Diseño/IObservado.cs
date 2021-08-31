using System;
namespace Practica1
{
    public interface IObservado
    {
         void agregarObservador(IObservador observador);
         void quitarObservador(IObservador observador);
         void notificar();
    }
}