using Alumnos_y_Calificaciones.home.common;
using Alumnos_y_Calificaciones.home.model;
using Alumnos_y_Calificaciones.home.model.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Alumnos_y_Calificaciones.home.view
{
    public partial class ActivityManageStudent : Form
    {

        public delegate void StudentModelResultDelegate(object sender, StudentModel student);

        public event StudentModelResultDelegate studentResult;

        private readonly CommonMethods commonMethods = new CommonMethods();

        private readonly StudentsProvider studentProvider = new StudentsProvider();

        private StudentModel studentModel = new StudentModel("", "", 0, 0, new List<SubjectModel>());

        private int? lastStudentId = null;
        public ActivityManageStudent()
        {
            InitializeComponent();

            SubjectsListView.ItemSelectionChanged += OnSubjectSelected;
            SubjectsListView.KeyUp += OnDeleteSubjects;
            OnSubjectSelected(this, null);

            DeleteStudentButton.Visible = false;
        }

        private void OnSubjectSelected(object sender, EventArgs e)
        {
            bool areItemsSelected = SubjectsListView.SelectedItems.Count != 0;

            if (areItemsSelected)
            {
                AddSubjectButton.Text = "Editar Materia";
            }
            else
            {
                AddSubjectButton.Text = "Agregar Materia";
            }
        }

        public void BindStudentData(StudentModel studentModel)
        {
            NameBox.Text = studentModel.FirstName;
            LastNameBox.Text = studentModel.LastName;
            AgeBox.Text = studentModel.Age.ToString();
            PhoneBox.Text = studentModel.Phone.ToString();
            AddStudentButton.Text = "Actualizar Registro Estudiante";

            DeleteStudentButton.Visible = true;

            this.studentModel = studentModel;

            lastStudentId = studentModel.ID;

            UpdateSubjectsLitsView(studentModel.Subjects);
        }

        public void UpdateSubjectsLitsView(List<SubjectModel> subjects)
        {
            SubjectsListView.Items.Clear();
            SubjectsListView.Columns.Clear();

            SubjectsListView.Columns.Add("Materia", 120);
            SubjectsListView.Columns.Add("Promedio", 80);

            if (subjects.Count == 0) return;

            int max = subjects.Max(s => s.Califications.Count);

            for (int i = 0; i < max; i++)
            {
                SubjectsListView.Columns.Add("C" + (i + 1).ToString(), 120);
            }

            SubjectsListView.Columns.Add("ID", 120);

            foreach (SubjectModel subject in subjects)
            {
                string name = subject.Name;
                string avg = subject.Avg.ToString();
                string id = subject.ID.ToString();

                List<string> empty = Enumerable.Repeat("", max - subject.Califications.Count).ToList();

                string[] califications = subject.Califications.ConvertAll(s => s.Name.ToString() + ": " + s.Calification).Concat(empty).ToArray();

                ListViewItem item = new ListViewItem(new[] { name, avg }.Concat(califications).Concat(new[] { id }).ToArray());

                SubjectsListView.Items.Add(item);
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string firstName = NameBox.Text;
            string lastName = LastNameBox.Text;

            string digitsPattern = @"\d";

            bool hasErrors = false;

            if (string.IsNullOrEmpty(firstName) || Regex.IsMatch(firstName, digitsPattern))
            {
                commonMethods.ShowError(NameBox, "El nombre no puede estar vacío o contener números.");
                hasErrors = true;
            }

            if (string.IsNullOrEmpty(lastName) || Regex.IsMatch(lastName, digitsPattern))
            {
                commonMethods.ShowError(LastNameBox, "El apellido no puede estar vacío o contener números.");
                hasErrors = true;
            }

            if (!long.TryParse(PhoneBox.Text, out long phone))
            {
                commonMethods.ShowError(PhoneBox, "El teléfono debe incluir solo números.");
                hasErrors = true;
            }

            if (!int.TryParse(AgeBox.Text, out int age) || age <= 0)
            {
                commonMethods.ShowError(AgeBox, "La edad debe incluir sólo numeros y ser mayor a 0.");
                hasErrors = true;
            }

            if (hasErrors)
            {
                return;
            }

            studentModel.FirstName = firstName;
            studentModel.LastName = lastName;
            studentModel.Phone = phone;
            studentModel.Age = age;

            if (lastStudentId == null)
            {
                studentModel.ID = studentModel.Name().GetHashCode();
            }

            foreach (SubjectModel subject in studentModel.Subjects)
            {
                foreach (CalificationModel calification in subject.Califications)
                {
                    calification.StudentID = studentModel.ID;
                }

                subject.StudentID = studentModel.ID;
            }

            OnValueReturned(studentModel);
        }

        private void OnValueReturned(StudentModel studentModel)
        {
            studentResult?.Invoke(this, studentModel);
            Close();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            string message = $"¿Está seguro de eliminar a {studentModel.Name()} de la Base de Datos?";
            string title = "Confirmar Eliminación";

            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            studentProvider.DeleteStudent(studentModel.ID);

            OnValueReturned(null);
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            ActivityManageStudentSubject activityManageStudentSubjectCalifications = new ActivityManageStudentSubject();
            activityManageStudentSubjectCalifications.subjectResult += ManageSubjectResult;
            activityManageStudentSubjectCalifications.Show();

            if (SubjectsListView.SelectedItems.Count != 0)
            {
                int selectedId = GetSubjectId(SubjectsListView.SelectedItems[0].SubItems);
                SubjectModel subjectModel = studentModel.Subjects.Find(subject => subject.ID == selectedId);
                activityManageStudentSubjectCalifications.BindSubjectData(subjectModel);
            }
            else
            {
                activityManageStudentSubjectCalifications.subjectModel.StudentID = studentModel.ID;
            }
        }

        private int GetSubjectId(ListViewSubItemCollection subItems)
        {
            return int.Parse(subItems[subItems.Count - 1].Text);
        }

        private void ManageSubjectResult(object sender, SubjectModel subjectModel)
        {
            if (subjectModel == null) return;

            SubjectModel subject = studentModel.Subjects.Find(s => s.ID == subjectModel.ID);

            if (subject != null)
            {
                subject.Name = subjectModel.Name;
                subject.Califications = subjectModel.Califications;
                subject.Avg = subjectModel.Avg;
            }
            else
            {
                studentModel.Subjects.Add(subjectModel);
            }

            UpdateSubjectsLitsView(studentModel.Subjects);
        }

        private void OnDeleteSubjects(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;

            if (SubjectsListView.SelectedItems.Count == 0) return;

            string message = $"¿Está seguro de eliminar las {SubjectsListView.SelectedItems.Count} materias del Estudiante {studentModel.Name()}?";
            string title = "Confirmar Eliminación";

            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            for (int i = 0; i < SubjectsListView.SelectedItems.Count; i++)
            {
                studentModel.Subjects.RemoveAll(cal => cal.ID == GetSubjectId(SubjectsListView.SelectedItems[i].SubItems));
            }

            UpdateSubjectsLitsView(studentModel.Subjects);
            OnSubjectSelected(sender, e);
        }
    }
}
