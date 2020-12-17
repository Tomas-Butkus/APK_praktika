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
    public partial class StudentUserControl : UserControl
    {
        private MarkRepository markRepository = new MarkRepository();
        private ClassRepository classRepository = new ClassRepository();
        public StudentUserControl(Class classes)
        {
            InitializeComponent();
            ClassNameLabel.Text = classes.name;
            ClassDescriptionLabel.Text = classes.description;
            ClassCreditsLabel.Text = "Credits: " + classes.credits.ToString();
            StudentMarkLabel.Text = "Mark: " + markRepository.GetStudentMark(Form1.loggedInUserId, classRepository.GetClassId(classes.name)).ToString();
        }
    }
}
