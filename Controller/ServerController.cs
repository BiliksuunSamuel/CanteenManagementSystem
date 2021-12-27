using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CanteenManagementSystem.Configuration;
using System.Data.SqlClient;
namespace CanteenManagementSystem.Controller
{
    internal class ServerController
    {
        ServerConfiguration server = new ServerConfiguration();
        List<string> DbTables = new List<string>
        {
            "dbo.Students",
            "dbo.Payments",
            "dbo.Users",
            "dbo.Classes",
            "dbo.Fees",
            "dbo.SchoolFees",
        };

        /// <summary>
        /// GENERATE SQL COMMAND;
        /// </summary>
        /// <param name="dbname"></param>
        /// <returns></returns>
        private string GenerateSqlCommand(string dbname)
        {
            return string.Format("DELETE FROM {0}", dbname);
        }

        /// <summary>
        /// CLEAN DATABASE
        /// </summary>
        /// <returns></returns>
        public string CleanDataBase()
        {
            try
            {
                foreach (string tbname in DbTables)
                {
                    server.cmd=new SqlCommand(GenerateSqlCommand(tbname),server.Connection());
                    server.OpenConnection();
                    server.cmd.ExecuteNonQuery();
                    server.CloseConnection();
                }

                return "Database Cleaned Successfully";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
