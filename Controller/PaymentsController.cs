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
    internal class PaymentsController:IPaymentsController
    {
        Utils utils = new Utils();
        ServerConfiguration server = new ServerConfiguration();
        PaymentsServices  services = new PaymentsServices();
        HandleException handleException = new HandleException();


        /// <summary>
        /// SAVE PAYMENT DETAILS
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PaymentModel AddPayment(PaymentModel model)
        {
            try
            {
                model = services.ValidatePaymentInfo(model);
                model = services.GeneratePaymentID(model);
                while (utils.TableHasData(GetPaymentByID(model)))
                {
                    model = services.GeneratePaymentID(model);
                }

                string cmd = "INSERT INTO dbo.Payments(PaymentID,StudentID,AmountPaid,DatePaid,UserID,ClassID) VALUES(@pid,@sid,@ap,@dp,@uid,@cid)";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = model.PaymentID;
                server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
                server.cmd.Parameters.Add("@ap", SqlDbType.VarChar).Value = model.AmountPaid;
                server.cmd.Parameters.Add("@dp", SqlDbType.VarChar).Value = model.DatePaid;
                server.cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = model.UserID;
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;

                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();

                model.success = true;
                model.message = "Payment Saved";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// GET PAYMENTS BY ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataTable GetPaymentByID(PaymentModel model)
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                String cmd = "SELECT * FROM dbo.Payments WHERE PaymentID=@pid";
                server.cmd=new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = model.PaymentID;
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
        /// GET ALL PAYMENTS
        /// </summary>
        /// <returns></returns>
        public  Task<DataTable> GetPayments()
        {
            try
            {
                string cmd = "SELECT * FROM dbo.Payments";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();

                return  Task.Run(() =>
                {
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
        /// GET PAYMENTS BY CLASS
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  Task<DataTable> GetPaymentsByClass(PaymentModel model)
        {
            try
            {
                string cmd = "SELECT * FROM dbo.Payments WHERE ClassID=@cid";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();

                return Task.Run(() =>
                {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.OpenConnection();
                    server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
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
        /// GET PAYMENT BY DATE PAID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  Task<DataTable> GetPaymentsByDate(PaymentModel model)
        {
            try
            {
                string cmd = "SELECT * FROM dbo.Payments WHERE DatePaid=@dp";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();

                return Task.Run(() =>
                {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.OpenConnection();
                    server.cmd.Parameters.Add("@dp", SqlDbType.VarChar).Value = model.DatePaid;
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
        /// GET PAYMENTS BY STUDENT ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public  Task<DataTable> GetStudentPayments(PaymentModel model)
        {
            try
            {
                string cmd = "SELECT * FROM dbo.Payments WHERE StudentID=@sid";
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();

                return Task.Run(() =>
                {
                    server.cmd = new SqlCommand(cmd, server.Connection());
                    server.OpenConnection();
                    server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
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
        /// UPDATE PAYMENT AMOUNT
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PaymentModel UpdatePaymentAmount(PaymentModel model)
        {
            try
            {
                model=services.ValidatePaymentAmount(model);
                string cmd = "UPDATE dbo.Payments SET AmountPaid=@ap WHERE PaymentID=@pid";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@ap", SqlDbType.VarChar).Value = model.AmountPaid;
                server.cmd.Parameters.Add("@pid", SqlDbType.VarChar).Value = model.PaymentID;

                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();
                
                model.success= true;
                model.message = "Payment Info Updated";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// FETCH ALL PAYMENTS
        /// </summary>
        /// <returns></returns>
        public Task<DataTable> FetchPayments()
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                string cmd = "SELECT Students.StudentName AS Name,Classes.ClassTitle AS Class, Payments.DatePaid AS Date,Payments.AmountPaid AS Amount FROM Payments INNER JOIN Students ON Students.StudentID = Payments.StudentID INNER JOIN Classes ON Classes.ClassID = Payments.ClassID;";
                server.cmd = new SqlCommand(cmd, server.Connection());
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
        /// GET PAYMENTS BY CLASS
        /// </summary>
        /// <param name="mod"></param>
        /// <returns></returns>
        public Task<DataTable> FilterPaymentsByClass(ClassModel mod)
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                string cmd = "SELECT Students.StudentName AS Name,Classes.ClassTitle AS Class, Payments.DatePaid AS Date,Payments.AmountPaid AS Amount FROM Payments INNER JOIN Students ON Students.StudentID = Payments.StudentID INNER JOIN Classes ON Classes.ClassID = Payments.ClassID WHERE dbo.Classes.ClassID=@cid;";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = mod.ClassID;
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
        /// GET PAYMENTS BY DATE PAID
        /// </summary>
        /// <param name="dp"></param>
        /// <returns></returns>
        public Task<DataTable> FilterPaymentsByDate(string dp)
        {
            try
            {
                server.da = new SqlDataAdapter();
                server.dt = new DataTable();
                string cmd = "SELECT Students.StudentName AS Name,Classes.ClassTitle AS Class, Payments.DatePaid AS Date,Payments.AmountPaid AS Amount FROM Payments INNER JOIN Students ON Students.StudentID = Payments.StudentID INNER JOIN Classes ON Classes.ClassID = Payments.ClassID WHERE dbo.Payments.DatePaid=@dp;";
                server.cmd = new SqlCommand(cmd, server.Connection());
                server.cmd.Parameters.Add("@dp", SqlDbType.VarChar).Value = dp;
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
    }
}
