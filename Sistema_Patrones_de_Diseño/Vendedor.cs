using System;
namespace Practica1
{
    public class Vendedor: Persona, IObservado
    {
        private double sueldo_basico;
        private double bonus;
        private double ultima_venta;
        private Estrategia_de_Comparacion estrategia; //PATRON STRATEGI
        private Conjunto gerentes;  //gerentes->OBSERVADORES

        public Vendedor(string n,int d, double s) 
            :base(n,d) {
                sueldo_basico = s;
                bonus=1;
                ultima_venta=0;
                gerentes = new Conjunto();
                estrategia = new Comparar_DNI();
            
        }

        public void venta(double monto){
            Console.WriteLine(this.GetNombre()+" realizó una venta por $ "+monto);
            ultima_venta=monto;
            notificar();
        }

        public void aumentaBonus(){
            bonus=bonus+0.1;
        }

        public double GetBonus(){
            return bonus;
        }
        public double GetSueldoBasico(){
            return sueldo_basico;
        }

        //SOBREESCRIBIMOS LA INTERFACE IComparable

        public override bool sosIgual(IComparable objeto){
             return estrategia.sosIgual(this,objeto);
         }

         public override bool sosMenor(IComparable objeto){
             return estrategia.sosMenor(this,objeto);
         }

         public override bool sosMayor(IComparable objeto){
             return estrategia.sosMayor(this,objeto);
         }

         public override string informar(){

             return "Vendedor \n"+"          Nombre: "+this.GetNombre()+"\n"+"          Sueldo Basico: "+sueldo_basico+"\n          Bonus: "+string.Format("{0:0.00}",bonus)+"\n          DNI: "+this.GetDNI();
         }

         public override void setEstrategia(Estrategia_de_Comparacion estrategia){
             this.estrategia = estrategia;
            
         }

         // PATRON OBSERVER --- OBSERVADO

         public void agregarObservador(IObservador observador){
             gerentes.agregar((Gerente)observador);
             
         }

         public void quitarObservador(IObservador observador){
             gerentes.eliminar((Gerente)observador);
             
         }

         public void notificar(){
             Iterador_de_Coleccionables iterador = gerentes.crearIterador();
             while(! iterador.fin()){
                 ((IObservador)iterador.actual()).actualizar(ultima_venta,this);
                 iterador.siguiente();
             }
         }

    }
}