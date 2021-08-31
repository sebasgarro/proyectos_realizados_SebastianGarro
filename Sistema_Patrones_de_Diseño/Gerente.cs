namespace Practica1
{
    public class Gerente: Persona, IObservador
    {
        private Conjunto vendedores;

        public Gerente(string n, int d)
        :base(n,d){
            vendedores = new Conjunto();
        }

        public void cerrar(){
            Impresora.imprimirElementos((Iterable)vendedores);
        }

        public void venta(double monto, Vendedor vendedor){
            if(monto>5000){
                vendedores.agregar(vendedor);
                Iterador_de_Coleccionables iterador = vendedores.crearIterador();
                while(! iterador.fin()){
                    if(iterador.actual().sosIgual(vendedor)){
                        ((Vendedor)iterador.actual()).aumentaBonus();
                        iterador.siguiente();
                        
                    }
                    else{
                        iterador.actual();
                        iterador.siguiente();
                    }
                    
                }
            }
        }

        // PATRON OBSERVER

        public void actualizar(double monto, IObservado observado){
            this.venta(monto,(Vendedor)observado);
        } 
    }
}