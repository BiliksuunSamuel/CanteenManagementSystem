using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Functions;
namespace CanteenManagementSystem.Services
{
    internal class UserServices
    {
        HandleException handleException = new HandleException();


        /// <summary>
        /// FORMAT USER INFO
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public UserModel FormatUserInfo(DataTable dt)
        {
            try
            {
                UserModel model = new UserModel();
                foreach (DataRow row in dt.Rows)
                {
                    model.UserID = row["UserID"].ToString();
                    model.Username = row["Username"].ToString();
                    model.PhoneNumber = row["PhoneNumber"].ToString();
                    model.Password = row["Password"].ToString();
                }
                return model;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// VALIDATE USER INFO
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserModel ValidateUserInfo(UserModel model)
        {
            try
            {
                long phone = 0;
                if (model.Username.Length <= 0)
                {
                    throw handleException.HandleStack(message: "Username required ***", source: "User Info Validation");

                }
                if(!long.TryParse(model.PhoneNumber,out phone) || model.PhoneNumber.Length != 10)
                {
                    throw handleException.HandleStack("Invalid User Phone Number", source: "User Info Validation");
                }

                if(model.Password.Length <= 0)
                {
                    throw handleException.HandleStack("User Password Required **", "User Info Validation");
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
        /// GENERATE USER NAME
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserModel GenerateUserID(UserModel model)
        {
            try
            {
                var names = model.Username.Split(' ');
                foreach (string name in names)
                {
                    model.UserID =model.UserID+ name.ToCharArray()[0].ToString().ToUpper();
                }
                Random ran = new Random();
                model.UserID = model.UserID + ran.Next(7704, 9999);
                return model  ;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
