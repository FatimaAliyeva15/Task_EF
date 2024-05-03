using Business.Services.Abstracts;
using Business.Services.Concretes;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEntityFramework.Controllers
{
    public class StudentController
    {
        IStudentService _studentService = new StudentService();

        public void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student surname: ");
            string surname = Console.ReadLine();

            string ageStr = "";
            int age;

            do
            {
                Console.Write("Enter student age: ");
                ageStr = Console.ReadLine();
            }while(!int.TryParse(ageStr, out age));

            Student student = new Student
            {
                Name = name,
                Surname = surname,
                Age = age
            };

            _studentService.AddStudent(student);
        }

        public void DeleteStudent()
        {
            string idStr = "";
            int id;

            do
            {
                Console.Write("Enter student id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            _studentService.DeleteStudent(id);
        }

        public void UpdateStudent()
        {
            string idStr = "";
            int id;

            do
            {
                Console.Write("Enter student id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter student surname: ");
            string surname = Console.ReadLine();

            string ageStr = "";
            int age;

            do
            {
                Console.Write("Enter student age: ");
                ageStr = Console.ReadLine();
            } while (!int.TryParse(ageStr, out age));

            Student student = new Student
            {
                Name = name,
                Surname = surname,
                Age = age
            };

            _studentService.UpdateStudent(id,student);
        }

        public void GetStudent()
        {
            string idStr = "";
            int id;

            do
            {
                Console.Write("Enter student id: ");
                idStr = Console.ReadLine();
            } while (!int.TryParse(idStr, out id));

            var student = _studentService.GetStudent(x => x.Id == id);
            Console.WriteLine(student);
        }

        public void GetAllStudents()
        {
            foreach (var item in _studentService.GetAllStudents(null))
            {
                Console.WriteLine(item);
            }
        }
    }
}
