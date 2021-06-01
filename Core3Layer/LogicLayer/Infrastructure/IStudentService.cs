using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.Infrastructure
{
    public interface IStudentService
    {
        List<Student> GetAll();
        List<Technology> GetTechnologyList();
        void Create(Student model);
        void Delete(Student model);
    }
}
