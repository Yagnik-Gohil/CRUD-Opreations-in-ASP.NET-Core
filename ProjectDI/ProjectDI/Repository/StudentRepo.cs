using Microsoft.EntityFrameworkCore;
using ProjectDI.Infrastructure;
using ProjectDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDI.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentContext dbObj;

        public StudentRepo(StudentContext dbObj)
        {
            this.dbObj = dbObj;
        }

        public List<Student> GetAll()
        {
            return dbObj.Student.ToList();
        }

        /*public Student GetByID(int ID)
        {
            return dbObj.Student.FirstOrDefault(x => x.ID == ID);
        }*/
        public List<Technology> GetTechnologyList()
        {
            return dbObj.Technology.ToList();
        }

        public void Create(Student model)
        {
            try
            {
                if (model.ID == 0)
                {
                    dbObj.Add(model);
                    dbObj.SaveChanges();
                }
                else
                {

                    dbObj.Entry(model).State = EntityState.Modified;
                    dbObj.SaveChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Delete(Student model)
        {
            try
            {
                var obj = dbObj.Student.Find(model.ID);
                if (obj != null)
                {
                    dbObj.Student.Remove(obj);
                    dbObj.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
