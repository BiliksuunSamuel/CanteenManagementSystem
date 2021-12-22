using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanteenManagementSystem.Functions
{
    internal class HandleException
    {

        /// <summary>
        /// HANDLE EXCEPTION
        /// </summary>
        /// <param name="message"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public Exception HandleStack(string message="",string source = "")
        {
            Exception ex=new Exception(message);
            ex.Source= source;
            return ex;
        }
    }
}
