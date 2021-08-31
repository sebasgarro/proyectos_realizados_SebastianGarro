namespace Practica1
{
    public class Persona : IComparable,Jugador
    {
        string nombre;
        private int dni;
        private Pila MisCartas;

        public Persona(string n, int d){
            nombre = n;
            dni = d;
        }


        public string GetNombre(){
            return nombre;
        }

        public int GetDNI(){
            return dni;
        }

        //Implementamos la interface Comparable

         public virtual bool sosIgual(IComparable objeto){
             Persona persona = (Persona) objeto;
             if(dni == persona.GetDNI()){
                 return true;
             }
             else{
                 return false;
             }
         }

         public virtual bool sosMenor(IComparable objeto){
             Persona persona = (Persona) objeto;
             if(dni < persona.GetDNI()){
                 return true;
             }
             else{
                 return false;
             }
         }

         public virtual bool sosMayor(IComparable objeto){

             Persona persona = (Persona) objeto;
             if(dni > persona.GetDNI()){
                 return true;
             }
             else{
                 return false;
             }
         }

         public virtual string informar(){

             return "Persona\n"+"Nombre: "+nombre+"\n"+"DNI: "+dni;
         }

         public virtual void setEstrategia(Estrategia_de_Comparacion estrategia){
             
         }

         //Implementamos la interfaz Jugador

         public void prepararse(){
             MisCartas = new Pila();
         }
         
         public void tomarCarta(Carta carta){
             MisCartas.push(carta);
         }

         public Carta descartarCarta(){
             return (Carta)MisCartas.pop();
         }

         public int CuanasCartas(){
             return MisCartas.cuantos();
         }
    }
}