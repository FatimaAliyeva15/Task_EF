using TaskEntityFramework.Controllers;

namespace TaskEntityFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentController studentController = new StudentController();

            //studentController.AddStudent();

            //studentController.GetAllStudents();
            //studentController.GetStudent();

            studentController.DeleteStudent();

        }
    }
}
