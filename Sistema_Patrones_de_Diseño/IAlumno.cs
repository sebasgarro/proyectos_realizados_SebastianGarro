namespace Practica1
{
    public interface IAlumno:IComparable
    {
        string GetNombre();
        int GetDNI();
        int GetLegajo();
        double GetPromedio();
        double GetCalificacion();
        void SetCalificacion(double c);
        int responderPregunta(int pregunta);
        string mostrarCalificacion();
         
    }
}