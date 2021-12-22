using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrypt;
namespace CanteenManagementSystem.Functions
{
    internal class HandlePassword
    {


        /// <summary>
        /// HASH USER ACCOUNT PASSWORD;
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public  Task<string> HashPassword(string password = "")
        {
            try
            {
                string hpassword = "";
                ScryptEncoder encoder = new ScryptEncoder();
                return Task.Run(() =>
                {
                    hpassword=encoder.Encode(password);
                return hpassword;
                } );
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// VERIFY ACCOUNT PASSWORD
        /// </summary>
        /// <param name="password"></param>
        /// <param name="hpassword"></param>
        /// <returns></returns>
        public  Task<bool> VerifyPassword(string password ="",string hpassword = "")
        {
            try
            {
                ScryptEncoder encoder = new ScryptEncoder();
                bool match = false;
                return Task.Run(() => { match=encoder.Compare(password,hpassword); return match; });
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
