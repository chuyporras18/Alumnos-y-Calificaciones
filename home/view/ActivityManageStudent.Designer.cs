
namespace Alumnos_y_Calificaciones.home.view
{
    partial class ActivityManageStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.SubjectsListView = new System.Windows.Forms.ListView();
            this.Materia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Promedio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 100);
            this.panel1.TabIndex = 0;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(6, 20);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(191, 22);
            this.NameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LastNameBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 100);
            this.panel2.TabIndex = 1;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(6, 20);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(191, 22);
            this.LastNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PhoneBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 100);
            this.panel3.TabIndex = 3;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(6, 20);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(191, 22);
            this.PhoneBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teléfono";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.AgeBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 100);
            this.panel4.TabIndex = 2;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(6, 20);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(191, 22);
            this.AgeBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Edad";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(12, 447);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(320, 35);
            this.AddStudentButton.TabIndex = 4;
            this.AddStudentButton.Text = "Agregar Estudiante";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // SubjectsListView
            // 
            this.SubjectsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Materia,
            this.Promedio});
            this.SubjectsListView.HideSelection = false;
            this.SubjectsListView.Location = new System.Drawing.Point(0, 0);
            this.SubjectsListView.Name = "SubjectsListView";
            this.SubjectsListView.Size = new System.Drawing.Size(499, 360);
            this.SubjectsListView.TabIndex = 5;
            this.SubjectsListView.UseCompatibleStateImageBehavior = false;
            this.SubjectsListView.View = System.Windows.Forms.View.Details;
            // 
            // Materia
            // 
            this.Materia.Text = "Materia";
            this.Materia.Width = 120;
            // 
            // Promedio
            // 
            this.Promedio.Text = "Promedio";
            this.Promedio.Width = 80;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(3, 380);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(133, 35);
            this.AddSubjectButton.TabIndex = 6;
            this.AddSubjectButton.Text = "Agregar Materia";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SubjectsListView);
            this.panel5.Controls.Add(this.AddSubjectButton);
            this.panel5.Location = new System.Drawing.Point(406, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(499, 418);
            this.panel5.TabIndex = 8;
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Location = new System.Drawing.Point(738, 447);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(192, 35);
            this.DeleteStudentButton.TabIndex = 9;
            this.DeleteStudentButton.Text = "Eliminar Estudiante";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // ActivityManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivityManageStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityAddStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.ListView SubjectsListView;
        private System.Windows.Forms.ColumnHeader Materia;
        private System.Windows.Forms.ColumnHeader Promedio;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button DeleteStudentButton;
    }
}