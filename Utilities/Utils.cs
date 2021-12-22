using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace CanteenManagementSystem.Utilities
{
    internal class Utils
    {

        /// <summary>
        /// TABLE HAS DATA
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool TableHasData(DataTable dt)
        {
            bool hasData = false;
            if(dt.Rows.Count > 0)
            {
                hasData = true;
            }
            return hasData;
        }
    }
}
