using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts
{
    public interface IStudentService
    {
        void AddStudent(Student student);
        void UpdateStudent(int id, Student student);
        void DeleteStudent(int id);
        Student GetStudent(Predicate<Student>? predicate);
        List<Student> GetAllStudents(Predicate<Student>? predicate);

    }
}
