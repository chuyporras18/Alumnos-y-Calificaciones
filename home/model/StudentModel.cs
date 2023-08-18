using System.Collections.Generic;
using System.Linq;

namespace Alumnos_y_Calificaciones.home.model
{
    public class StudentModel
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public int Age { get; set; }
        public List<SubjectModel> Subjects { get; set; }
        public double GeneralAvg { get; private set; }

        public StudentModel(string firstName, string lastName, long phone, int age, List<SubjectModel> subjects)
        {
            ID = Name().GetHashCode();
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Age = age;
            Subjects = subjects;

            CalculateAverage();
        }

        public string Name()
        {
            return FirstName + " " + LastName;
        }

        public void CalculateAverage()
        {
            if (Subjects.Count == 0)
            {
                GeneralAvg = 0;
            }
            else
            {
                GeneralAvg = Subjects.SelectMany(subject => subject.Califications).Sum(c => c.Calification) / Subjects.Sum(subject => subject.Califications.Count);
            }
        }

    }
}
