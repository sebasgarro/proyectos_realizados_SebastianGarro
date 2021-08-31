using System;
namespace Practica1
{
    public class Fabrica_de_Alumnos: Fabrica_de_Comparables
    {
        protected string nombre;
        protected int dni;
        protected int legajo;
        protected int promedio;
        protected string[] nombres;

        public Fabrica_de_Alumnos(){
            nombre = ManejadorDeDatos.nombreAleatorio();
            dni = ManejadorDeDatos.numeroAleatorio(10000000,99999999);
            legajo = ManejadorDeDatos.numeroAleatorio(1000,99999);
            promedio = ManejadorDeDatos.numeroAleatorio(0,11);
        }
        public override IComparable crearAleatorio(){
            return new Alumno(nombre, dni, legajo, promedio);
        
    }

    public override IComparable crearPorTeclado(){
          Console.WriteLine("::::INGRESANDO NUEVO ALUMNO::::");
          nombre = ManejadorDeDatos.stringPorTeclado("Ingrese su nombre: ");
          dni = ManejadorDeDatos.numeroPorTeclado("Ingrese su DNI: ");
          legajo = ManejadorDeDatos.numeroPorTeclado("Ingrese su Legajo: ");
          promedio = ManejadorDeDatos.numeroPorTeclado("Ingrese su promedio: ");
          return new Alumno(nombre,dni,legajo,promedio);

    }
 }
}