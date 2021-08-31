using System;
namespace Practica1
{
    public class Decorado_NotaEscrita: AdicionalDecorador
    {

         public Decorado_NotaEscrita(IAlumno ad)
        :base(ad){
        }

        public override string mostrarCalificacion(){
            string calificacion = Convert.ToString(base.GetCalificacion());
            string enpalabra="";
            if(calificacion=="0"){
                enpalabra="(CERO)";
            }
            if(calificacion=="1"){
                enpalabra="(UNO)";
            }
            if(calificacion=="2"){
                enpalabra="(DOS)";
            }
            if(calificacion=="3"){
                enpalabra="(TRES)";
            }
            if(calificacion=="4"){
                enpalabra="(CUATRO)";
            }
            if(calificacion=="5"){
                enpalabra="(CINCO)";
            }
            if(calificacion=="6"){
                enpalabra="(SEIS)";
            }
            if(calificacion=="7"){
                enpalabra="(SIETE)";
            }
            if(calificacion=="8"){
                enpalabra="(OCHO)";
            }
            if(calificacion=="9"){
                enpalabra="(NUEVE)";
            }
            if(calificacion=="10"){
                enpalabra="(DIEZ)";
            }
            return (base.mostrarCalificacion().Replace(calificacion,calificacion+enpalabra));
        }

        
        
    }
}
    