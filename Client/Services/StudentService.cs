using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using AuthenticationProject.AccountService;

namespace AuthenticationProject.Services
{
    public class StudentService : IStudentService
    {
        public void Create(Student student)
        {
            using (AccountWebServiceClient client = new AccountWebServiceClient())
            {
               client.CreateStudent(student);
            }
        }

        public List<Student> GetAll(string UserID)
        {
            List<Student> result = new List<Student>();
            using (AccountWebServiceClient client = new AccountWebServiceClient())
            {
                result = client.GetAllStudentsByUsername(UserID);
            }
            return result;
        }
    }
}