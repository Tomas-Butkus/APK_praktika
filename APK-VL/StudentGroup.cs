using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK_VL
{
    public class StudentGroup
    {
        public string groupName { get; private set; }

        public StudentGroup(string groupName)
        {
            this.groupName = groupName;
        }

        public string GetStudentGroupName()
        {
            return groupName;
        }
    }
}
