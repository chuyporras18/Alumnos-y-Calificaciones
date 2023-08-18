using Alumnos_y_Calificaciones.home.model;
using Alumnos_y_Calificaciones.home.model.core;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Alumnos_y_Calificaciones.home.view
{
    public partial class ActivityHome : Form
    {
        private readonly StudentsProvider studentsProvider = new StudentsProvider();

        public ActivityHome()
        {
            InitializeComponent();
            UpdateStudentsListView(studentsProvider.GetStudents());

            StudentsListView.KeyUp += OnDeleteStudents;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            ActivityManageStudent activityAddStudent = new ActivityManageStudent();
            activityAddStudent.studentResult += ManageStudentResult;
            activityAddStudent.Show();
        }

        private void ManageStudentResult(object sender, StudentModel studentModel)
        {
            if (studentModel != null)
            {
                studentsProvider.AddStudent(studentModel);
            }

            UpdateStudentsListView(studentsProvider.GetStudents());
        }

        private void UpdateStudentsListView(List<StudentModel> students)
        {
            StudentsListView.Items.Clear();
            foreach (StudentModel student in students)
            {
                string firstName = student.FirstName.ToString();
                string lastName = student.LastName.ToString();
                string age = student.Age.ToString();
                string phone = student.Phone.ToString();
                string generalAvg = student.GeneralAvg.ToString();
                string subjects = string.Join(", ", student.Subjects.ConvertAll(subject => subject.Name)).ToString();
                string id = student.ID.ToString();

                ListViewItem item = new ListViewItem(new[] { firstName, lastName, age, phone, subjects, generalAvg, id });

                StudentsListView.Items.Add(item);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            UpdateStudentsListView(studentsProvider.SearchStudents(SearchBox.Text.ToString()));
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            if (StudentsListView.SelectedItems.Count == 0)
            {
                ActivityFindStudent activityFindStudent = new ActivityFindStudent();
                activityFindStudent.studentResult += ManageStudentResult;
                activityFindStudent.Show();
            }
            else
            {
                StudentModel studentModel = studentsProvider.GetStudentById(GetStudentId(StudentsListView.SelectedItems[0].SubItems));
                ActivityManageStudent activityAddStudent = new ActivityManageStudent();
                activityAddStudent.studentResult += ManageStudentResult;
                activityAddStudent.Show();
                activityAddStudent.BindStudentData(studentModel);
            }
        }

        private void OnDeleteStudents(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;

            if (StudentsListView.SelectedItems.Count == 0) return;

            string message = $"¿Está seguro de eliminar a los {StudentsListView.SelectedItems.Count} Estudiantes de la Base de Datos?";
            string title = "Confirmar Eliminación";

            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            for (int i = 0; i < StudentsListView.SelectedItems.Count; i++)
            {
                studentsProvider.DeleteStudent(GetStudentId(StudentsListView.SelectedItems[i].SubItems));
            }

            UpdateStudentsListView(studentsProvider.GetStudents());
        }

        public int GetStudentId(ListViewSubItemCollection subItems)
        {
            return int.Parse(subItems[subItems.Count - 1].Text);
        }
    }
}
