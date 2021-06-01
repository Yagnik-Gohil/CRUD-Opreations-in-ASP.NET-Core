using DataAccessLayer.Entities;
using LogicLayer.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.DataContext;
using System.Linq;
using DataAccessLayer.Repository;

namespace LogicLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IRepository _repo;

        public StudentService(IRepository repo)
        {
            _repo = repo;
        }

        public List<Student> GetAll()
        {
            return _repo.GetAll();
        }

        public List<Technology> GetTechnologyList()
        {
            return _repo.GetTechnologyList();
        }

        public void Create(Student model)
        {
            _repo.Create(model);
        }

        public void Delete(Student model)
        {
            _repo.Delete(model);
        }
    }
}
