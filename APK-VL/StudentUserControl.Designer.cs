
namespace APK_VL
{
    partial class StudentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.ClassDescriptionLabel = new System.Windows.Forms.Label();
            this.ClassCreditsLabel = new System.Windows.Forms.Label();
            this.StudentMarkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClassNameLabel.Location = new System.Drawing.Point(15, 12);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(66, 13);
            this.ClassNameLabel.TabIndex = 0;
            this.ClassNameLabel.Text = "Class Name:";
            // 
            // ClassDescriptionLabel
            // 
            this.ClassDescriptionLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClassDescriptionLabel.Location = new System.Drawing.Point(15, 43);
            this.ClassDescriptionLabel.Name = "ClassDescriptionLabel";
            this.ClassDescriptionLabel.Size = new System.Drawing.Size(318, 53);
            this.ClassDescriptionLabel.TabIndex = 2;
            this.ClassDescriptionLabel.Text = "Class Description:";
            // 
            // ClassCreditsLabel
            // 
            this.ClassCreditsLabel.AutoSize = true;
            this.ClassCreditsLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClassCreditsLabel.Location = new System.Drawing.Point(15, 96);
            this.ClassCreditsLabel.Name = "ClassCreditsLabel";
            this.ClassCreditsLabel.Size = new System.Drawing.Size(70, 13);
            this.ClassCreditsLabel.TabIndex = 3;
            this.ClassCreditsLabel.Text = "Class Credits:";
            // 
            // StudentMarkLabel
            // 
            this.StudentMarkLabel.AutoSize = true;
            this.StudentMarkLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StudentMarkLabel.Location = new System.Drawing.Point(15, 115);
            this.StudentMarkLabel.Name = "StudentMarkLabel";
            this.StudentMarkLabel.Size = new System.Drawing.Size(34, 13);
            this.StudentMarkLabel.TabIndex = 4;
            this.StudentMarkLabel.Text = "Mark:";
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentMarkLabel);
            this.Controls.Add(this.ClassCreditsLabel);
            this.Controls.Add(this.ClassDescriptionLabel);
            this.Controls.Add(this.ClassNameLabel);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(304, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassNameLabel;
        private System.Windows.Forms.Label ClassDescriptionLabel;
        private System.Windows.Forms.Label ClassCreditsLabel;
        private System.Windows.Forms.Label StudentMarkLabel;
    }
}
