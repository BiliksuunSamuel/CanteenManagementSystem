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
using CanteenManagementSystem.Controller;
using CanteenManagementSystem.Services;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Functions;
using CanteenManagementSystem.Utilities;
namespace CanteenManagementSystem.Screens
{
    public partial class StudentsScreen : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        StudentsController controller = new StudentsController();
        StudentsServices services = new StudentsServices();
        ClassController ccontroller = new ClassController();
        ClassServices cservices = new ClassServices();
        HandleExcelData handleExcel = new HandleExcelData();
        Utils utils = new Utils();

        private DataTable excel_data_table = new DataTable();
        public StudentsScreen()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.WHITE);
        }

        private void StudentsScreen_Load(object sender, EventArgs e)
        {
            GetStudents();
            GetClasses();
            GetfilterClasses();
        }

        /// <summary>
        /// GET STUDENTS
        /// </summary>
        private void GetStudents()
        {
            try
            {
                DataTable dt = controller.GetRegisteredStudents().Result;
                TbStudents.DataSource=dt;
                excel_data_table = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void GetfilterClasses()
        {
            try
            {
                List<string> classes = new List<string>();
                DataTable ctb = ccontroller.GetClasses().Result;
                foreach (DataRow row in ctb.Rows)
                {
                    classes.Add(row["ClassTitle"].ToString());

                }
                FilterStudentscbx.DataSource = classes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetClasses()
        {
            try
            {

                List<string> classes = new List<string>();
                DataTable ctb = ccontroller.GetClasses().Result;
                foreach (DataRow row in ctb.Rows)
                {
                    classes.Add(row["ClassTitle"].ToString());

                }
                Sclasscbx.DataSource = classes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// REGISTER STUDENT
        /// </summary>
        private void RegisterStudent()
        {
            try
            {
                ClassModel cm = new ClassModel();
                StudentsModel model = new StudentsModel();
                model.StudentName = Snametxt.Text.ToUpper();
                model.Contact = Sphonetxt.Text;
                model.Gender = Sgendercbx.Text.ToUpper();
                cm.ClassTitle=Sclasscbx.Text.ToUpper();
                cm = cservices.FormatClassInfo(ccontroller.GetClassByTitle(cm).Result);
                model.ClassID = cm.ClassID;
                model=controller.RegisterStudent(model);
                MessageBox.Show(model.message, "Student Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            RegisterStudent();
        }

        private void TbStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTableClick(e.RowIndex);

           // MessageBox.Show(model.StudentID.ToString(),"Row Clicked",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sidtxt.Text.Length > 0)
                {

                    ClassModel cm = new ClassModel();
                    StudentsModel model = new StudentsModel();
                    model.StudentName = USnametxt.Text.ToUpper();
                    model.Contact = USphonetxt.Text;
                    model.Gender = USgendertxt.Text.ToUpper();
                    model.StudentID = Sidtxt.Text;
                    cm.ClassTitle = USclasstxt.Text.ToUpper();
                    if (utils.TableHasData(ccontroller.GetClassByTitle(cm).Result)){
                        cm = cservices.FormatClassInfo(ccontroller.GetClassByTitle(cm).Result);
                        model.ClassID = cm.ClassID;
                        model = services.ValidateStudentInfo(model);
                        model = controller.UpdateStudentInfo(model);
                        GetStudents();
                        Msglbl.Text = model.message;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// DELETE STUDENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteStdbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Sidtxt.Text.Length > 0)
                {
                    DialogResult results = MessageBox.Show("Do you want to delete this student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (results == DialogResult.Yes)
                    {
                        StudentsModel model = new StudentsModel();
                        model.StudentID = Sidtxt.Text;
                        model = controller.DeleteStudent(model);
                        MessageBox.Show(model.message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetStudents();  
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ReloadDatabtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable db = controller.GetRegisteredStudents().Result;
                TbStudents.DataSource= db;
                GetClasses();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FilterStudentscbx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (FilterStudentscbx.Text == "ALL")
                {
                    DataTable db = controller.GetRegisteredStudents().Result;
                    TbStudents.DataSource = db;
                }
                ClassModel cm = new ClassModel();
                cm.ClassTitle = FilterStudentscbx.Text;
                cm = cservices.FormatClassInfo(ccontroller.GetClassByTitle(cm).Result);
                DataTable dt = controller.FilterStudentsByClass(cm).Result;
                TbStudents.DataSource = dt;
                excel_data_table = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportDatabtn_Click(object sender, EventArgs e)
        {
            handleExcel.ExportData(excel_data_table, "Students", "RegisteredStudents");
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void SearchStudent()
        {
            try
            {
                if (Searchtxt.Text.Length > 0)
                {
                    DataTable tbl = controller.SearchStudent(Searchtxt.Text.ToUpper());
                    TbStudents.DataSource = tbl;
                }
                else
                {
                    DataTable db = controller.GetRegisteredStudents().Result;
                    TbStudents.DataSource = db;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void MsgTimer_Tick(object sender, EventArgs e)
        {
            Msglbl.Text = "..";
        }

        private void TbStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTableClick(e.RowIndex);
        }

        private void DataTableClick(int row)
        {
            try
            {
                StudentsModel model = new StudentsModel();
                //MessageBox.Show(e.RowIndex.ToString(),"row",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (((DataTable)TbStudents.DataSource).Rows.Count > 0)
                {
                    DataRow srow = ((DataTable)TbStudents.DataSource).Rows[row];
                    model = services.FilterRowViewInfo(srow);
                    model = services.FormatStudentInfo(controller.GetStudentByName(model));
                    USnametxt.Text = model.StudentName;
                    USphonetxt.Text = model.Contact;
                    Sidtxt.Text = model.StudentID;
                    ClassModel cm = new ClassModel();
                    cm.ClassID = model.ClassID;
                    cm = cservices.FormatClassInfo(ccontroller.GetClassByID(cm).Result);
                    USclasstxt.Text = cm.ClassTitle;
                    USgendertxt.Text = model.Gender;


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentEditcbx_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentEditcbx.Checked == true)
            {
                DeleteStdbtn.Enabled = true;
                materialButton1.Enabled = true;
            }
            else
            {
                DeleteStdbtn.Enabled = false;
                materialButton1.Enabled = false;
            }
        }

        private void Sclasscbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentEditcbx.Checked)
            {
                USclasstxt.Text = Sclasscbx.Text;
            }
        }

        private void Sgendercbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentEditcbx.Checked)
            {
                USgendertxt.Text = Sgendercbx.Text;
            }
        }
    }
}
