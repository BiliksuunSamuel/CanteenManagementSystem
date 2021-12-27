using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Models
{
    internal class FeePaymentModel:ResponseModel
    {
        public string ID { get; set; }
        public string StudentID { get; set; }
        public string  ClassID { get; set; }
        public string AmountPaid { get; set; }
        public string  Arears { get; set; }
        public string  DatePaid { get; set; }
        public string ReceiptNumber { get; set; }
        public string UserID { get; set; }
    }
}
