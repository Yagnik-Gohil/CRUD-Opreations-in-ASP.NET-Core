using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository
{
    public interface IRepository
    {
        List<Student> GetAll();
        List<Technology> GetTechnologyList();
        void Create(Student model);
        void Delete(Student model);
    }
}
