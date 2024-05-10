using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCStudentRepository.Models.Repositories
{
    public interface IStudentRepository
    {
        IEnumerable<Student> SelectAll();
        Student SelectByID(int id);
        void Insert(Student obj);
        void Update(Student obj);
        void Delete(int id);
        void Save();
    }
}