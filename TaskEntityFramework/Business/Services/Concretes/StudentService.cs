using Business.Services.Abstracts;
using Core.Abstracts;
using Core.Models;
using Data.Concretes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concretes
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository = new StudentRepository();
        public void AddStudent(Student student)
        {
           _studentRepository.Add(student);
            _studentRepository.Save();
        }

        public void DeleteStudent(int id)
        {

            var student = _studentRepository.Get(x => x.Id == id);
            if (student == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                _studentRepository.Delete(student);
                _studentRepository.Save();
            }
        }

        public Student GetStudent(Predicate<Student>? predicate)
        {
            return _studentRepository.Get(predicate);
        }

        public List<Student> GetAllStudents(Predicate<Student>? predicate)
        {
            return _studentRepository.GetAll(predicate);
        }

        public void UpdateStudent(int id, Student student)
        {
            var existStudent = _studentRepository.Get(x => x.Id == id);
            if (student == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                existStudent.Name = student.Name == "" ? existStudent.Name : student.Name;
                existStudent.Surname = student.Surname == "" ? existStudent.Surname : student.Surname;
                existStudent.Age = student.Age;

                _studentRepository.Save();
            }
        }
    }
}
