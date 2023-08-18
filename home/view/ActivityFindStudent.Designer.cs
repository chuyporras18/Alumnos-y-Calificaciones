
namespace Alumnos_y_Calificaciones.home.view
{
    partial class ActivityFindStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.QuerySearchBox = new System.Windows.Forms.TextBox();
            this.SearchStudentButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Estudiante por ID";
            // 
            // QuerySearchBox
            // 
            this.QuerySearchBox.Location = new System.Drawing.Point(8, 41);
            this.QuerySearchBox.Margin = new System.Windows.Forms.Padding(8);
            this.QuerySearchBox.Name = "QuerySearchBox";
            this.QuerySearchBox.Size = new System.Drawing.Size(162, 22);
            this.QuerySearchBox.TabIndex = 1;
            // 
            // SearchStudentButton
            // 
            this.SearchStudentButton.Location = new System.Drawing.Point(8, 79);
            this.SearchStudentButton.Margin = new System.Windows.Forms.Padding(8);
            this.SearchStudentButton.Name = "SearchStudentButton";
            this.SearchStudentButton.Size = new System.Drawing.Size(162, 35);
            this.SearchStudentButton.TabIndex = 2;
            this.SearchStudentButton.Text = "Buscar";
            this.SearchStudentButton.UseVisualStyleBackColor = true;
            this.SearchStudentButton.Click += new System.EventHandler(this.SearchStudentButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.QuerySearchBox);
            this.flowLayoutPanel1.Controls.Add(this.SearchStudentButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 127);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ActivityFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ActivityFindStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActivityFindStudent";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuerySearchBox;
        private System.Windows.Forms.Button SearchStudentButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}