using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK_VL
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string username;
        public string password;

        public Student(string firstName, string lastName, string username, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;

            // Check if fields are not empty
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentNullException("All of the information is required!");
            }
        }

        // Default Constructor
        public Student()
        {

        }
    }
}