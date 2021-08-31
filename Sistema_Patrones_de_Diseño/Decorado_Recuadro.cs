using System;
namespace Practica1
{
    public class Decorado_Recuadro: AdicionalDecorador
    {
        public Decorado_Recuadro(IAlumno ad)
        :base(ad){

        }
        
        public override string mostrarCalificacion(){ 
            string muestra= base.mostrarCalificacion();
            string fila = new string('*',muestra.Length+4);
            return fila+"\n*  "+muestra+"*\n"+fila;
        }

      
        
    }
}
    
