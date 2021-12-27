using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
namespace CanteenManagementSystem.Interface
{
    internal interface IFeesController
    {
        Task<DataTable> GetFees();
        Task<DataTable> GetPaidFees();
        Task<DataTable>GetFeesByClass(FeesModel model);
        Task<DataTable>GetFeesByID(FeesModel model);
        Task<DataTable> GetPaidFeesByClass(FeePaymentModel model);
        Task<DataTable> GetPaidFeesByID(FeePaymentModel model);
        Task<DataTable> GetPaidFeesByDate(FeePaymentModel model);
        Task<DataTable> GetStudentFees(FeePaymentModel model);
        Task<FeesModel> SaveFees(FeesModel model);
        Task<DataTable> GetFeePaymentByReceiptNumber(FeePaymentModel model);
        Task<FeePaymentModel> SaveFeePayment(FeePaymentModel model);
        Task<FeePaymentModel> UpdateStudentArears(FeePaymentModel model);
        Task<FeePaymentModel> InitializeFees(FeePaymentModel model);
        Task<FeesModel> UpdateFeesInfo(FeesModel model);
        Task<FeePaymentModel> UpdatePaymentInfo(FeePaymentModel model);
    }
}
