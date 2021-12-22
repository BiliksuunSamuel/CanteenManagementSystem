using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
namespace CanteenManagementSystem.Interface
{
    internal interface IPaymentsController
    {
        PaymentModel AddPayment(PaymentModel model);
        Task<DataTable> GetPayments();
        Task<DataTable> GetPaymentsByDate(PaymentModel model);
        Task<DataTable> GetPaymentsByClass(PaymentModel model);
        Task<DataTable>GetStudentPayments(PaymentModel model);
        PaymentModel UpdatePaymentAmount(PaymentModel model);
        DataTable GetPaymentByID(PaymentModel model);
        Task<DataTable> FetchPayments();
        Task<DataTable> FilterPaymentsByClass(ClassModel mod);
        Task<DataTable> FilterPaymentsByDate(string dp);
    }
}
