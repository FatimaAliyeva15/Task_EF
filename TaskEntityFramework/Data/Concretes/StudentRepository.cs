using Core.Abstracts;
using Core.Models;
using Data.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concretes
{
    public class StudentRepository : IStudentRepository
    {
        AppDbContext _appDbContext;

        public StudentRepository()
        {
            _appDbContext = new AppDbContext();
        }

        public int Save()
        {
            return _appDbContext.SaveChanges();
        }

        public void Add(Student student)
        {
            _appDbContext.Students.Add(student);
        }

        public void Delete(Student student)
        {
            
            _appDbContext.Students.Remove(student);
        }

        public Student Get(Predicate<Student>? predicate)
        {
            if(predicate == null)
            {
                return _appDbContext.Students.FirstOrDefault();
            }
            else
            {
                return _appDbContext.Students.FirstOrDefault(student => predicate(student));
            }
        }

        public List<Student> GetAll(Predicate<Student>? predicate)
        {
            if( predicate == null)
            {
                return _appDbContext.Students.ToList();
            }
            else
            {
                return _appDbContext.Students.ToList().FindAll(predicate);
            }
        }
    }
}
