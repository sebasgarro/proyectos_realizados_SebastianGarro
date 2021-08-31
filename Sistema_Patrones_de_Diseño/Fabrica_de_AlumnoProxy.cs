using System;
namespace Practica1
{
    public class Fabrica_de_AlumnoProxy : Fabrica_de_Alumnos
    {
        public override IComparable crearAleatorio(){
            return new AlumnoProxy(nombre,dni,legajo,promedio);

        }

        public override IComparable crearPorTeclado(){
          Console.WriteLine("::::INGRESANDO NUEVO ALUMNO::::");
          nombre = ManejadorDeDatos.stringPorTeclado("Ingrese su nombre: ");
          dni = ManejadorDeDatos.numeroPorTeclado("Ingrese su DNI: ");
          legajo = ManejadorDeDatos.numeroPorTeclado("Ingrese su Legajo: ");
          promedio = ManejadorDeDatos.numeroPorTeclado("Ingrese su promedio: ");
          return new AlumnoProxy(nombre,dni,legajo,promedio);
        }
    }
}