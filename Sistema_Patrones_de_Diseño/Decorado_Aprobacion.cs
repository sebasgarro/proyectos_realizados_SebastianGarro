using System;
namespace Practica1
{
    public class Decorado_Aprobacion: AdicionalDecorador
    {
        public Decorado_Aprobacion(IAlumno ad)
        :base(ad){
        }

        public override string mostrarCalificacion(){
            double calificacion= base.GetCalificacion();
            string estado="";
            if(calificacion>=7){
                estado="(PROMOCIONADO)";
            }
            else if(calificacion>=4){
                estado="(APROBADO)";
            }
            else{
                estado="(DESAPROBADO)";
            }
            return (base.mostrarCalificacion().Replace(Convert.ToString(calificacion),calificacion+estado));
        }


        
    }
}