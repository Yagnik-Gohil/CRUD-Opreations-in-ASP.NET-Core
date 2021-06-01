using ProjectDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDI.Infrastructure
{
    public interface IStudentRepo
    {
        List<Student> GetAll();
        /*Student GetByID(int Id);*/
        List<Technology> GetTechnologyList();
        void Create(Student model);
        void Delete(Student model);
    }
}
