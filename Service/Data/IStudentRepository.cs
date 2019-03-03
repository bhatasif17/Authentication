using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Data
{
    public interface IStudentRepository
    {
        void Create(Student student);
        List<Student> GetAll(string UserID);
    }
}