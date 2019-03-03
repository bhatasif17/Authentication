using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationProject.Services
{
    public interface IStudentService
    {
        void Create(Student student);
        List<Student> GetAll(string UserID);
    }
}