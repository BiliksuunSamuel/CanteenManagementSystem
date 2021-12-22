using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Functions;
using System.Data;
namespace CanteenManagementSystem.Services
{
    internal class PaymentsServices
    {
        HandleException handleException = new HandleException();

        /// <summary>
        /// FORMAT PAYMENT INFO
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public PaymentModel FormatPaymentInfo(DataTable dt)
        {
            try
            {
                PaymentModel model = new PaymentModel();
                foreach (DataRow row in dt.Rows)
                {
                    model.PaymentID = row["PaymentID"].ToString();
                    model.DatePaid = row["DatePaid"].ToString();
                    model.UserID = row["UserID"].ToString();
                    model.StudentID = row["StudentID"].ToString();
                    model.AmountPaid = row["AmountPaid"].ToString();
                }
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// VALID PAYMENT INFO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PaymentModel ValidatePaymentInfo(PaymentModel model)
        {
            try
            {
                double amt = 0;
                if (model.StudentID.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Select Student", source: "Payment Info Validation");
                }
                if(!double.TryParse(model.AmountPaid,out amt)){
                    throw handleException.HandleStack(message: "Invalid Amount Entered", source: "Payment Info Validaton");
                }
                model.DatePaid = DateTime.Now.ToShortDateString();
                model.valid = true;
                model.error = "";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// GENERATE PAYMENT ID
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public PaymentModel GeneratePaymentID(PaymentModel model)
        {
            try
            {
                Random rand = new Random();
                model.PaymentID = "PID" + rand.Next(10, 99).ToString();
                return model;
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
        public PaymentModel ValidatePaymentAmount(PaymentModel model)
        {
            try
            {
                double amt = 0;
                if(!double.TryParse(model.AmountPaid,out amt))
                {
                    throw handleException.HandleStack(message: "Invalid Payment Amount", source: "Payment Amount Validation");
                }
                model.valid = true;
                model.error = "";
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// GET TOTAL PAYMENTS
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public string GetTotalPayments(DataTable table)
        {
            double total = 0;
            foreach (DataRow row in table.Rows)
            {
                total = total + double.Parse(row["Amount"].ToString());
            }
            return total.ToString();
        }
    }
}
