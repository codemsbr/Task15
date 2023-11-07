using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15.Model
{
    internal class Exam
    {
        DateTime duration;
        public Student Student { get; set; }
        public float Point { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Duration ne etdiyin tam basa dusmedim ona gore.Bu Cur Duration yazdim
        public DateTime Duration { 
            get
            {
               return duration;
            } private set 
            {
                duration = (EndDate - StartDate).TotalMinutes > 0 ? new DateTime() + (EndDate - StartDate) : new DateTime() + (StartDate - EndDate);
            } 
        }

        public Exam(Student student, float point, string subject, DateTime startDate, DateTime endDate)
        {
            Student = student;
            Point = point;
            Subject = subject;
            StartDate = startDate;
            EndDate = endDate;
        }

        public override string ToString()
        {
            return $"{Student} {Subject} {Point} {Duration}";
        }
    }
}
