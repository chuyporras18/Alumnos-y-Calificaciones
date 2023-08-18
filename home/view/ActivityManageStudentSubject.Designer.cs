
namespace Alumnos_y_Calificaciones.home.view
{
    partial class ActivityManageStudentSubject
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AddCalificationButton = new System.Windows.Forms.Button();
            this.CalificationBox = new System.Windows.Forms.TextBox();
            this.CustonNameCalificationBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalificationsListView = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Calificación = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.SubjectNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CalificationsListView);
            this.panel1.Controls.Add(this.AddSubjectButton);
            this.panel1.Controls.Add(this.SubjectNameBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 493);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Calificaciones";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.AddCalificationButton);
            this.panel2.Controls.Add(this.CalificationBox);
            this.panel2.Controls.Add(this.CustonNameCalificationBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(697, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 211);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Calificación";
            // 
            // AddCalificationButton
            // 
            this.AddCalificationButton.Location = new System.Drawing.Point(6, 159);
            this.AddCalificationButton.Name = "AddCalificationButton";
            this.AddCalificationButton.Size = new System.Drawing.Size(204, 35);
            this.AddCalificationButton.TabIndex = 4;
            this.AddCalificationButton.Text = "Agregar Calificación";
            this.AddCalificationButton.UseVisualStyleBackColor = true;
            this.AddCalificationButton.Click += new System.EventHandler(this.AddCalificationButton_Click);
            // 
            // CalificationBox
            // 
            this.CalificationBox.Location = new System.Drawing.Point(6, 113);
            this.CalificationBox.Name = "CalificationBox";
            this.CalificationBox.Size = new System.Drawing.Size(204, 22);
            this.CalificationBox.TabIndex = 3;
            // 
            // CustonNameCalificationBox
            // 
            this.CustonNameCalificationBox.Location = new System.Drawing.Point(6, 53);
            this.CustonNameCalificationBox.Name = "CustonNameCalificationBox";
            this.CustonNameCalificationBox.Size = new System.Drawing.Size(204, 22);
            this.CustonNameCalificationBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agregar Calificación";
            // 
            // CalificationsListView
            // 
            this.CalificationsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Calificación,
            this.ID});
            this.CalificationsListView.HideSelection = false;
            this.CalificationsListView.Location = new System.Drawing.Point(15, 90);
            this.CalificationsListView.Name = "CalificationsListView";
            this.CalificationsListView.Size = new System.Drawing.Size(361, 391);
            this.CalificationsListView.TabIndex = 3;
            this.CalificationsListView.UseCompatibleStateImageBehavior = false;
            this.CalificationsListView.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Calificación
            // 
            this.Calificación.Text = "Calificación";
            this.Calificación.Width = 120;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 120;
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(779, 446);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(151, 35);
            this.AddSubjectButton.TabIndex = 2;
            this.AddSubjectButton.Text = "Guardar Materia";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectButton_Click);
            // 
            // SubjectNameBox
            // 
            this.SubjectNameBox.Location = new System.Drawing.Point(15, 29);
            this.SubjectNameBox.Name = "SubjectNameBox";
            this.SubjectNameBox.Size = new System.Drawing.Size(361, 22);
            this.SubjectNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materia";
            // 
            // ActivityManageStudentSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActivityManageStudentSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityManageStudentSubjectCalifications";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.TextBox SubjectNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddCalificationButton;
        private System.Windows.Forms.TextBox CalificationBox;
        private System.Windows.Forms.TextBox CustonNameCalificationBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView CalificationsListView;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader Calificación;
        private System.Windows.Forms.ColumnHeader ID;
    }
}