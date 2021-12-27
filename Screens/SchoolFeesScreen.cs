using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenManagementSystem.Controller;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Services;
using CanteenManagementSystem.State;
using CanteenManagementSystem.Functions;
namespace CanteenManagementSystem.Screens
{
    public partial class SchoolFeesScreen : Form
    {
        FeesServices services = new FeesServices();
        FeesController controller = new FeesController();
        ClassController ccontroller = new ClassController();
        ClassServices cservices = new ClassServices();
        FeesModel selectedFees = new FeesModel();
        HandleExcelData handleData = new HandleExcelData();
        HandleException handleEx = new HandleException();
        StudentsController scontroller = new StudentsController();
        StudentsServices sservices = new StudentsServices();
        public SchoolFeesScreen()
        {
            InitializeComponent();
        }

        private void SchoolFeesScreen_Load(object sender, EventArgs e)
        {
            LoadSchoolFees();
            LoadFees();
            GetClasses();
            OldClasstxt.Enabled = false;
            OldClasslbl.Enabled = false;
            AmountDuetxt.Enabled = false;
            AmountDuelbl.Enabled = false;
            PreparePaymentsbtn.Enabled = false;
        }

        private void GetClasses()
        {
            try
            {
                List<string> Classes = new List<string>();
                DataTable dt = ccontroller.GetClasses().Result;
                if(dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Classes.Add(row["ClassTitle"].ToString());
                    }
                }
                FilterPaymentClasscbx.DataSource = Classes;
                ClassesListcbx.DataSource=Classes;
                NewClasscbx.DataSource = Classes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadSchoolFees()
        {
            try
            {
                DataTable dt = controller.GetPaidFees().Result;
                PaidFeesdg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LoadFees()
        {
            try
            {
                DataTable dt = controller.GetFees().Result;
                Feesdg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditFeescbx_CheckedChanged(object sender, EventArgs e)
        {
            if (EditFeescbx.Checked)
            {
                SaveFeesbtn.Text = "Save Changes";

            }
            else
            {
                SaveFeesbtn.Text = "Save Fees";
            }
        }

        private void PreparePaymentschk_CheckedChanged(object sender, EventArgs e)
        {
            if (PreparePaymentschk.Checked)
            {
                PreparePaymentsbtn.Enabled = true;
            }
            else
            {
                PreparePaymentsbtn.Enabled = false;
            }
        }

        private void SaveFeesbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EditFeescbx.Checked)
                {
                    UpdateFeesInfo();
                }
                else
                {

                    ClassModel cmod = new ClassModel();
                    cmod.ClassTitle = NewClasscbx.Text;
                    cmod = cservices.FormatClassInfo(ccontroller.GetClassByTitle(cmod).Result);
                    FeesModel fmod = new FeesModel();
                    fmod.Amount = NewAmountxt.Text;
                    fmod.ClassID = cmod.ClassID;
                    fmod = controller.SaveFees(fmod).Result;
                    SuccessMessenger(fmod.message, "School Fees");
                }
                LoadFees();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Feesdg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable table = (DataTable)Feesdg.DataSource;
               
                if (table.Rows.Count > 0 && e.RowIndex<table.Rows.Count)
                {
                    FeesModel mod = services.GetFeesInfoFromTable(table.Rows[e.RowIndex]);
                    NewAmountxt.Text=mod.Amount.ToString();
                    OldClasstxt.Text=mod.ClassID.ToString();
                    selectedFees = mod;
                }
            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }

        private void ErrorMessenger(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void SuccessMessenger(string msg="",string source = "School Fees")
        {
            MessageBox.Show(msg, source, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void NewClasscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditFeescbx.Enabled)
            {
                OldClasstxt.Text = NewClasscbx.Text;
            }
        }

        /// <summary>
        /// UPDATE FEES INFO
        /// </summary>
        private void UpdateFeesInfo()
        {
            try
            {
                ClassModel mod = new ClassModel();
                mod.ClassTitle = OldClasstxt.Text;
                mod = cservices.FormatClassInfo(ccontroller.GetClassByTitle(mod).Result);
                FeesModel fmod = new FeesModel();
                fmod.Amount = NewAmountxt.Text;
                fmod.ClassID = mod.ClassID;
                fmod.ID = selectedFees.ID;
                fmod = controller.UpdateFeesInfo(fmod).Result;
                SuccessMessenger(fmod.message);
            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }

        private void PrepareFees()
        {
            try
            {
               
                ClassModel mod = new ClassModel();
                mod.ClassTitle = OldClasstxt.Text;
                mod = cservices.FormatClassInfo(ccontroller.GetClassByTitle(mod).Result);
                FeesModel fmod = new FeesModel();
                FeePaymentModel pmod = new FeePaymentModel();
                StudentsModel smod = new StudentsModel();


                fmod.Amount = NewAmountxt.Text;
                fmod.ClassID = mod.ClassID;
                fmod.ID = selectedFees.ID;

                smod.ClassID = mod.ClassID;
                DataTable tb = scontroller.GetStudentsByClass(smod).Result;
                
                pmod.DatePaid = String.Format("{0}/{1}", DateTime.Now.Month, DateTime.Now.Year);
                pmod.ClassID = mod.ClassID;
                if (controller.GetPaidFeesByDate(pmod).Result.Rows.Count > 0)
                {
                    ErrorMessenger(handleEx.HandleStack("Fees Already Initialized"));
                }
                else
                {
                    if (tb.Rows.Count > 0)
                    {

                        foreach (DataRow row in tb.Rows)
                        {
                            pmod.StudentID =row["StudentID"].ToString();
                            pmod.ClassID =row["ClassID"].ToString();
                            pmod.AmountPaid = "0";
                            pmod.Arears = NewAmountxt.Text;
                            pmod= controller.InitializeFees(pmod).Result;

                        }
                        SuccessMessenger(pmod.message);
                        LoadSchoolFees();
                    }
                    else
                    {
                        ErrorMessenger(handleEx.HandleStack("Class Has No Students","School Fees"));
                    }
                }

            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = (DataTable)PaidFeesdg.DataSource;
                if (table.Rows.Count > 0)
                {
                    handleData.ExportData(table,"School Fees","SchoolFees");
                }
                else
                {
                    ErrorMessenger(handleEx.HandleStack("No Data To Export", "School Fees"));
                }
            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }

        private void PreparePaymentsbtn_Click(object sender, EventArgs e)
        {
            if (OldClasstxt.Text.Length <= 0 || NewAmountxt.Text.Length<=0)
            {
                ErrorMessenger(handleEx.HandleStack("Please Select Fees", "Fees Payment"));
                return;
            }
            else
            {
                PrepareFees();
            }
        }

        private void GetClassStudents()
        {
            try
            {
                ClassModel mod = new ClassModel();
                mod.ClassTitle = ClassesListcbx.Text;
                mod = cservices.FormatClassInfo(ccontroller.GetClassByTitle(mod).Result);
                StudentsModel smod = new StudentsModel();
                smod.ClassID = mod.ClassID;
                DataTable tb = scontroller.GetStudentsByClass(smod).Result;
                List<string> Students = new List<string>();
                foreach (DataRow row in tb.Rows)
                {
                    Students.Add(row["StudentName"].ToString());
                }
                StudentsListcbx.DataSource = Students;
            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }

        private void ClassesListcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetClassStudents();
        }

        private void GetStudentPaymentHistory()
        {
            try
            {

                StudentsModel sm = new StudentsModel();
                sm.StudentName = StudentsListcbx.Text;
                sm = sservices.FormatStudentInfo(scontroller.GetStudentByName(sm));
                FeePaymentModel fm = new FeePaymentModel();
                fm.StudentID = sm.StudentID;
                DataTable tb = controller.GetStudentFees(fm).Result;
                StudentNametxt.Text = StudentsListcbx.Text;
                StudentClasstxt.Text = ClassesListcbx.Text;
                PaidFeesdg.DataSource = tb;
                StudentFeesPaidtxt.Text = services.GetAmountPaid(tb);
                StudentArearstxt.Text = services.GetAreas(tb);
                AmountDuetxt.Text = services.GetAreas(tb);

            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }

        private void StudentsListcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentsModel sm = new StudentsModel();
            sm.StudentName = StudentsListcbx.Text;
            sm = sservices.FormatStudentInfo(scontroller.GetStudentByName(sm));
            FeePaymentModel fm = new FeePaymentModel();
            fm.StudentID = sm.StudentID;

            DataTable tb = controller.GetStudentFees(fm).Result;
            StudentNametxt.Text = StudentsListcbx.Text;
            StudentClasstxt.Text = ClassesListcbx.Text;
            PaidFeesdg.DataSource = tb;
            StudentFeesPaidtxt.Text = services.GetAmountPaid(tb);
            StudentArearstxt.Text = services.GetAreas(tb);
            AmountDuetxt.Text = services.GetAreas(tb);

        }

        private void MakePayment()
        {

            try
            {
                StudentsModel sm = new StudentsModel();
                sm.StudentName = StudentsListcbx.Text;
                sm = sservices.FormatStudentInfo(scontroller.GetStudentByName(sm));
                FeePaymentModel fm = new FeePaymentModel();
                fm.StudentID = sm.StudentID;
                fm.ReceiptNumber = ReceptNumbertxt.Text;
                fm.AmountPaid = Amountxt.Text;
                fm.UserID =UserState.UserInfo.UserID;
                fm.DatePaid = String.Format("{0}/{1}", DateTime.Now.Month, DateTime.Now.Year);
                fm.Arears = StudentArearstxt.Text;
                fm.ClassID = sm.ClassID;
                fm = controller.SaveFeePayment(fm).Result;
                SuccessMessenger(fm.message);
                GetStudentPaymentHistory();
                Amountxt.Text = "";
            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
          
        }

        private void SavePaymentbtn_Click(object sender, EventArgs e)
        {
            MakePayment();
        }

        private void FeesInformation()
        {
            try
            {
                DataTable table = controller.GetPaidFees().Result;
                PaidFeesdg.DataSource = table;
                TotalReceivedFeeslbl.Text = services.GetAmountPaid(table);
                Arearslbl.Text = services.GetAreas(table);
            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }

        private void LoadAllPaymentbtn_Click(object sender, EventArgs e)
        {
            try
            {
                LoadFees();
                FeesInformation();
            }
            catch (Exception ex)
            {

                ErrorMessenger(ex);
            }
        }
    }
}
 