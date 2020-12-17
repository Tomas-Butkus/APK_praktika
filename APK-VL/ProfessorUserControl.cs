using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APK_VL
{
    public partial class ProfessorUserControl : UserControl
    {
        private MarkRepository markRepository = new MarkRepository();
        private ClassRepository classRepository = new ClassRepository();
        private int currentUserId;
        private int currentClassId;
        public ProfessorUserControl(Class classes, int studentId)
        {
            InitializeComponent();
            currentUserId = studentId;
            currentClassId = classRepository.GetClassId(classes.name);
            ClassNameLabel.Text = classes.name;
            ClassDescriptionLabel.Text = classes.description;
            ClassCreditsLabel.Text = "Credits: " + classes.credits.ToString();
            StudentMarkLabel.Text = "Mark: " + markRepository.GetStudentMark(currentUserId, currentClassId).ToString();
        }

        private void ChangeMarkButton_Click(object sender, EventArgs e)
        {
            markRepository.ChangeStudentMark(currentUserId, currentClassId, Convert.ToDouble(ChangeMarkBox.Text));
            StudentMarkLabel.Text = "Mark: " + ChangeMarkBox.Text;
        }
    }
}