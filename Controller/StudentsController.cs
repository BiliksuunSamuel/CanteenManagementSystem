using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Services;
using CanteenManagementSystem.Configuration;
using CanteenManagementSystem.Functions;
using CanteenManagementSystem.Interface;
using CanteenManagementSystem.Utilities;
namespace CanteenManagementSystem.Controller
{
    internal class StudentsController:IStudentsController
    {
        Utils utils = new Utils();
        ServerConfiguration server = new ServerConfiguration();
        StudentsServices services = new StudentsServices();
        HandleException handleException = new HandleException();
       


        /// <summary>
        /// DELETE STUDENT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public StudentsModel DeleteStudent(StudentsModel model)
        {
            try
            {
                string command = "DELETE FROM dbo.Students WHERE StudentID=@id";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.StudentID;
                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();

                model.success = true;
                model.message = "Student Removed Successfully";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET STUDENT BY ID
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public DataTable GetStudentByID(StudentsModel student)
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                string command = "SELECT * FROM dbo.Students WHERE StudentID=@id";
                server.cmd=new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = student.StudentID;

                server.OpenConnection();
                server.da.SelectCommand = server.cmd;
                server.da.Fill(server.dt);
                server.CloseConnection();

                return server.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET STUDENT BY PHONE NUMBER
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable GetStudentByPhone(StudentsModel model)
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                string command = "SELECT * FROM dbo.Students WHERE Contact=@phone";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = model.StudentID;

                server.OpenConnection();
                server.da.SelectCommand = server.cmd;
                server.da.Fill(server.dt);
                server.CloseConnection();

                return server.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET STUDENT BY NAME
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable GetStudentByName(StudentsModel model)
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                string command = "SELECT * FROM dbo.Students WHERE StudentName=@name";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = model.StudentName;

                server.OpenConnection();
                server.da.SelectCommand = server.cmd;
                server.da.Fill(server.dt);
                server.CloseConnection();

                return server.dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET ALL STUDENTS
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<DataTable> GetStudents()
        {
            try
            {
                string cmd = "SELECT * FROM dbo.Students";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                return Task.Run(() => {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.OpenConnection();
                    server.da.SelectCommand = server.cmd;
                    server.da.Fill(server.dt);
                    server.CloseConnection();
                    return server.dt;
                });
               


            }
            catch (Exception)
            {

                throw;
            }   
        }

        /// <summary>
        /// GET REGISTERED STUDENTS
        /// </summary>
        /// <returns></returns>
        public Task<DataTable> GetRegisteredStudents()
        {
            try
            {
                string cmd = "SELECT Students.StudentName AS Name,Students.Contact,Students.Gender,Classes.ClassTitle AS Class FROM dbo.Students INNER JOIN dbo.Classes ON Classes.ClassID=Students.ClassID";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                return Task.Run(() => {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.OpenConnection();
                    server.da.SelectCommand = server.cmd;
                    server.da.Fill(server.dt);
                    server.CloseConnection();
                    return server.dt;
                });



            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// FILTER STUDENTS BY CLASS
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DataTable> FilterStudentsByClass(ClassModel model)
        {
            try
            {
                string cmd = "SELECT Students.StudentName AS Name,Students.Contact,Students.Gender,Classes.ClassTitle AS Class FROM dbo.Students INNER JOIN dbo.Classes ON Classes.ClassID=Students.ClassID WHERE dbo.Classes.ClassID=@cid";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                return Task.Run(() => {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                    server.OpenConnection();
                    server.da.SelectCommand = server.cmd;
                    server.da.Fill(server.dt);
                    server.CloseConnection();
                    return server.dt;
                });



            }
            catch (Exception)
            {

                throw;
            }

        }



        /// <summary>
        /// GET STUDENTS BY CLASS
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DataTable> GetStudentsByClass(StudentsModel model)
        {
            try
            {
                string cmd = "SELECT * FROM dbo.Students WHERE ClassID=@cid";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                return Task.Run(() => {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                    server.OpenConnection();
                    server.da.SelectCommand = server.cmd;
                    server.da.Fill(server.dt);
                    server.CloseConnection();
                    return server.dt;
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET STUDENTS BY GENDER
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  Task<DataTable> GetStudentsByGender(StudentsModel model)
        {
            try
            {
                string cmd = "SELECT * FROM dbo.Students WHERE Gender=@gender";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                return Task.Run(() => {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = model.ClassID;
                    server.OpenConnection();
                    server.da.SelectCommand = server.cmd;
                    server.da.Fill(server.dt);
                    server.CloseConnection();
                    return server.dt;

                });
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// REGISTER STUDENT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public StudentsModel RegisterStudent(StudentsModel model)
        {
            try
            {
                model = services.ValidateStudentInfo(model);
                model = services.GenerateStudentID(model);
                while (utils.TableHasData(GetStudentByID(model)))
                {
                    model = services.GenerateStudentID(model);
                }
                while (utils.TableHasData(GetStudentByName(model)))
                {
                    throw handleException.HandleStack(message: "Student Name Already Taken", source: "Student Controller");
                }
                ///

                string cmd = "INSERT INTO dbo.Students(StudentID,StudentName,ClassID,Contact,Gender) VALUES(@sid,@name,@cid,@contact,@gender)";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
                server.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = model.StudentName;
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = model.Contact;
                server.cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = model.Gender;

                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();

                model.success = true;
                model.message = "Student Added Successfully";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// UPDATE STUDENT INFO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public StudentsModel UpdateStudentInfo(StudentsModel model)
        {
            try
            {
                string cmd = "UPDATE dbo.Students SET StudentName=@name,Contact=@contact,ClassID=@cid WHERE StudentID=@sid";
                server.cmd=new SqlCommand(cmd,server.Connection());
                server.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = model.StudentName;
                server.cmd.Parameters.Add("@contact", SqlDbType.VarChar).Value = model.Contact;
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;

                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();

                model.success = true;
                model.message = "Student Info Updated";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// UPDATE STUDENT CLASS
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public StudentsModel UpdateStudentClass(StudentsModel model)
        {
            try
            {
                string cmd = "UPDATE dbo.Students SET ClassID=@cid WHERE StudentID=@sid";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;

                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();

                model.success = true;
                model.message = "Student Info Updated";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// SEARCH STUDENTS 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        public DataTable SearchStudent(string filter)
        {
            try
            {
                string cmd = "SELECT Students.StudentName AS Name,Students.Contact,Students.Gender,Classes.ClassTitle AS Class FROM dbo.Students INNER JOIN dbo.Classes ON Classes.ClassID=Students.ClassID WHERE (dbo.Students.Contact=@filter OR dbo.Students.StudentName=@filter OR dbo.Students.Gender=@filter)";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@filter", SqlDbType.VarChar).Value = filter;
                server.OpenConnection();
                server.da.SelectCommand = server.cmd;
                server.da.Fill(server.dt);
                server.CloseConnection();
                return server.dt;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
