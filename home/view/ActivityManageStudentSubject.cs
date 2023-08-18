using Alumnos_y_Calificaciones.home.common;
using Alumnos_y_Calificaciones.home.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Alumnos_y_Calificaciones.home.view
{
    public partial class ActivityManageStudentSubject : Form
    {

        public delegate void SubjectModelResultDelegate(object sender, SubjectModel subjectModel);

        public event SubjectModelResultDelegate subjectResult;

        public SubjectModel subjectModel = new SubjectModel("", new List<CalificationModel>(), -1);

        private readonly CommonMethods commonMethods = new CommonMethods();

        public ActivityManageStudentSubject()
        {
            InitializeComponent();

            CalificationsListView.ItemSelectionChanged += OnCalificationSelected;
            CalificationsListView.KeyUp += OnDeleteCalifications;
        }

        public void BindSubjectData(SubjectModel subjectModel)
        {
            SubjectNameBox.Text = subjectModel.Name;

            AddSubjectButton.Text = "Actualizar Materia";

            this.subjectModel = subjectModel;

            UpdateCalificationsListView(subjectModel.Califications);
        }

        private void UpdateCalificationsListView(List<CalificationModel> califications)
        {
            CalificationsListView.Items.Clear();

            foreach (CalificationModel calification in califications)
            {
                string name = calification.Name;
                string cal = calification.Calification.ToString();
                string id = calification.ID.ToString();

                ListViewItem item = new ListViewItem(new[] { name, cal, id });

                CalificationsListView.Items.Add(item);
            }
        }

        private void OnCalificationSelected(object sender, EventArgs e)
        {
            if (CalificationsListView.SelectedItems.Count == 0)
            {
                BindCalificationSelected(null);
                return;
            }

            int selectedId = GetCalificationId(CalificationsListView.SelectedItems[0].SubItems);
            CalificationModel calificationsModel = subjectModel.Califications.Find(calification => calification.ID == selectedId);
            BindCalificationSelected(calificationsModel);
        }

        private void BindCalificationSelected(CalificationModel calificationsModel)
        {
            if (calificationsModel == null)
            {
                CustonNameCalificationBox.Clear();
                CalificationBox.Clear();
                AddCalificationButton.Text = "Agregar Calificación";
            }
            else
            {
                CustonNameCalificationBox.Text = calificationsModel.Name;
                CalificationBox.Text = calificationsModel.Calification.ToString();
                AddCalificationButton.Text = "Actualizar Calificación";
            }
        }

        public int GetCalificationId(ListViewSubItemCollection subItems)
        {
            return int.Parse(subItems[subItems.Count - 1].Text);
        }

        private void OnValueReturned(object sender, SubjectModel subjectModel)
        {
            subjectResult?.Invoke(this, subjectModel);
            Close();
        }

        private void AddSubjectButton_Click(object sender, EventArgs e)
        {
            string name = SubjectNameBox.Text;

            if (string.IsNullOrEmpty(name))
            {
                commonMethods.ShowError(SubjectNameBox, "Ingrese un nombre a la materia.");
                return;
            }

            subjectModel.ID = name.GetHashCode();
            subjectModel.Name = name;
            subjectModel.Avg = subjectModel.CalculateAvg(subjectModel.Califications);

            OnValueReturned(this, subjectModel);
        }

        private void AddCalificationButton_Click(object sender, EventArgs e)
        {
            string name = CustonNameCalificationBox.Text;

            if (!double.TryParse(CalificationBox.Text, out double calification))
            {
                commonMethods.ShowError(CalificationBox, "Calificación no válida.");
                return;
            }

            if (CalificationsListView.SelectedItems.Count == 0)
            {
                CalificationModel calificationModel = new CalificationModel(name, calification, subjectModel.StudentID, subjectModel.ID);
                subjectModel.Califications.Add(calificationModel);
            }
            else
            {
                int selectedId = GetCalificationId(CalificationsListView.SelectedItems[0].SubItems);
                CalificationModel calificationModel = subjectModel.Califications.Find(cal => cal.ID == selectedId);
                calificationModel.Name = name;
                calificationModel.Calification = calification;
            }

            BindCalificationSelected(null);

            CustonNameCalificationBox.Focus();

            UpdateCalificationsListView(subjectModel.Califications);
        }

        private void OnDeleteCalifications(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;

            if (CalificationsListView.SelectedItems.Count == 0) return;

            string message = $"¿Está seguro de eliminar las {CalificationsListView.SelectedItems.Count} Calificaciones de la Materia {SubjectNameBox.Text} de la Base de Datos?";
            string title = "Confirmar Eliminación";

            if (MessageBox.Show(message, title, MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            for (int i = 0; i < CalificationsListView.SelectedItems.Count; i++)
            {
                int selectedId = GetCalificationId(CalificationsListView.SelectedItems[i].SubItems);
                subjectModel.Califications.RemoveAll(cal => cal.ID == selectedId);
            }

            UpdateCalificationsListView(subjectModel.Califications);
        }
    }
}
