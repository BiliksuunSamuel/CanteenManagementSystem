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
    internal class ClassController:IClassController
    {
        Utils utils = new Utils();
        ServerConfiguration server = new ServerConfiguration();
        ClassServices services = new ClassServices();
        HandleException handleException = new HandleException();


        /// <summary>
        /// ADD CLASS
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<ClassModel> AddClass(ClassModel model)
        {
            try
            {
                model = services.ValidateClassInfo(model);
                model = services.GenerateClassID(model);

                while (utils.TableHasData( GetClassByID(model).Result))
                {
                    model=services.GenerateClassID(model);
                }

                if (utils.TableHasData(GetClassByTitle(model).Result))
                {
                    throw handleException.HandleStack(message: "Class Title or Name Already Taken", source: "Class Controller");
                }

                string cmd = "INSERT INTO dbo.Classes(ClassID,ClassTitle) VALUES(@cid,@ct)";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.cmd.Parameters.Add("@ct", SqlDbType.VarChar).Value = model.ClassTitle;

                return Task.Run(() => {
                    server.OpenConnection();
                    server.cmd.ExecuteNonQuery();
                    server.CloseConnection();
                    model.success = true;
                    model.message = "Class Added";
                    return model;
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET CLASS BY CLASS ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  Task<DataTable> GetClassByID(ClassModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string cmd = "SELECT * FROM dbo.Classes WHERE ClassID=@cid";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                return Task.Run(() => {
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
        /// GET CLASS BY CLASS TITLE
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DataTable> GetClassByTitle(ClassModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string cmd = "SELECT * FROM dbo.Classes WHERE ClassTitle=@title";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = model.ClassTitle;

                return Task.Run(() => {
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
        /// GET ALL CLASSES
        /// </summary>
        /// <returns></returns>
        public  Task<DataTable> GetClasses()
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();

                string cmd = "SELECT * FROM dbo.Classes";
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
        /// DELETE SINGLE CLASS
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ClassModel RemoveClass(ClassModel model)
        {

            try
            {
                string cmd = "DELETE FROM dbo.Classes WHERE ClassID=@cid";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();
                model.success = true;
                model.message = "Class Removed Successfully";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// UPDATE CLASS TITLE
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ClassModel UpdateClassTitle(ClassModel model)
        {
            try
            {
                if (GetClassByTitle(model).Result.Rows.Count > 0)
                {
                    throw handleException.HandleStack("Class Title Exist", "Class Update");
                }
                string cmd = "UPDATE dbo.Classes SET ClassTitle=@ct WHERE ClassID=@cid";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@ct", SqlDbType.VarChar).Value = model.ClassTitle;
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();
                model.success = true;
                model.message = "Class Updated Successfuuly";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
