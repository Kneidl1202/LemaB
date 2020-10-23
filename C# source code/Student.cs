using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeMa_A
{
    class Student
    {
        private string name;
        private string grade;
        
        public Student()
        {
            this.name = "";
            this.grade = "1";
        }

        public Student(string name, string grade)
        {
            this.name = name;
            this.grade = grade;
        }
    }
}
