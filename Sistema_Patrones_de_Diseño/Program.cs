using System;


namespace Practica1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
    /*PRACTICA 6:: Hasta ejercicio 2:: 
    Creamos 20 Almunos, 20 AlumnosMuyEstudiosos y 1 AlumnoCompuesto,
      este ultimo al generar la respuesta en el examen devuelve la mas votada por los 5 Proxys */
    /*         IColeccionable coleccion = new Pila();
             coleccion.SetMatriculaMaxima(41); //Por defecto es 40
             Aula aula = new Aula();
             coleccion.setOrdenInicio(new OrdenInicio(aula));
             coleccion.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
             coleccion.setOrdenAulaLlena(new OrdenAulaLlena(aula));
             AlumnoCompuesto alumnoCompuesto =(AlumnoCompuesto) Fabrica_de_Comparables.crearAleatorio("AlumnoCompuesto");
             
             llenarColeccionable(coleccion,"Alumno");
             llenarColeccionable(coleccion,"AlumnoMuyEstudioso");
             coleccion.agregar(alumnoCompuesto);
    */

   Persona p1 =(Alumno) Fabrica_de_Comparables.crearAleatorio("Alumno");
    Persona p2 =(Alumno) Fabrica_de_Comparables.crearAleatorio("Alumno");
    Console.WriteLine(p1.informar());
    Console.WriteLine(p2.informar());
    Juego_de_Cartas juego = new JuegoCartas_Recoleccion(p1,p2);
    Persona ganadora=juego.ComenzarPartida();
    Console.WriteLine(ganadora.informar()); 

    
    


         


            

        }


        private static void JornadaDeVentas(IColeccionable vendedores){
            
            double monto=0;
            for(int i=0; i<20; i++){
                Iterador_de_Coleccionables iterador = ((Iterable)vendedores).crearIterador();
                while(! iterador.fin()){
                    monto = ManejadorDeDatos.numeroAleatorio(1,7000);
                    //EN CASO DE QUE LA COLECCION SEA DICCIONARIO RETORNA LA CLAVEVALOR,PERO NOSOTROS QUEREMOS EL VALOR.
                    if(vendedores.GetType()== Type.GetType("Practica1.Diccionario")){
                        ((Vendedor)(((ClaveValor)iterador.actual()).getValor())).venta(monto);;
                         iterador.siguiente();

                    }
                    else{
                         ((Vendedor)iterador.actual()).venta(monto);;
                         iterador.siguiente();
                    }
                   
                }
            }
        }

        public static void AsignarGerente(IColeccionable vendedores, IObservador gerente){
            Iterador_de_Coleccionables iterador = ((Iterable)vendedores).crearIterador(); 
            while(! iterador.fin()){
                if(vendedores.GetType()== Type.GetType("Practica1.Diccionario")){
                    ((IObservado)((ClaveValor)iterador.actual()).getValor()).agregarObservador(gerente);
                    iterador.siguiente();
                }
                else{
                     ((IObservado)iterador.actual()).agregarObservador(gerente);
                     iterador.siguiente();
                }
               
            }

        }



        public static void llenarColeccionable(IColeccionable coleccion, string opcion){

            for(int i=0; i<20; i++){

                IComparable elemento = Fabrica_de_Comparables.crearAleatorio(opcion);

                coleccion.agregar(elemento);
            }


    
        }


        public static void informarColeccionable(IColeccionable coleccion, string opcion){
            //Imprimimos la cantidad de elementos del IColeccionable.
            Console.WriteLine("La cantidad de elementos en la colección es de: "+ coleccion.cuantos() + " elementos.");
            /*Imprimimos el elemento minimo del IColeccionable.  
            Usamos el método informar de la interfaz comparable, implementado en cada clase*/
            Console.Write("Información del objeto mínimo: ");
            Console.WriteLine(coleccion.minimo().informar());
            Console.Write("Información del objeto máximo: ");
            Console.WriteLine(coleccion.maximo().informar());
            IComparable elemento = Fabrica_de_Comparables.crearPorTeclado(opcion);
            if (coleccion.contiene(elemento)){
                Console.WriteLine("El elemento ingresado está en la colección.");
            }
            else{
                Console.WriteLine("El elemento ingresado no está en la colección.");
            }

        }



        public static void cambiarEstrategia(IColeccionable coleccion, Estrategia_de_Comparacion estrategia){
            Iterador_de_Coleccionables iterador = ((Iterable)coleccion).crearIterador();
            
            while(! iterador.fin()){
                iterador.actual().setEstrategia(estrategia);
                iterador.siguiente();
            }
        }



    



            
        







    }
}





