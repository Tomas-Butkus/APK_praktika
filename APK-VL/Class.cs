using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APK_VL
{
    public class Class
    {
        public string name;
        public string description;
        public double credits;

        public Class(string name, string description, double credits)
        {
            this.name = name;
            this.description = description;
            this.credits = credits;
        }

        public string GetClassName()
        {
            return name;
        }

        public string GetClassDescription()
        {
            return description;
        }

        public double GetClassCredits()
        {
            return credits;
        }
    }
}
