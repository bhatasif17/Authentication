using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace Service.Data
{
    public class StudentRepository : IStudentRepository
    {
        public void Create(Student student)
        {
            AppDbContext db = new AppDbContext();

            //Better to use Stored Procedures
            string query = "INSERT INTO dbo.Student (ID, Name, Address, Email, AddedBy) " +
                  "VALUES (@ID, @Name, @Address, @Email, @AddedBy) ";

            // create connection and command
            var connectionString = db.Database.Connection.ConnectionString;
            SqlConnection cn = new SqlConnection(connectionString);

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // define parameters and their values
                    cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier, 50).Value = Guid.NewGuid();
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50).Value = student.Name;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar, 50).Value = student.Address;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = student.Email;
                    cmd.Parameters.Add("@AddedBy", SqlDbType.VarChar, 50).Value = student.AddedBy;

                    // open connection if closed
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    //Execute
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                //Log Error
                throw;
            }
            catch (Exception ex)
            {
                //Log Error
                throw;
            }
            finally
            {
                cn.Close();
            }
           
        }

        public List<Student> GetAll(string UserID)
        {
            List<Student> result = new List<Student>();
            AppDbContext db = new AppDbContext();
         
            //Better to use Stored Procedures
            string query = "SELECT Name, Address, Email FROM Student WHERE AddedBy = @UserID";

            // create connection and command
            var connectionString = db.Database.Connection.ConnectionString;
            SqlConnection cn = new SqlConnection(connectionString);
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();

                    cmd.Parameters.Add("@UserID", SqlDbType.VarChar, 50).Value = UserID;

                    //execute
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.Name = reader[0].ToString();
                        student.Address = reader[1].ToString();
                        student.Email = reader[2].ToString();

                        result.Add(student);
                    }
                    //close reader
                    reader.Close();
                }
                return result;
            }
            catch(SqlException ex)
            {
                //Log error
                throw;
            }
            catch (Exception ex)
            {
                //Log Error
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}