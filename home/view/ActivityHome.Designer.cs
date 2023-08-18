
namespace Alumnos_y_Calificaciones.home.view
{
    partial class ActivityHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FragmentContainer = new System.Windows.Forms.Panel();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.StudentsListView = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Teléfono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Materias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Promedio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FragmentContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FragmentContainer
            // 
            this.FragmentContainer.Controls.Add(this.AddStudentButton);
            this.FragmentContainer.Controls.Add(this.EditStudentButton);
            this.FragmentContainer.Controls.Add(this.StudentsListView);
            this.FragmentContainer.Controls.Add(this.panel1);
            this.FragmentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FragmentContainer.Location = new System.Drawing.Point(0, 0);
            this.FragmentContainer.Name = "FragmentContainer";
            this.FragmentContainer.Size = new System.Drawing.Size(942, 493);
            this.FragmentContainer.TabIndex = 0;
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(573, 86);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(176, 35);
            this.AddStudentButton.TabIndex = 6;
            this.AddStudentButton.Text = "Agregar Estudiante";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.Location = new System.Drawing.Point(755, 86);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(176, 35);
            this.EditStudentButton.TabIndex = 7;
            this.EditStudentButton.Text = "Editar Estudiante";
            this.EditStudentButton.UseVisualStyleBackColor = true;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // StudentsListView
            // 
            this.StudentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Teléfono,
            this.Materias,
            this.Promedio,
            this.ID});
            this.StudentsListView.HideSelection = false;
            this.StudentsListView.Location = new System.Drawing.Point(0, 130);
            this.StudentsListView.Name = "StudentsListView";
            this.StudentsListView.Size = new System.Drawing.Size(942, 363);
            this.StudentsListView.TabIndex = 4;
            this.StudentsListView.UseCompatibleStateImageBehavior = false;
            this.StudentsListView.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 120;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 120;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.Width = 50;
            // 
            // Teléfono
            // 
            this.Teléfono.Text = "Teléfono";
            this.Teléfono.Width = 120;
            // 
            // Materias
            // 
            this.Materias.Text = "Materias";
            this.Materias.Width = 120;
            // 
            // Promedio
            // 
            this.Promedio.Text = "Promedio";
            this.Promedio.Width = 80;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchButton);
            this.panel1.Controls.Add(this.SearchBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 121);
            this.panel1.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(206, 83);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 35);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Buscar";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(15, 42);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(295, 22);
            this.SearchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Por Nombre y Apellido";
            // 
            // ActivityHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.FragmentContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivityHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityHome";
            this.FragmentContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FragmentContainer;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.ListView StudentsListView;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.ColumnHeader Teléfono;
        private System.Windows.Forms.ColumnHeader Materias;
        private System.Windows.Forms.ColumnHeader Promedio;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
    }
}