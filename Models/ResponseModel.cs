using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Models
{
    internal class ResponseModel
    {
        public bool valid { get; set; } = false;
        public bool success { get; set; } = false;
        public string message { get; set; } = "";
        public string error { get; set; } = "";

    }
}
