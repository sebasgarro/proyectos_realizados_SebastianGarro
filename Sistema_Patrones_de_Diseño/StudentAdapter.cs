namespace Practica1
{
    public class StudentAdapter: Student
    {
        private IAlumno estudiante;

        public IAlumno getStudent(){
            return estudiante;
        }

        public StudentAdapter(IAlumno alumno){
            estudiante=alumno;
        }
        public string getName(){
            return estudiante.GetNombre();
        }
		public int yourAnswerIs(int question){
            return estudiante.responderPregunta(question);
        }
		public void setScore(int score){
            estudiante.SetCalificacion(score);
        }
		public string showResult(){
            return estudiante.mostrarCalificacion();
        }
		public bool equals(Student student){
            return estudiante.sosIgual(((StudentAdapter)student).getStudent());
        }
		public bool lessThan(Student student){
            return estudiante.sosMenor(((StudentAdapter)student).getStudent());
        }
		public bool greaterThan(Student student){
            return estudiante.sosMayor(((StudentAdapter)student).getStudent());
        }
    }
}