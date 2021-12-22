using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CanteenManagementSystem.Configuration;
using System.Data.SqlClient;
using CanteenManagementSystem.SoftwareConfigurations;
using CanteenManagementSystem.State;
namespace CanteenManagementSystem.Screens
{
    public partial class ServerConfigScreen : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string conString;
        ServerConfiguration sQLConnectionSettings = new ServerConfiguration();

        public ServerConfigScreen()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.WHITE);
            ServerNames();
        }

        private void TestConnectionbtn_Click(object sender, EventArgs e)
        {
                if (DatabaseNamecbx.Text.Length <= 0)
                {
                    MessageBox.Show("Please select database", "Choose DB", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DatabaseNamecbx.Focus();
                    return;
                }
                else
                {
                    DBConnection();
                    SaveConnectionbtn.Enabled = true;

                }
        }


        private void DBConnection()
        {
            try
            {
                if (AuthTypecbx.SelectedIndex == 0)
                {
                    conString = string.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=True", ServerNamecbx.Text, DatabaseNamecbx.Text, Usernametxt.Text, Passwordtxt.Text);

                }
                else
                {
                    conString = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};Integrated Security = True;", ServerNamecbx.Text, DatabaseNamecbx.Text, Usernametxt.Text, Passwordtxt.Text);
                }
                SQLHelper sQLHelper = new SQLHelper(conString);
                if (sQLHelper.isConnection)
                {
                    MessageBox.Show(string.Format("Connected to {0} database successfully", DatabaseNamecbx.Text.ToString()), "Database Connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SaveConnectionbtn_Click(object sender, EventArgs e)
        {
            if (AuthTypecbx.SelectedIndex == 0)
            {
                conString = string.Format("Data Source={0}; Initial Catalog={1}; Integrated Security=True", ServerNamecbx.Text, DatabaseNamecbx.Text, Usernametxt.Text, Passwordtxt.Text);

            }
            else
            {
                conString = string.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};Integrated Security = True;", ServerNamecbx.Text, DatabaseNamecbx.Text, Usernametxt.Text, Passwordtxt.Text);
            }
            sQLConnectionSettings.saveConnectionString("cms_connection", conString);
        }


        ///
        private void LoadDatabase()
        {
            DatabaseNamecbx.Items.Clear();
            ServerConfiguration server = new ServerConfiguration();
            if (AuthTypecbx.Text.Equals("Windows Authentication"))
            {
                SqlState.ConnectionString = string.Format("Server={0};Integrated Security=SSPI;", ServerNamecbx.Text);
                con.ConnectionString = SqlState.ConnectionString;

            }
            else if (AuthTypecbx.Text.Equals("SQL Server Authentication"))
            {
                SqlState.ConnectionString = string.Format("Server={0};User Id={1};Password={2}", ServerNamecbx.Text, Usernametxt.Text, Passwordtxt.Text);
                con.ConnectionString = SqlState.ConnectionString;
            }

            ////
            ///
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT DB_NAME(database_id) AS[Database],database_id FROM sys.databases;";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DatabaseNamecbx.Items.Add(dr["Database"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd.Dispose();
            }
        }


        private void RestartAppbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ServerNames()
        {
            ServerNamecbx.Items.Add(Environment.MachineName.ToString());
            ServerNamecbx.Items.Add(string.Concat(Environment.MachineName, @"\SQLEXPRESS"));
            ServerNamecbx.Items.Add(".");
            ServerNamecbx.Items.Add("(local)");
            ServerNamecbx.Items.Add(@".\SQLEXPRESS");
            //ServerNamecbx.Items.Add(Environment.MachineName.ToString());
            ServerNamecbx.SelectedIndex = 0;

            /////
            ///
            Usernametxt.Enabled = false;
            Passwordtxt.Enabled = false;
        }

        private void DatabaseNamecbx_MouseClick(object sender, MouseEventArgs e)
        {
            LoadDatabase();
        }
    }
}
