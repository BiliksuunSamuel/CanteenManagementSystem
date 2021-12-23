using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenManagementSystem.Models;
namespace CanteenManagementSystem.State
{
    internal class UserState
    {
        public static UserModel UserInfo { get; set; } = null;

        public void SetState(UserModel model)
        {
            UserInfo= model;
        }

        public UserModel GetState()
        {
            return UserInfo;
        }
    }
}
