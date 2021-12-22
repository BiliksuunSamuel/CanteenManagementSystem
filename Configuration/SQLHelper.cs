using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CanteenManagementSystem.SoftwareConfigurations
{
    public class SQLHelper
    {
        SqlConnection con;

        public SQLHelper(string conString)
        {
            con = new SqlConnection(conString);
        }
        /// <summary>
        /// testing to see if the connection active
        /// </summary>
        public bool isConnection
        {
            get
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                return true;
            }
        }
    }
}
