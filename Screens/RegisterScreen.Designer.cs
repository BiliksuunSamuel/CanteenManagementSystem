namespace CanteenManagementSystem.Screens
{
    partial class RegisterScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.Errorlbl = new MaterialSkin.Controls.MaterialLabel();
            this.Passwordtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Registerbtn = new MaterialSkin.Controls.MaterialButton();
            this.Phonetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Usernametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Closebtn = new MaterialSkin.Controls.MaterialButton();
            this.bunifuGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.White;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 1;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.Closebtn);
            this.bunifuGroupBox1.Controls.Add(this.Errorlbl);
            this.bunifuGroupBox1.Controls.Add(this.Passwordtxt);
            this.bunifuGroupBox1.Controls.Add(this.Registerbtn);
            this.bunifuGroupBox1.Controls.Add(this.Phonetxt);
            this.bunifuGroupBox1.Controls.Add(this.Usernametxt);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(16, 20);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(490, 279);
            this.bunifuGroupBox1.TabIndex = 3;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // Errorlbl
            // 
            this.Errorlbl.Depth = 0;
            this.Errorlbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Errorlbl.Location = new System.Drawing.Point(27, 245);
            this.Errorlbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(432, 23);
            this.Errorlbl.TabIndex = 15;
            this.Errorlbl.Text = "..";
            this.Errorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.White;
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Depth = 0;
            this.Passwordtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Passwordtxt.Hint = "Password";
            this.Passwordtxt.Location = new System.Drawing.Point(27, 135);
            this.Passwordtxt.MaxLength = 50;
            this.Passwordtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Passwordtxt.Multiline = false;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Password = true;
            this.Passwordtxt.Size = new System.Drawing.Size(432, 50);
            this.Passwordtxt.TabIndex = 14;
            this.Passwordtxt.Text = "";
            // 
            // Registerbtn
            // 
            this.Registerbtn.AutoSize = false;
            this.Registerbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Registerbtn.Depth = 0;
            this.Registerbtn.DrawShadows = true;
            this.Registerbtn.HighEmphasis = true;
            this.Registerbtn.Icon = null;
            this.Registerbtn.Location = new System.Drawing.Point(30, 204);
            this.Registerbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Registerbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(260, 35);
            this.Registerbtn.TabIndex = 12;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Registerbtn.UseAccentColor = false;
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // Phonetxt
            // 
            this.Phonetxt.BackColor = System.Drawing.Color.White;
            this.Phonetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phonetxt.Depth = 0;
            this.Phonetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Phonetxt.Hint = "Phone Number";
            this.Phonetxt.Location = new System.Drawing.Point(27, 79);
            this.Phonetxt.MaxLength = 50;
            this.Phonetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Phonetxt.Multiline = false;
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(432, 50);
            this.Phonetxt.TabIndex = 11;
            this.Phonetxt.Text = "";
            // 
            // Usernametxt
            // 
            this.Usernametxt.BackColor = System.Drawing.Color.White;
            this.Usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernametxt.Depth = 0;
            this.Usernametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Usernametxt.Hint = "Username";
            this.Usernametxt.Location = new System.Drawing.Point(27, 22);
            this.Usernametxt.MaxLength = 50;
            this.Usernametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Usernametxt.Multiline = false;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(432, 50);
            this.Usernametxt.TabIndex = 10;
            this.Usernametxt.Text = "";
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSize = false;
            this.Closebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Closebtn.Depth = 0;
            this.Closebtn.DrawShadows = true;
            this.Closebtn.HighEmphasis = false;
            this.Closebtn.Icon = null;
            this.Closebtn.Location = new System.Drawing.Point(298, 203);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Closebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(161, 36);
            this.Closebtn.TabIndex = 16;
            this.Closebtn.Text = "Close";
            this.Closebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Closebtn.UseAccentColor = false;
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // RegisterScreen
            // 
            this.AcceptButton = this.Registerbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 334);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(533, 334);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(533, 334);
            this.Name = "RegisterScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.TopMost = true;
            this.bunifuGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private MaterialSkin.Controls.MaterialTextBox Passwordtxt;
        private MaterialSkin.Controls.MaterialButton Registerbtn;
        private MaterialSkin.Controls.MaterialTextBox Phonetxt;
        private MaterialSkin.Controls.MaterialTextBox Usernametxt;
        private MaterialSkin.Controls.MaterialLabel Errorlbl;
        private MaterialSkin.Controls.MaterialButton Closebtn;
    }
}