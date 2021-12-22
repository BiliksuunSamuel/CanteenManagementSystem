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
namespace CanteenManagementSystem.Screens
{
    public partial class LoginScreen : MaterialForm
    {
        readonly MaterialSkinManager materialSkinManager;
        UsersController controller = new UsersController();
        UserState userState = new UserState();
        public LoginScreen()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.Blue900, Primary.Blue900,Accent.Blue200, TextShade.WHITE);
        }
        private void HandleLogin()
        {
            try
            {
                UserModel model = new UserModel();
                model.PhoneNumber = Phonetxt.Text;
                model.Password = Passwordtxt.Text;

                model = controller.UserLogin(model);
                userState.SetState(model);
                this.Hide();
                HomeScreen Home = new HomeScreen();
                Home.Show();
            }
            catch (Exception ex)
            {

                Errorlbl.Text = ex.Message ;
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Exit Application", "Close App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RegisterScreenbtn_Click(object sender, EventArgs e)
        {
            RegisterScreen register = new RegisterScreen();
            this.Hide();
            register.Show();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Errorlbl.Text = "..";
            HandleLogin();
        }

        private void ServerConfigbtn_Click(object sender, EventArgs e)
        {
            ServerConfigScreen ServerScreen = new ServerConfigScreen();
            this.Hide();
            ServerScreen.Show();
        }
    }

}
