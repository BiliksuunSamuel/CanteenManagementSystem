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
namespace CanteenManagementSystem.Screens
{
    public partial class RegisterScreen : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        UsersController controller = new UsersController();
        UserServices services = new UserServices();
        public RegisterScreen()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.Blue900, Primary.Blue900, Accent.Blue200, TextShade.WHITE);
        }

        private void LoginScreenbtn_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            this.Hide();
            loginScreen.Show();
        }

        private void HandleRegister()
        {
            try
            {
                UserModel model = new UserModel();
                model.Username = Usernametxt.Text.ToUpper();
                model.PhoneNumber = Phonetxt.Text;
                model.Password = Passwordtxt.Text;
                model = controller.UserRegister(model).Result;
                MessageBox.Show(model.message, "User Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                Errorlbl.Text = ex.Message;
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Errorlbl.Text = "..";
            HandleRegister();
        }
    }
}
