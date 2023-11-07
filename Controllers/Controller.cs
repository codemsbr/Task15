using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task15.Model;

namespace Task15.Controllers
{
    internal static class Controller
    {
        public static void Menu()
        {
            Console.WriteLine("1.AddExam");
            Console.WriteLine("2.PointContoller");
            Console.WriteLine("3.OneWeekController");
            Console.WriteLine("4.OneHourContoller");
            Console.WriteLine("5.Exit");
            Console.Write("User Answer : ");

        }
        public static Exam AddExam()
        {
            Student student = AddStudent();
            
            Console.Write("Enter Point : ");
            float point = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Subject : ");
            string subject = Console.ReadLine();

            Console.Write("Enter Start DateTime Time(Year,Month,Day Time) : ");
            DateTime startDate = Convert.ToDateTime(Console.ReadLine());


            Console.Write("Enter End DateTime Time(Year,Month,Day Time) : ");
            DateTime endDate = Convert.ToDateTime(Console.ReadLine());

            #region DateTime YOl 1
            //DateTime startDate = StartDateController();
            //DateTime endDate = EndDateController();
            #endregion
            
            return new Exam(student,point,subject,startDate, endDate);
        }

        public static void PointContoller(List<Exam> exams)
        {
            exams.FindAll(x => x.Point > 50).ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }

        public static void OneWeekController(List<Exam> exams)
        {
            DateTime dateTime = DateTime.Now.AddDays(-7);
            exams.FindAll(x => x.StartDate == dateTime).ForEach(x =>
            {
                Console.WriteLine(x);
            });
        }

        public static List<Exam> OneHourContoller(List<Exam> exams)
        {
          return exams.FindAll(x => x.Duration.Hour > 1);

        }
        static Student AddStudent()
        {
            Console.Write("Enter Student Name : ");
            string studentName = Console.ReadLine();

            Console.Write("Enter Student SurName : ");
            string studentSurName = Console.ReadLine();

            return new Student(studentName,studentSurName);
        }
        
        #region Yol1 DateTime
        //static DateTime StartDateController()
        //{
        //    //Console.Write("Enter StartDate Year : ");
        //    //byte StartDateYear = Convert.ToByte(Console.ReadLine());

        //    //Console.Write("Enter StartDate Month : ");
        //    //byte StartDateMonth = Convert.ToByte(Console.ReadLine());

        //    //Console.Write("Enter StartDate Day : ");
        //    //byte StartDateDay = Convert.ToByte(Console.ReadLine());

        //    //Console.Write("Enter StartDate Hours : ");
        //    //byte StartDateHours = Convert.ToByte(Console.ReadLine());

        //    //Console.Write("Enter StartDate Minute : ");
        //    //byte StartDateMinute = Convert.ToByte(Console.ReadLine());

        //    //return new DateTime(StartDateYear,StartDateMonth,StartDateDay,StartDateHours,StartDateMinute,0);
        //}

        //static DateTime EndDateController()
        //{
        //    Console.Write("Enter StartDate Year : ");
        //    byte EndDateYear = Convert.ToByte(Console.ReadLine());

        //    Console.Write("Enter StartDate Month : ");
        //    byte EndDateMonth = Convert.ToByte(Console.ReadLine());

        //    Console.Write("Enter StartDate Day : ");
        //    byte EndDateDay = Convert.ToByte(Console.ReadLine());

        //    Console.Write("Enter StartDate Hours : ");
        //    byte EndDateHours = Convert.ToByte(Console.ReadLine());

        //    Console.Write("Enter StartDate Minute : ");
        //    byte EndDateMinute = Convert.ToByte(Console.ReadLine());

        //    return new DateTime(EndDateYear, EndDateMonth, EndDateDay, EndDateHours, EndDateMinute, 0);
        //}
        #endregion
    }
}
