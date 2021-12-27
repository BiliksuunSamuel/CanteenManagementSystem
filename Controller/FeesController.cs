using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenManagementSystem.Services;
using CanteenManagementSystem.Controller;
using System.Data;
using CanteenManagementSystem.Interface;
using CanteenManagementSystem.Configuration;
using CanteenManagementSystem.Models;
using System.Data.SqlClient;
using CanteenManagementSystem.Utilities;
using CanteenManagementSystem.Functions;
namespace CanteenManagementSystem.Controller
{
    internal class FeesController : IFeesController
    {
        ServerConfiguration server = new ServerConfiguration();
        FeesServices services = new FeesServices();
        Utils utils = new Utils();
        HandleException handleEx = new HandleException();
        public Task<DataTable> GetFees()
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT Fees.ID, Fees.Amount,Classes.ClassTitle AS Class FROM dbo.Fees INNER JOIN Classes ON Classes.ClassID=Fees.ClassID";
                server.cmd = new SqlCommand(command, server.Connection());
                return Task.Run(() =>
                {
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

        public Task<DataTable> GetFeesByClass(FeesModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT Fees.Amount,Fees.ID,Classes.ClassTitle AS Class FROM dbo.Fees INNER JOIN Classes ON Classes.ClassID=Fees.ClassID WHERE Fees.ClassID=@cid";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                return Task.Run(() =>
                {
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
        public Task<DataTable> GetFeesByID(FeesModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT Fees.Amount,Fees.ID,Classes.ClassTitle AS Class FROM dbo.Fees INNER JOIN Classes ON Classes.ClassID=Fees.ClassID WHERE Fees.ID=@id";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.ClassID;
                return Task.Run(() =>
                {
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

        public Task<DataTable> GetPaidFees()
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT SchoolFees.ID,SchoolFees.ReceiptNumber,dbo.Students.StudentName AS Name,SchoolFees.AmountPaid,SchoolFees.Arears,Classes.ClassTitle AS Class FROM dbo.SchoolFees INNER JOIN Classes ON Classes.ClassID=SchoolFees.ClassID INNER JOIN Students ON Students.StudentID=SchoolFees.StudentID";
                server.cmd = new SqlCommand(command, server.Connection());
                return Task.Run(() =>
                {
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

        public Task<DataTable> GetPaidFeesByClass(FeePaymentModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT SchoolFees.ID,SchoolFees.ReceiptNumber,SchoolFees.AmountPaid,SchoolFees.Arears,Classes.ClassTitle AS Class FROM dbo.SchoolFees INNER JOIN Classes ON Classes.ClassID=Fees.ClassID WHERE dbo.SchoolFees.ClassID=@cid";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                return Task.Run(() =>
                {
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

        public Task<DataTable> GetPaidFeesByID(FeePaymentModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT * FROM SchoolFees WHERE ID=@id";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.ID;
                return Task.Run(() =>
                {
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

        public Task<DataTable> GetPaidFeesByDate(FeePaymentModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT * FROM SchoolFees WHERE (DatePaid=@dp AND ClassID=@cid)";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@dp", SqlDbType.VarChar).Value = model.DatePaid;
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                return Task.Run(() =>
                {
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

        public Task<DataTable> GetStudentFees(FeePaymentModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT SchoolFees.ID,SchoolFees.ReceiptNumber,Students.StudentName,SchoolFees.AmountPaid,SchoolFees.Arears,Classes.ClassTitle AS Class FROM dbo.SchoolFees INNER JOIN Classes ON Classes.ClassID=SchoolFees.ClassID INNER JOIN Students ON Students.StudentID=SchoolFees.StudentID WHERE dbo.SchoolFees.StudentID=@sid";

                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
                return Task.Run(() =>
                {
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

        public Task<FeePaymentModel> InitializeFees(FeePaymentModel model)
        {
            try
            {
                model=services.ValidatePreparePaymentInfo(model);
                model = services.GeneratePaymentID(model);
                while (utils.TableHasData(GetPaidFeesByID(model).Result)){
                    model = services.GeneratePaymentID(model);
                }
                string command = "INSERT INTO dbo.SchoolFees(ID,StudentID,AmountPaid,Arears,ClassID,DatePaid) VALUES(@id,@sid,@ap,@ar,@cid,@dp)";
                server.cmd=new SqlCommand(command,server.Connection());
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.ID;
                server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
                server.cmd.Parameters.Add("@ap", SqlDbType.VarChar).Value = model.AmountPaid;
                server.cmd.Parameters.Add("@ar", SqlDbType.VarChar).Value = model.Arears;
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.cmd.Parameters.Add("@dp", SqlDbType.VarChar).Value = model.DatePaid;
                return Task.Run(() => {
                    server.OpenConnection();
                    server.cmd.ExecuteNonQuery();
                    server.CloseConnection();
                    model.success = true;
                    model.message = "School Fees Initiated Successfully";
                    return model;
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<FeePaymentModel> SaveFeePayment(FeePaymentModel model)
        {
            model = services.ValidatePaymentInfo(model);
            model = services.GeneratePaymentID(model);
            while (utils.TableHasData(GetPaidFeesByID(model).Result))
            {
                model = services.GeneratePaymentID(model);
            }
            if (utils.TableHasData(GetFeePaymentByReceiptNumber(model).Result))
            {
                throw handleEx.HandleStack("Receipt Already Used", "School Fees Payment");
            }
            FeePaymentModel fm = UpdateStudentArears(model).Result;
            model.Arears = (double.Parse(model.Arears) - double.Parse(model.AmountPaid)).ToString();
            string command = "INSERT INTO dbo.SchoolFees(ID,ReceiptNumber,StudentID,AmountPaid,Arears,ClassID,DatePaid,UserID) VALUES(@id,@rn,@sid,@ap,@ar,@cid,@dp,@uid)";
            server.cmd = new SqlCommand(command, server.Connection());
            server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.ID;
            server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
            server.cmd.Parameters.Add("@ap", SqlDbType.VarChar).Value = model.AmountPaid;
            server.cmd.Parameters.Add("@ar", SqlDbType.VarChar).Value = model.Arears;
            server.cmd.Parameters.Add("@dp", SqlDbType.VarChar).Value = model.DatePaid;
            server.cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = model.UserID;
            server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
            server.cmd.Parameters.Add("@rn", SqlDbType.VarChar).Value = model.ReceiptNumber;
            return Task.Run(() => {
                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();
                model.success = true;
                model.message = "Payment Successfully";
                return model;
            });
        }
        public Task<DataTable> GetFeePaymentByReceiptNumber(FeePaymentModel model)
        {
            try
            {
                server.dt = new DataTable();
                server.da = new SqlDataAdapter();
                string command = "SELECT * FROM SchoolFees WHERE ReceiptNumber=@rn";
                server.cmd = new SqlCommand(command,server.Connection());
                server.cmd.Parameters.Add("@rn", SqlDbType.VarChar).Value = model.ReceiptNumber;
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

        public Task<FeePaymentModel> UpdateStudentArears(FeePaymentModel model)
        {
            string command = "UPDATE SchoolFees SET Arears=@ar WHERE StudentID=@sid";
            server.cmd = new SqlCommand(command, server.Connection());
            server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
            server.cmd.Parameters.Add("@ar", SqlDbType.VarChar).Value =0;
            return Task.Run(() => {
                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();
                model.success = true;
                model.message = "Areas Updated";
                return model;
            });
        }

        public Task<FeesModel> SaveFees(FeesModel model)
        {
            try
            {
                if (utils.TableHasData(GetFeesByClass(model).Result))
                {
                    throw handleEx.HandleStack(message: "Class Fee Already Exist", source: "School Fees");
                }
                model = services.ValidateFees(model);
                model = services.GenerateFeesID(model);
                while (utils.TableHasData(GetFeesByID(model).Result))
                {
                    services.GenerateFeesID(model);
                }
                string command = "INSERT INTO dbo.Fees(ID,ClassID,Amount) VALUES(@id,@cid,@am)";
                server.cmd = new SqlCommand(command, server.Connection());
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.ID;
                server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
                server.cmd.Parameters.Add("@am", SqlDbType.VarChar).Value = model.Amount ;
                return Task.Run(() => {

                    server.OpenConnection();
                    server.cmd.ExecuteNonQuery();
                    server.CloseConnection();
                    model.success = true;
                    model.message = "Fees Added";
                    return model;
                });
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<FeesModel> UpdateFeesInfo(FeesModel model)
        {
            try
            {
                string command = "UPDATE dbo.Fees SET Amount=@amt WHERE ID=@id";
                server.cmd=new SqlCommand(command,server.Connection());
                server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.ID;
                server.cmd.Parameters.Add("@amt", SqlDbType.VarChar).Value = model.Amount;
                return Task.Run(() => {
                    server.OpenConnection();
                    server.cmd.ExecuteNonQuery();
                    server.CloseConnection();
                    model.success = true;
                    model.message = "Fee Updated Successfully";
                    return model;
                });

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<FeePaymentModel> UpdatePaymentInfo(FeePaymentModel model)
        {
            string command = "UPDATE dbo.SchoolFees SET ReceiptNumber=@rn StudentID=@sid AmountPaid=@ap Arears=@ar DatePaid=@dp ClassID=@cid UserID=@uid WHERE SchoolFees.ID=@id";
            server.cmd = new SqlCommand(command, server.Connection());
            server.cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = model.ID;
            server.cmd.Parameters.Add("@sid", SqlDbType.VarChar).Value = model.StudentID;
            server.cmd.Parameters.Add("@ap", SqlDbType.VarChar).Value = model.AmountPaid;
            server.cmd.Parameters.Add("@ar", SqlDbType.VarChar).Value = model.Arears;
            server.cmd.Parameters.Add("@dp", SqlDbType.VarChar).Value = model.DatePaid;
            server.cmd.Parameters.Add("@uid", SqlDbType.VarChar).Value = model.UserID;
            server.cmd.Parameters.Add("@cid", SqlDbType.VarChar).Value = model.ClassID;
            server.cmd.Parameters.Add("@rn", SqlDbType.VarChar).Value = model.ReceiptNumber;
            return Task.Run(() => {
                server.OpenConnection();
                server.cmd.ExecuteNonQuery();
                server.CloseConnection();
                model.success = true;
                model.message = "Payment Successfully";
                return model;
            });
        }
    }
}
