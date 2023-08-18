using Alumnos_y_Calificaciones.home.common;
using Alumnos_y_Calificaciones.home.model;
using Alumnos_y_Calificaciones.home.model.core;
using System;
using System.Windows.Forms;

namespace Alumnos_y_Calificaciones.home.view
{
    public partial class ActivityFindStudent : Form
    {
        public delegate void StudentModelResultDelegate(object sender, StudentModel student);

        public event StudentModelResultDelegate studentResult;

        private readonly CommonMethods commonMethods = new CommonMethods();

        private readonly StudentsProvider studentsProvider = new StudentsProvider();

        public ActivityFindStudent()
        {
            InitializeComponent();
        }

        private void SearchStudentButton_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(QuerySearchBox.Text.ToString(), out int id))
            {
                commonMethods.ShowError(QuerySearchBox, "ID no válido.");
                return;
            }

            StudentModel studentModel = studentsProvider.GetStudentById(id);

            if (studentModel != null)
            {
                OpenActivityAddStudent(studentModel);
            }
            else
            {
                MessageBox.Show("No existe el alumno con la ID introducida.");
            }
        }

        private void OpenActivityAddStudent(StudentModel studentModel)
        {
            ActivityManageStudent activityAddStudent = new ActivityManageStudent();
            activityAddStudent.studentResult += CloseActivityAddStudent;
            activityAddStudent.Show();
            activityAddStudent.BindStudentData(studentModel);
            Close();
        }

        private void CloseActivityAddStudent(object sender, StudentModel studentModel)
        {
            studentResult?.Invoke(sender, studentModel);
        }
    }
}
