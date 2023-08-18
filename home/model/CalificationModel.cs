namespace Alumnos_y_Calificaciones.home.model
{
    public class CalificationModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public double Calification { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }

        public CalificationModel(string name, double calification, int studentId, int subjectId)
        {
            ID = name.GetHashCode();
            Name = name;
            Calification = calification;
            StudentID = studentId;
            SubjectID = subjectId;
        }
    }
}
