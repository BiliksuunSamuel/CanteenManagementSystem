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
    internal class UsersController:IUsersController
    {
        Utils utils = new Utils();
        ServerConfiguration server = new ServerConfiguration();
        UserServices services = new UserServices();
        HandleException handleException = new HandleException();
        HandlePassword handlePassword = new HandlePassword();


        /// <summary>
        /// FETCH ALL REGISTERED USERS
        /// </summary>
        /// <returns></returns>
        public Task<DataTable> AllUsers()
        {
            try
            {
                string command = "SELECT * FROM dbo.Users";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();

                return Task.Run(() => {
                    server.cmd = new SqlCommand(command, server.Connection());
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
        /// DELETE USER ACCOUNT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserModel DeleteUser(UserModel model)
        {
            try
            {
                string command = "DELETE FROM dbo.Users WHERE PhoneNumber=@phone";
                server.cmd = new SqlCommand(command,server.Connection());
                server.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = model.PhoneNumber;
                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();

                model.success = true;
                model.message = "User Account Deleted";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET USER BY ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DataTable> GetUserByID(UserModel model)
        {

            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                return Task.Run(() => {
                    string command = "SELECT * FROM dbo.Users WHERE UserID=@id";
                    server.cmd = new SqlCommand(command, server.Connection());
                    server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.UserID;
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
        /// GET USER BY PHONE NUMBER
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task<DataTable> GetUserByPhone(UserModel model)
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                string command = "SELECT * FROM dbo.Users WHERE PhoneNumber=@phone";
                return Task.Run(() => {
                    server.cmd = new SqlCommand(command, server.Connection());
                    server.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = model.PhoneNumber;
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
        /// UPDATE USER INFO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserModel UpdateUserInfo(UserModel model)
        {
            try
            {
                string command = "UPDATE dbo.Users SET Username=@username,PhoneNumber=@phone WHERE UserID=@id";
                server.cmd=new SqlCommand(command,server.Connection());
                server.cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = model.Username;
                server.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = model.PhoneNumber;
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.UserID;

                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();
                model.success = true;
                model.message = "Account Info Updated Successfully";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// HANDLE USER LOGIN
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  UserModel UserLogin(UserModel model)
        {
            try
            {
                if (!utils.TableHasData(GetUserByPhone(model).Result))
                {
                    throw handleException.HandleStack("Invalid Login Phone Number", "User Login");
                };
                UserModel UModel =services.FormatUserInfo(GetUserByPhone(model).Result);
                if (!handlePassword.VerifyPassword(model.Password, UModel.Password).Result)
                {
                    throw handleException.HandleStack(message: "Invalid Login Password", source: "User Login");
                }
                return UModel;
                
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// REGISTER USER ACCOUNT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  Task<UserModel> UserRegister(UserModel model)
        {
            try
            {
                model=services.ValidateUserInfo(model);
                model = services.GenerateUserID(model);
                while (utils.TableHasData(GetUserByID(model).Result))
                {
                    model = services.GenerateUserID(model);
                }
                if (utils.TableHasData(GetUserByPhone(model).Result))
                {
                    throw handleException.HandleStack("Phone Number Already Registered ", "User Register");
                }
                return Task.Run(() => {
                model.Password = handlePassword.HashPassword(model.Password).Result;
                string command = "INSERT INTO dbo.Users(UserID,Username,PhoneNumber,Password) VALUES(@id,@name,@phone,@pwd)";
                    server.cmd = new SqlCommand(command, server.Connection());
                    server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.UserID;
                    server.cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = model.Username;
                    server.cmd.Parameters.Add("@phone", SqlDbType.VarChar).Value = model.PhoneNumber;
                    server.cmd.Parameters.Add("@pwd", SqlDbType.VarChar).Value = model.Password;
                    server.OpenConnection();
                    server.cmd.ExecuteNonQuery();
                    server.CloseConnection();

                    model.success = true;
                    model.message = "User Registered Successfully";
                    return model;
                });
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
