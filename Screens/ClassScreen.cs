using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using CanteenManagementSystem.Models;
using CanteenManagementSystem.Controller;
using CanteenManagementSystem.Services;
namespace CanteenManagementSystem.Screens
{
    public partial class ClassScreen : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        ClassController controller = new ClassController();
        ClassServices services = new ClassServices();
        public ClassScreen()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.WHITE);
        }


        /// <summary>
        /// REGISTER CLASS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClassModel model = new ClassModel();
                model.ClassTitle = Classtitletxt.Text.ToUpper().ToString();
                model =await controller.AddClass(model);
                MessageBox.Show(model.message, "Class Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetClasses();
                Classtitletxt.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClassScreen_Load(object sender, EventArgs e)
        {
            GetClasses();
        }


        /// <summary>
        /// GET CLASSES
        /// </summary>
        private async void GetClasses()
        {
            try
            {
                DataTable dt = await controller.GetClasses();
                TbClasses.DataSource= dt;
              List<string>classes = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    classes.Add(row["ClassTitle"].ToString());

                }
                CbxClasses.DataSource = classes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private  void UpdateClassInfo()
        {
            try
            {
                if (CbxClasses.Text.Length > 0 && Classtitletxt.Text.Length>0)
                {
                    ClassModel model = new ClassModel();
                    model.ClassTitle = CbxClasses.Text;
                    if (controller.GetClassByTitle(model).Result.Rows.Count > 0)
                    {
                        model = services.FormatClassInfo(controller.GetClassByTitle(model).Result);
                        model.ClassTitle = Classtitletxt.Text.ToUpper();
                        model = controller.UpdateClassTitle(model);
                        MessageBox.Show(model.message, "Class Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetClasses();
                        Classtitletxt.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Please Select Class To Update", "Class Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateClassInfo();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ClassModel model = new ClassModel();
                if (CbxClasses.Text.Length > 0)
                {
                    DialogResult dialog = (MessageBox.Show("Do you want to delete this Class???", "Delete Class", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if(dialog==DialogResult.Yes)
                    {

                        model.ClassTitle = CbxClasses.Text;
                        if (controller.GetClassByTitle(model).Result.Rows.Count > 0)
                        {
                            model = services.FormatClassInfo(controller.GetClassByTitle(model).Result);
                            model = controller.RemoveClass(model);
                            MessageBox.Show(model.message, "Delete Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetClasses();

                        }
                        else
                        {
                            MessageBox.Show("Please Select Class", "Delete Class", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
 