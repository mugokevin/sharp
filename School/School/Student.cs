using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class Student
    {
        public string name;
        public string major;
        public int grade;

        public Student(string aName, string aMajor, int aGrade)
        {
            this.name = aName;
            this.major = aMajor;
            this.grade = aGrade;
        }

        public bool HasHonours()
        {
            if(grade >= 70)
            {
                return true;
            }
            return false;
        }
    }
}
