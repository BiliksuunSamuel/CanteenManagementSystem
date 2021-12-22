﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Models
{
    internal class UserModel:ResponseModel
    {

        public string UserID { get; set; } = "";
        public string Username { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
