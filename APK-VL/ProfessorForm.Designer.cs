
namespace APK_VL
{
    partial class ProfessorForm
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
            this.StudentsLabel = new System.Windows.Forms.Label();
            this.ProfessorStudentsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.StudentMarkLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // StudentsLabel
            // 
            this.StudentsLabel.AutoSize = true;
            this.StudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsLabel.Location = new System.Drawing.Point(60, 9);
            this.StudentsLabel.Name = "StudentsLabel";
            this.StudentsLabel.Size = new System.Drawing.Size(72, 16);
            this.StudentsLabel.TabIndex = 0;
            this.StudentsLabel.Text = "Students:";
            // 
            // ProfessorStudentsFlowLayout
            // 
            this.ProfessorStudentsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ProfessorStudentsFlowLayout.Location = new System.Drawing.Point(12, 28);
            this.ProfessorStudentsFlowLayout.Name = "ProfessorStudentsFlowLayout";
            this.ProfessorStudentsFlowLayout.Size = new System.Drawing.Size(168, 410);
            this.ProfessorStudentsFlowLayout.TabIndex = 1;
            // 
            // StudentMarkLayout
            // 
            this.StudentMarkLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.StudentMarkLayout.Location = new System.Drawing.Point(238, 28);
            this.StudentMarkLayout.Name = "StudentMarkLayout";
            this.StudentMarkLayout.Size = new System.Drawing.Size(528, 410);
            this.StudentMarkLayout.TabIndex = 2;
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentMarkLayout);
            this.Controls.Add(this.ProfessorStudentsFlowLayout);
            this.Controls.Add(this.StudentsLabel);
            this.Name = "ProfessorForm";
            this.Text = "ProfessorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudentsLabel;
        private System.Windows.Forms.FlowLayoutPanel ProfessorStudentsFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel StudentMarkLayout;
    }
}