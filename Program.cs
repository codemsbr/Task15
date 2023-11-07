using System.Globalization;
using Task15.Controllers;
using Task15.Model;

namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Exam> exams = new List<Exam>();
                int? userController = null;
                do
                {
                    Controller.Menu();
                    userController = Convert.ToInt32(Console.ReadLine());
                    switch (userController)
                    {
                        case 1:
                            exams.Add(Controller.AddExam());
                            break;
                        case 2:
                            Controller.PointContoller(exams);
                            break;
                        case 3:
                            Controller.OneWeekController(exams);
                            break;
                        case 4:
                            Controller.OneHourContoller(exams);
                            break;
                        case 5:
                            break;
                        default:
                            break;
                    }
                } while (userController != 5);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            };
        }
    }
}