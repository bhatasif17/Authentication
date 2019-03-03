using DTO;
using System.Collections.Generic;
using System.Security.Claims;
using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface IAccountWebService 
    {
        [OperationContract]
        bool Create(Account user, string password);

        [OperationContract]
        IdentityLoginResult ValidateIdentityUser(string username, string password, bool shouldLockout);

        [OperationContract]
        ClaimsIdentity CreateIdentity(string userId);

        [OperationContract]
        string GetSecurityStamp(string userId);

        [OperationContract]
        bool IdentityUserExistsById(string userId);

        [OperationContract]
        bool SupportsUserSecurityStamp();


        //Student
        //we can create a separate student service and inherit that here
        [OperationContract]
        void CreateStudent(Student student);

        [OperationContract]
        List<Student> GetAllStudentsByUsername(string UserID);

    }
}
