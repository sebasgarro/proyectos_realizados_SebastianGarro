using System;
namespace Practica1
{
    public class Fabrica_de_Vendedores: Fabrica_de_Comparables
    {
        public override IComparable crearAleatorio(){
            string[] nombres = new string[]{"Diego","Solange","Gladys","Gisela","Enrique","Marcela", "David","Pablo", "Jimena","Maria","Ramon","Joaquin","Romina","Sonia","Claudia","Sebastian","Monica","Luna","Vanesa","Tobias"};
            string nombre = nombres[ManejadorDeDatos.numeroAleatorio(0,19)];
            int dni = ManejadorDeDatos.numeroAleatorio(10000000,99999999);
            double sueldo= ManejadorDeDatos.numeroAleatorio(30000,99999);
            return new Vendedor(nombre, dni, sueldo);
        
        }
        public override IComparable crearPorTeclado(){
            Console.WriteLine("::::INGRESANDO NUEVO VENDEDOR::::");
            string nombre = ManejadorDeDatos.stringPorTeclado("Ingrese su nombre: ");
            int dni = ManejadorDeDatos.numeroPorTeclado("Ingrese su DNI: ");
            double sueldo = ManejadorDeDatos.numeroPorTeclado("Ingrese su Sueldo Básico: ");
            return new Vendedor(nombre, dni, sueldo);
          

        }
    }
}