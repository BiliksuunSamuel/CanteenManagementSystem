using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
namespace CanteenManagementSystem.Interface
{
    internal interface IUsersController
    {
        UserModel UserLogin(UserModel model);
        Task<UserModel> UserRegister(UserModel model);
        Task<DataTable> AllUsers();
        UserModel DeleteUser(UserModel model);
        Task<DataTable> GetUserByPhone(UserModel model);
        Task<DataTable> GetUserByID(UserModel model);
        UserModel UpdateUserInfo(UserModel model);
    }
}
