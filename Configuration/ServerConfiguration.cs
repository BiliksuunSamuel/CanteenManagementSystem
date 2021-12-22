using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CanteenManagementSystem.Configuration
{
    public class ServerConfiguration
    {
        System.Configuration.Configuration config;
        public SqlConnection connection { get; set; }
        public SqlCommand cmd { get; set; } = null;
        public DataTable dt { get; set; } = null;

        public SqlDataAdapter da { get; set; } = new SqlDataAdapter();


        public ServerConfiguration()
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            dt= new DataTable();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        }
        /// <summary>
        /// SERVER CONNECTION
        /// </summary>
        /// <returns></returns>
        public SqlConnection Connection()
        {
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["cms_connection"].ConnectionString;
                connection=new SqlConnection(constr);
                return connection;

            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// CLOSE DB CONNECTION
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();

                }
                else
                {
                    connection.Open();
                    connection.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        /// <summary>
        /// OPEN DB CONNECTION
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else
                {
                    connection.Close();
                    connection.Open();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string getConnectionString(string key)
        {
            return config.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }
        public void saveConnectionString(string key = "", string value = "")
        {
            try
            {
                config.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
                config.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("Connection String Save Successfully", "Modify Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
