using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCStudentRepository.Models.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private StudentDBContext db = null;

        public StudentRepository()
        {
            this.db = new StudentDBContext();
        }

        public StudentRepository(StudentDBContext db)
        {
            this.db = db;
        }

        public IEnumerable<Student> SelectAll()
        {
            return db.Students.OrderBy(a => a.Surname).ToList();
        }

        public Student SelectByID(int id)
        {
            return db.Students.Find(id);
        }

        public void Insert(Student obj)
        {
            db.Students.Add(obj);
        }

        public void Update(Student obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Student existing = db.Students.Find(id);
            db.Students.Remove(existing);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
