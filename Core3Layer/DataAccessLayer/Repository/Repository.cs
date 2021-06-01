using DataAccessLayer.DataContext;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class Repository : IRepository
    {
        private readonly DatabaseContext dbObj;

        public Repository(DatabaseContext dbObj)
        {
            this.dbObj = dbObj;
        }
        public List<Student> GetAll()
        {
            return dbObj.Student.ToList();
        }
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
