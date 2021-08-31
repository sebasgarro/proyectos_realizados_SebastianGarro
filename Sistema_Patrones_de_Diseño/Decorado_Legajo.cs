namespace Practica1
{
    public class Decorado_Legajo: AdicionalDecorador
    {

        public Decorado_Legajo(IAlumno ad)
        :base(ad){
        }

        public override string mostrarCalificacion(){
            string nombre = base.GetNombre();
            return (base.mostrarCalificacion().Replace(nombre,nombre+"("+base.GetLegajo()+")"));
        }

       
        
    }
}

        
