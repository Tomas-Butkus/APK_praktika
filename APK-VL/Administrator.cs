using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK_VL
{
    public class Administrator : Professor
    {
        public Administrator(string firstName, string lastName, string username, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
        }
    }
}