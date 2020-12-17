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
    public partial class ProfessorForm : Form
    {
        private StudentRepository studentRepository;
        private ClassRepository classRepository;
        private StudentGroupRepository studentGroupRepository;

        public ProfessorForm()
        {
            InitializeComponent();

            studentRepository = new StudentRepository();
            classRepository = new ClassRepository();
            studentGroupRepository = new StudentGroupRepository();
            List<Student> studentsList = studentRepository.GetAllStudents();

            int width = ProfessorStudentsFlowLayout.Width;
            foreach (Student student in studentsList)
            {
                Button studentButton = new Button();
                studentButton.Text = student.firstName;
                studentButton.Width = width - 5;
                studentButton.Tag = student;
                studentButton.Click += StudentButton_Click;
                ProfessorStudentsFlowLayout.Controls.Add(studentButton);
            }
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            StudentMarkLayout.Controls.Clear();
            Button button = (Button)sender;
            Student student = (Student)button.Tag;
            List<Class> classList = classRepository.GetClasses();

            foreach (Class classes in classList)
            {
                if (studentGroupRepository.CheckStudentGroupClasses(studentRepository.GetStudentId(student.firstName, student.lastName), classRepository.GetClassId(classes.name)) == true)
                {
                    ProfessorUserControl suc = new ProfessorUserControl(classes, studentRepository.GetStudentId(student.firstName, student.lastName));
                    StudentMarkLayout.Controls.Add(suc);
                }
            }
        }
    }
}
