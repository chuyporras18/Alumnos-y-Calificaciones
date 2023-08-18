using System.Collections.Generic;
using System.Linq;

namespace Alumnos_y_Calificaciones.home.model
{
    public class SubjectModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public List<CalificationModel> Califications { get; set; }
        public double Avg { get; set; }
        public int StudentID { get; set; }

        public SubjectModel(string name, List<CalificationModel> califications, int studentId)
        {
            ID = name.GetHashCode();
            Name = name;
            Califications = califications;
            Avg = CalculateAvg(califications);
            StudentID = studentId;
        }

        public double CalculateAvg(List<CalificationModel> califications)
        {
            return califications.Sum(c => c.Calification) / califications.Count;
        }
    }
}
