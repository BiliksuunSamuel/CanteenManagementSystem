using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Models
{
    internal class PaymentModel:ResponseModel
    {
        public string PaymentID { get; set; } = "";
        public string DatePaid { get; set; } = "";
        public string StudentID { get; set; } = "";
        public string AmountPaid { get; set; } = "";
        public string UserID { get; set; } = "";
        public string ClassID { get; set; } = "";

    }
}
