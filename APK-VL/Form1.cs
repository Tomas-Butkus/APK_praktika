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
    public partial class Form1 : Form
    {
        // Repositories
        public StudentRepository studentRepository = new StudentRepository();
        public ProfessorRepository professorRepository = new ProfessorRepository();
        public AdminRepository adminRepository = new AdminRepository();

        // Current user ID
        public static int loggedInUserId;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Student login
                if (studentRepository.CheckLoginCredentials(LoginUsernameBox.Text, LoginPasswordBox.Text) == true)
                {
                    loggedInUserId = studentRepository.GetUserId(LoginUsernameBox.Text, LoginPasswordBox.Text);
                    MessageBox.Show("Login Successful!");
                    StudentForm studentForm = new StudentForm();
                    studentForm.ShowDialog();
                    this.Close();
                }

                // Professor login
                else if (professorRepository.CheckLoginCredentials(LoginUsernameBox.Text, LoginPasswordBox.Text) == true)
                {
                    loggedInUserId = professorRepository.GetUserId(LoginUsernameBox.Text, LoginPasswordBox.Text);
                    MessageBox.Show("Login Successful!");
                    ProfessorForm professorForm = new ProfessorForm();
                    professorForm.ShowDialog();
                    this.Close();
                }

                // Admin login
                else if (adminRepository.CheckLoginCredentials(LoginUsernameBox.Text, LoginPasswordBox.Text) == true)
                {
                    loggedInUserId = adminRepository.GetUserId(LoginUsernameBox.Text, LoginPasswordBox.Text);
                    MessageBox.Show("Login Successful!");
                    AdministratorForm administratorForm = new AdministratorForm();
                    administratorForm.ShowDialog();
                    this.Close();
                }

                else throw new ArgumentNullException("Invalid credentials!");
            }

            catch (ArgumentNullException wrongLoginCredentials)
            {
                MessageBox.Show(wrongLoginCredentials.Message);
            }
        }
    }
}