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
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Controller;
using CanteenManagementSystem.Services;
using CanteenManagementSystem.State;
using CanteenManagementSystem.Functions;
namespace CanteenManagementSystem.Screens
{
    public partial class HomeScreen : MaterialForm
    {

        readonly MaterialSkinManager materialSkinManager;
        PaymentsController controller = new PaymentsController();
        ClassController classController = new ClassController();
        StudentsController studentsController = new StudentsController();
        ClassServices classServices = new ClassServices();
        StudentsServices studentsServices = new StudentsServices();
        PaymentsServices services = new PaymentsServices();
        HandleExcelData handleExcelData = new HandleExcelData();
        DataTable excel_data_table = new DataTable();
        UserState state = new UserState();
        public HomeScreen()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.WHITE);
        }

        private   void GetData()
        {
            try
            {
                string dtn = DateTime.Now.ToShortDateString().ToString();
                DatePaidtxt.Text = DateTime.Now.ToShortDateString();
                DataTable tb = controller.FilterPaymentsByDate(dtn).Result;
                Paymentstb.DataSource = tb;
                List<string> classes = new List<string>();
                DataTable ctb = classController.GetClasses().Result;
                
                foreach (DataRow row in ctb.Rows)
                {
                    classes.Add(row["ClassTitle"].ToString());
                }
                //Classescbx.DataSource=classes;
                //FilterClasscbx.DataSource = classes;
                excel_data_table = tb;
                Amountslbl.Text ="Amount   Ghs " +services.GetTotalPayments(tb);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// LOAD ALL PAYMENTS
        /// </summary>
        private void LoadAllPayments()
        {
            try
            {
                DatePaidtxt.Text = DateTime.Now.ToShortDateString().ToString();
                DataTable tb = controller.FetchPayments().Result;
                Paymentstb.DataSource = tb;
                List<string> classes = new List<string>();
                DataTable ctb = classController.GetClasses().Result;

                foreach (DataRow row in ctb.Rows)
                {
                    classes.Add(row["ClassTitle"].ToString());
                }
                Classescbx.DataSource = classes;
                FilterClasscbx.DataSource = classes;
                excel_data_table = tb;
                Amountslbl.Text ="Amount   Ghs " +services.GetTotalPayments(tb);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HomeScreen_Load(object sender, EventArgs e)
        {
            try
            {
                GetData();
                GetClassesAndStudents();
                GetFilterClasses();
                if (UserState.UserInfo==null)
                {
                    Usernamelbl.Text = AdminState.Name;
                    SavePaymentbtn.Enabled = false;
                }
                else
                {
                    ConfigureServer.Visible = false;
                    Usernamelbl.Text = state.GetState().Username;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximizebtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                Maximizebtn.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Maximizebtn.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
        }

        private void GetFilterClasses()
        {
            try
            {
                List<string> classes = new List<string>();
                DataTable ctb = classController.GetClasses().Result;

                foreach (DataRow row in ctb.Rows)
                {
                    classes.Add(row["ClassTitle"].ToString());
                }
                FilterClasscbx.DataSource = classes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetClassesAndStudents()
        {
            try
            {
                List<string> classes = new List<string>();
                DataTable ctb = classController.GetClasses().Result;
                foreach (DataRow row in ctb.Rows)
                {
                    classes.Add(row["ClassTitle"].ToString());
                }
                Classescbx.DataSource = classes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SavePayment()
        {
            try
            {
                PaymentModel mod = new PaymentModel();
                mod.AmountPaid = AmountPaidtxt.Text;
                mod.DatePaid = DatePaidtxt.Text;
                StudentsModel studentsModel = new StudentsModel();
                studentsModel.StudentName = Studentscbx.Text;
                studentsModel = studentsServices.FormatStudentInfo(studentsController.GetStudentByName(studentsModel));
                mod.StudentID=studentsModel.StudentID;
                ClassModel classModel = new ClassModel();
                classModel.ClassTitle = Classescbx.Text;
                classModel = classServices.FormatClassInfo(classController.GetClassByTitle(classModel).Result);
                mod.ClassID=classModel.ClassID;
                mod.UserID = UserState.UserInfo.UserID;

                mod = controller.AddPayment(mod);
                Msglbl.Text = mod.message;
                GetData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,ex.Source,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePaymentbtn_Click(object sender, EventArgs e)
        {
            SavePayment();
        }

        private void Classescbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ///GET ALL THE STUDENTS WITH THE CLASS
                ClassModel cmod = new ClassModel();
                cmod.ClassTitle = Classescbx.Text;
                List<string> students = new List<string>();
                StudentsModel smod = new StudentsModel();
                smod.ClassID = classServices.FormatClassInfo(classController.GetClassByTitle(cmod).Result).ClassID;
                DataTable cstb = studentsController.GetStudentsByClass(smod).Result;
                foreach (DataRow row in cstb.Rows)
                {
                    students.Add(row["StudentName"].ToString());
                }
                Studentscbx.DataSource = students;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,ex.Source,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }



        private void StudentsScreen_Click(object sender, EventArgs e)
        {
            StudentsScreen studentsScreen = new StudentsScreen();
            studentsScreen.Show();
        }

        private void ClassesScreen_Click(object sender, EventArgs e)
        {
            ClassScreen classScreen = new ClassScreen();
            classScreen.Show();
        }

        private void MsgTimer_Tick(object sender, EventArgs e)
        {
            Msglbl.Text = "..";
        }

        private void Refreshdatabtn_Click(object sender, EventArgs e)
        {
            GetData();
            GetClassesAndStudents();
            GetFilterClasses();
        }

        /// <summary>
        /// FILTER PAYMENTS BY CLASS OF STUDENTS
        /// </summary>
        private void FilterPaymentsByClass()
        {
            try
            {
                ClassModel mod = new ClassModel();
                mod.ClassTitle = FilterClasscbx.Text;
                mod = classServices.FormatClassInfo(classController.GetClassByTitle(mod).Result);
                DataTable dt = controller.FilterPaymentsByClass(mod).Result;
                Paymentstb.DataSource = dt;
                excel_data_table = dt;
                Amountslbl.Text = services.GetTotalPayments(dt);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDatabtn_Click(object sender, EventArgs e)
        {
            handleExcelData.ExportData(excel_data_table, "Payments", "Payments");
        }

        /// <summary>
        /// FILTER PAYMENTS BY DATE PAID
        /// </summary>
        private void FilterPaymentsByDate()
        {
            try
            {
                if (DatePickertxt.Text.Length > 0)
                {
                    DataTable dt = controller.FilterPaymentsByDate(DatePickertxt.Text).Result;
                    Paymentstb.DataSource = dt;
                    excel_data_table = dt;
                    Amountslbl.Text = services.GetTotalPayments(dt);

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// FILTER DATE PICKER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatePickertxt_TextChanged(object sender, EventArgs e)
        {
            FilterPaymentsByDate(); 
        }

        private void GetPaymentsByfilterbtn_Click(object sender, EventArgs e)
        {
            FilterPaymentsByClass();
        }

        private void LoadAllPaymentsbtn_Click(object sender, EventArgs e)
        {
            LoadAllPayments();
        }

        private void RegisterUserbtn_Click(object sender, EventArgs e)
        {
            RegisterScreen Register = new RegisterScreen();
            Register.Show();
        }

        private void ConfigureServer_Click(object sender, EventArgs e)
        {
            ServerConfigScreen Server = new ServerConfigScreen();
            Server.Show();
        }
    }
}
