using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Functions;
namespace CanteenManagementSystem.Services
{
    internal class FeesServices
    {
        HandleException handleException = new HandleException();
        /// <summary>
        /// GENERATE FEES MODEL;
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public FeesModel GenerateFeesID(FeesModel model)
        {
            Random rand = new Random();
            model.ID = "FID" + rand.Next(7704, 9999);
            return model;
        }

        /// <summary>
        /// GENERATE FEE PAYMENT ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public FeePaymentModel GeneratePaymentID(FeePaymentModel model)
        {
            Random rand = new Random();
            model.ID = "FPID" + rand.Next(1000, 9999);
            return model;
        }


        /// <summary>
        /// FORMAT FEE MODEL
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public FeesModel FormatFeeInf(DataTable table)
        {
            try
            {
                FeesModel model = new FeesModel();
                foreach (DataRow  row in table.Rows)
                {
                    model.ID = row["ID"].ToString();
                    model.Amount = row["Amount"].ToString();
                    model.ClassID = row["ClassID"].ToString();
                }
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FeePaymentModel FormatFeePaymentInfo(DataTable table)
        {
            try
            {
                FeePaymentModel model = new FeePaymentModel();
                foreach (DataRow row in table.Rows)
                {
                    model.ID = row["ID"].ToString();
                    model.ClassID = row["ClassID"].ToString();
                    model.AmountPaid = row["AmountPaid"].ToString();
                    model.StudentID = row["StudentID"].ToString();
                    model.DatePaid = row["DatePaid"].ToString();
                    model.Arears = row["Arears"].ToString();
                    model.ReceiptNumber = row["ReceiptNumber"].ToString();
                }
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FeesModel ValidateFees(FeesModel model)
        {
            try
            {
                double validAmount = 0;
                if(!double.TryParse(model.Amount,out validAmount))
                {
                    throw handleException.HandleStack(message: "Invalid Amount", source: "Fees Validation");
                }
                if(model.ClassID==null || model.ClassID.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Please Select Class", source: "Fees Validation");
                }
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// VALIDATE FEE PAYMENT INFORMATION
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public FeePaymentModel ValidatePaymentInfo(FeePaymentModel model)
        {
            try
            {
                double validAmount = 0;
                if(!double.TryParse(model.AmountPaid,out validAmount))
                {
                    throw handleException.HandleStack(message: "Invalid Amount", source: "Fee Payment Validation");
                }

                if(model.ClassID==null || model.ClassID.Length <= 0)
                {
                   throw  handleException.HandleStack(message: "Please Select Class", source: "Fee Payment Validation");

                }

                if (model.StudentID == null || model.StudentID.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Please Select Student", source: "Fee Payment Validation");

                }
                if (model.DatePaid == null || model.DatePaid.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Please Enter DatePaid", source: "Fee Payment Validation");

                }
                if (model.ReceiptNumber == null || model.ReceiptNumber.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Please Enter Receipt Number", source: "Fee Payment Validation");
                }
                return model;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public FeePaymentModel ValidatePreparePaymentInfo(FeePaymentModel model)
        {
            try
            {
                double validAmount = 0;
                if (!double.TryParse(model.AmountPaid, out validAmount))
                {
                    throw handleException.HandleStack(message: "Invalid Amount", source: "Fee Payment Validation");
                }

                if (model.ClassID == null || model.ClassID.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Please Select Class", source: "Fee Payment Validation");

                }

                if (model.StudentID == null || model.StudentID.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Please Select Student", source: "Fee Payment Validation");

                }
                if (model.DatePaid == null || model.DatePaid.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Please Enter DatePaid", source: "Fee Payment Validation");

                }
                return model;

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GET FEES INFO FROM THE DATA GRID
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public FeesModel GetFeesInfoFromTable(DataRow row)
        {
            try
            {
                FeesModel model = new FeesModel();
                model.ID = row["ID"].ToString();
                model.ClassID = row["Class"].ToString();
                model.Amount = row["Amount"].ToString();
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FeePaymentModel GetFeesPaymentInfoFromTable(DataRow row)
        {
            try
            {
                FeePaymentModel model = new FeePaymentModel();
                model.ID = row["PaymentID"].ToString();
                model.ClassID = row["ClassID"].ToString();
                model.StudentID = row["StudentID"].ToString();
                model.DatePaid = row["DatePaid"].ToString();
                model.UserID = row["UserID"].ToString();
                model.Arears = row["Arears"].ToString();

                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string GetAreas(DataTable tb)
        {
            double arears = 0;
            if (tb.Rows.Count > 0)
            {
                foreach (DataRow row in tb.Rows)
                {
                    arears = arears + double.Parse(row["Arears"].ToString());
                }
            }
            return arears.ToString();
        }
        public string GetAmountPaid(DataTable tb)
        {
            double amountPaid = 0;
            if (tb.Rows.Count > 0)
            {
                foreach (DataRow row in tb.Rows)
                {
                    amountPaid = amountPaid + double.Parse(row["AmountPaid"].ToString());
                }
            }
            return amountPaid.ToString();
        }
    }
}
