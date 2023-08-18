using Alumnos_y_Calificaciones.home.common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Alumnos_y_Calificaciones.home.model.core
{
    public class StudentsProvider
    {

        private readonly CommonMethods commonMethods = new CommonMethods();

        public List<StudentModel> GetStudents()
        {
            try
            {
                string json = File.ReadAllText("students.json");
                List<StudentModel> students = JsonSerializer.Deserialize<List<StudentModel>>(json);
                return students;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                return new List<StudentModel>();
            }
        }

        public StudentModel GetStudentById(int id)
        {
            return GetStudents().Find(student => student.ID == id);
        }

        public List<StudentModel> SearchStudents(string query)
        {
            List<StudentModel> students = GetStudents();
            return students.FindAll(student =>
            commonMethods.NormalizeString(student.FirstName.ToLower()).Contains(commonMethods.NormalizeString(query.ToLower()))
                ||
            commonMethods.NormalizeString(student.LastName.ToLower()).Contains(commonMethods.NormalizeString(query.ToLower())));
        }

        public void AddStudents(List<StudentModel> students)
        {
            string json = JsonSerializer.Serialize(students);
            File.WriteAllText("students.json", json);
        }

        public void AddStudent(StudentModel student)
        {
            List<StudentModel> students = GetStudents();
            if (students.Find(s => s.ID == student.ID) != null)
            {
                EditStudent(student);
                return;
            }

            students.Add(student);
            AddStudents(students);
        }

        public void DeleteStudent(int id)
        {
            List<StudentModel> students = GetStudents();
            students.RemoveAll(student => student.ID == id);
            AddStudents(students);
        }

        public void EditStudent(StudentModel student)
        {
            List<StudentModel> students = GetStudents();
            StudentModel saved = students.Find(s => s.ID == student.ID);
            saved.FirstName = student.FirstName;
            saved.LastName = student.LastName;
            saved.Age = student.Age;
            saved.Phone = student.Phone;
            saved.Subjects = student.Subjects;
            saved.CalculateAverage();
            AddStudents(students);
        }
    }
}
