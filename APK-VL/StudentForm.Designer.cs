
namespace APK_VL
{
    partial class StudentForm
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
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.StudentFlowLayoutClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.ClassesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(48, 24);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(89, 20);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name";
            // 
            // StudentFlowLayoutClasses
            // 
            this.StudentFlowLayoutClasses.AutoSize = true;
            this.StudentFlowLayoutClasses.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.StudentFlowLayoutClasses.Location = new System.Drawing.Point(330, 57);
            this.StudentFlowLayoutClasses.Name = "StudentFlowLayoutClasses";
            this.StudentFlowLayoutClasses.Size = new System.Drawing.Size(458, 381);
            this.StudentFlowLayoutClasses.TabIndex = 1;
            // 
            // ClassesLabel
            // 
            this.ClassesLabel.AutoSize = true;
            this.ClassesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesLabel.Location = new System.Drawing.Point(490, 24);
            this.ClassesLabel.Name = "ClassesLabel";
            this.ClassesLabel.Size = new System.Drawing.Size(72, 20);
            this.ClassesLabel.TabIndex = 2;
            this.ClassesLabel.Text = "Classes";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassesLabel);
            this.Controls.Add(this.StudentFlowLayoutClasses);
            this.Controls.Add(this.FullNameLabel);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.FlowLayoutPanel StudentFlowLayoutClasses;
        private System.Windows.Forms.Label ClassesLabel;
    }
}