namespace CanteenManagementSystem.Screens
{
    partial class LoginScreen
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
            this.ServerConfigbtn = new FontAwesome.Sharp.IconButton();
            this.Errorlbl = new System.Windows.Forms.Label();
            this.RegisterScreenbtn = new MaterialSkin.Controls.MaterialButton();
            this.Exitbtn = new FontAwesome.Sharp.IconButton();
            this.Loginbtn = new MaterialSkin.Controls.MaterialButton();
            this.Passwordtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Phonetxt = new MaterialSkin.Controls.MaterialTextBox();
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
            this.bunifuGroupBox1.Controls.Add(this.ServerConfigbtn);
            this.bunifuGroupBox1.Controls.Add(this.Errorlbl);
            this.bunifuGroupBox1.Controls.Add(this.RegisterScreenbtn);
            this.bunifuGroupBox1.Controls.Add(this.Exitbtn);
            this.bunifuGroupBox1.Controls.Add(this.Loginbtn);
            this.bunifuGroupBox1.Controls.Add(this.Passwordtxt);
            this.bunifuGroupBox1.Controls.Add(this.Phonetxt);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(35, 27);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(411, 266);
            this.bunifuGroupBox1.TabIndex = 1;
            this.bunifuGroupBox1.TabStop = false;
            // 
            // ServerConfigbtn
            // 
            this.ServerConfigbtn.FlatAppearance.BorderSize = 0;
            this.ServerConfigbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerConfigbtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.ServerConfigbtn.IconColor = System.Drawing.Color.LightGray;
            this.ServerConfigbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ServerConfigbtn.IconSize = 20;
            this.ServerConfigbtn.Location = new System.Drawing.Point(377, 231);
            this.ServerConfigbtn.Name = "ServerConfigbtn";
            this.ServerConfigbtn.Size = new System.Drawing.Size(27, 23);
            this.ServerConfigbtn.TabIndex = 12;
            this.ServerConfigbtn.UseVisualStyleBackColor = true;
            this.ServerConfigbtn.Click += new System.EventHandler(this.ServerConfigbtn_Click);
            // 
            // Errorlbl
            // 
            this.Errorlbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.Errorlbl.ForeColor = System.Drawing.Color.Firebrick;
            this.Errorlbl.Location = new System.Drawing.Point(29, 10);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(354, 17);
            this.Errorlbl.TabIndex = 11;
            this.Errorlbl.Text = "..";
            this.Errorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterScreenbtn
            // 
            this.RegisterScreenbtn.AutoSize = false;
            this.RegisterScreenbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterScreenbtn.Depth = 0;
            this.RegisterScreenbtn.DrawShadows = true;
            this.RegisterScreenbtn.HighEmphasis = true;
            this.RegisterScreenbtn.Icon = null;
            this.RegisterScreenbtn.Location = new System.Drawing.Point(207, 214);
            this.RegisterScreenbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterScreenbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterScreenbtn.Name = "RegisterScreenbtn";
            this.RegisterScreenbtn.Size = new System.Drawing.Size(152, 23);
            this.RegisterScreenbtn.TabIndex = 5;
            this.RegisterScreenbtn.Text = "REgister account";
            this.RegisterScreenbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.RegisterScreenbtn.UseAccentColor = false;
            this.RegisterScreenbtn.UseVisualStyleBackColor = true;
            this.RegisterScreenbtn.Click += new System.EventHandler(this.RegisterScreenbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.Exitbtn.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.Exitbtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.Exitbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Exitbtn.IconSize = 20;
            this.Exitbtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Exitbtn.Location = new System.Drawing.Point(287, 156);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(96, 40);
            this.Exitbtn.TabIndex = 3;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Loginbtn
            // 
            this.Loginbtn.AutoSize = false;
            this.Loginbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Loginbtn.Depth = 0;
            this.Loginbtn.DrawShadows = true;
            this.Loginbtn.HighEmphasis = true;
            this.Loginbtn.Icon = null;
            this.Loginbtn.Location = new System.Drawing.Point(29, 156);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Loginbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(251, 37);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "login";
            this.Loginbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Loginbtn.UseAccentColor = false;
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.White;
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Depth = 0;
            this.Passwordtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Passwordtxt.Hint = "Password";
            this.Passwordtxt.Location = new System.Drawing.Point(29, 97);
            this.Passwordtxt.MaxLength = 50;
            this.Passwordtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Passwordtxt.Multiline = false;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Password = true;
            this.Passwordtxt.Size = new System.Drawing.Size(354, 50);
            this.Passwordtxt.TabIndex = 1;
            this.Passwordtxt.Text = "";
            // 
            // Phonetxt
            // 
            this.Phonetxt.BackColor = System.Drawing.Color.White;
            this.Phonetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Phonetxt.Depth = 0;
            this.Phonetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Phonetxt.Hint = "Phone Number";
            this.Phonetxt.Location = new System.Drawing.Point(29, 41);
            this.Phonetxt.MaxLength = 50;
            this.Phonetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Phonetxt.Multiline = false;
            this.Phonetxt.Name = "Phonetxt";
            this.Phonetxt.Size = new System.Drawing.Size(354, 50);
            this.Phonetxt.TabIndex = 0;
            this.Phonetxt.Text = "";
            // 
            // LoginScreen
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGroupBox1);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "LoginScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.bunifuGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private FontAwesome.Sharp.IconButton ServerConfigbtn;
        private System.Windows.Forms.Label Errorlbl;
        private MaterialSkin.Controls.MaterialButton RegisterScreenbtn;
        private FontAwesome.Sharp.IconButton Exitbtn;
        private MaterialSkin.Controls.MaterialButton Loginbtn;
        private MaterialSkin.Controls.MaterialTextBox Passwordtxt;
        private MaterialSkin.Controls.MaterialTextBox Phonetxt;
    }
}