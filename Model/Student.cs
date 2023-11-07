using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15.Model
{
    internal class Student
    {
        static int id;
        public int Id { get; }
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }

        private Student()
        {
            id++;
            Id = id;
        }

        public Student(string studentName, string studentSurName):this()
        {
            StudentName = studentName;
            StudentSurName = studentSurName;
        }

        public override string ToString()
        {
            return $"StudentName : {StudentName} StudentSurName : {StudentSurName}";
        }
    }
}
