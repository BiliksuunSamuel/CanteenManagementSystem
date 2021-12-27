using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Models
{
    internal class FeesModel:ResponseModel
    {
        public string ID { get; set; }
        public string  ClassID { get; set; }
        public string Amount { get; set; }
    }
}
