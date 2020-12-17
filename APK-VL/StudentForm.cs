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
    public partial class StudentForm : Form
    {
        private ClassRepository classRepository;
        private StudentRepository studentRepository;
        private StudentGroupRepository studentGroupRepository;

        public StudentForm()
        {
            InitializeComponent();
            classRepository = new ClassRepository();
            studentRepository = new StudentRepository();
            studentGroupRepository = new StudentGroupRepository();
            List<Class> classList = classRepository.GetClasses();

            FullNameLabel.Text = studentRepository.GetUserFullName(Form1.loggedInUserId);

            StudentFlowLayoutClasses.Controls.Clear();

            foreach (Class classes in classList)
            {
                if (studentGroupRepository.CheckStudentGroupClasses(Form1.loggedInUserId, classRepository.GetClassId(classes.name)) == true)
                {
                    StudentUserControl studentUserControl = new StudentUserControl(classes);
                    StudentFlowLayoutClasses.Controls.Add(studentUserControl);
                }
            }
        }
    }
}
