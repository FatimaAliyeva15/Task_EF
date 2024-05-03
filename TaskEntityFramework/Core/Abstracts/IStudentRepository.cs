using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstracts
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Delete(Student student);
        Student Get(Predicate<Student>? predicate);
        List<Student> GetAll(Predicate<Student>? predicate);
        int Save();
    }
}
