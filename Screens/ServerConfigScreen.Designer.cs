namespace CanteenManagementSystem.Screens
{
    partial class ServerConfigScreen
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
            this.Container = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.CleanDb = new MaterialSkin.Controls.MaterialButton();
            this.RestartAppbtn = new FontAwesome.Sharp.IconButton();
            this.DatabaseNamecbx = new MaterialSkin.Controls.MaterialComboBox();
            this.ServerNamecbx = new MaterialSkin.Controls.MaterialComboBox();
            this.ServerTypecbx = new MaterialSkin.Controls.MaterialComboBox();
            this.SaveConnectionbtn = new MaterialSkin.Controls.MaterialButton();
            this.TestConnectionbtn = new MaterialSkin.Controls.MaterialButton();
            this.AuthTypecbx = new MaterialSkin.Controls.MaterialComboBox();
            this.Passwordtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Usernametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BorderColor = System.Drawing.Color.LightGray;
            this.Container.BorderRadius = 1;
            this.Container.BorderThickness = 1;
            this.Container.Controls.Add(this.CleanDb);
            this.Container.Controls.Add(this.RestartAppbtn);
            this.Container.Controls.Add(this.DatabaseNamecbx);
            this.Container.Controls.Add(this.ServerNamecbx);
            this.Container.Controls.Add(this.ServerTypecbx);
            this.Container.Controls.Add(this.SaveConnectionbtn);
            this.Container.Controls.Add(this.TestConnectionbtn);
            this.Container.Controls.Add(this.AuthTypecbx);
            this.Container.Controls.Add(this.Passwordtxt);
            this.Container.Controls.Add(this.Usernametxt);
            this.Container.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Container.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Container.LabelIndent = 10;
            this.Container.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Container.Location = new System.Drawing.Point(31, 28);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(499, 333);
            this.Container.TabIndex = 1;
            this.Container.TabStop = false;
            // 
            // CleanDb
            // 
            this.CleanDb.AutoSize = false;
            this.CleanDb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CleanDb.Depth = 0;
            this.CleanDb.DrawShadows = true;
            this.CleanDb.HighEmphasis = true;
            this.CleanDb.Icon = null;
            this.CleanDb.Location = new System.Drawing.Point(277, 268);
            this.CleanDb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CleanDb.MouseState = MaterialSkin.MouseState.HOVER;
            this.CleanDb.Name = "CleanDb";
            this.CleanDb.Size = new System.Drawing.Size(93, 34);
            this.CleanDb.TabIndex = 14;
            this.CleanDb.Text = "Clean Db";
            this.CleanDb.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.CleanDb.UseAccentColor = false;
            this.CleanDb.UseVisualStyleBackColor = true;
            this.CleanDb.Click += new System.EventHandler(this.CleanDb_Click);
            // 
            // RestartAppbtn
            // 
            this.RestartAppbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RestartAppbtn.FlatAppearance.BorderSize = 0;
            this.RestartAppbtn.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.RestartAppbtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(153)))));
            this.RestartAppbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RestartAppbtn.IconSize = 30;
            this.RestartAppbtn.Location = new System.Drawing.Point(377, 268);
            this.RestartAppbtn.Name = "RestartAppbtn";
            this.RestartAppbtn.Size = new System.Drawing.Size(81, 34);
            this.RestartAppbtn.TabIndex = 11;
            this.RestartAppbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RestartAppbtn.UseVisualStyleBackColor = false;
            this.RestartAppbtn.Click += new System.EventHandler(this.RestartAppbtn_Click);
            // 
            // DatabaseNamecbx
            // 
            this.DatabaseNamecbx.AutoResize = false;
            this.DatabaseNamecbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatabaseNamecbx.Depth = 0;
            this.DatabaseNamecbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.DatabaseNamecbx.DropDownHeight = 118;
            this.DatabaseNamecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabaseNamecbx.DropDownWidth = 121;
            this.DatabaseNamecbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.DatabaseNamecbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DatabaseNamecbx.FormattingEnabled = true;
            this.DatabaseNamecbx.Hint = "Database";
            this.DatabaseNamecbx.IntegralHeight = false;
            this.DatabaseNamecbx.ItemHeight = 29;
            this.DatabaseNamecbx.Location = new System.Drawing.Point(35, 224);
            this.DatabaseNamecbx.MaxDropDownItems = 4;
            this.DatabaseNamecbx.MouseState = MaterialSkin.MouseState.OUT;
            this.DatabaseNamecbx.Name = "DatabaseNamecbx";
            this.DatabaseNamecbx.Size = new System.Drawing.Size(423, 35);
            this.DatabaseNamecbx.StartIndex = 0;
            this.DatabaseNamecbx.TabIndex = 10;
            this.DatabaseNamecbx.UseTallSize = false;
            this.DatabaseNamecbx.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DatabaseNamecbx_MouseClick);
            // 
            // ServerNamecbx
            // 
            this.ServerNamecbx.AutoResize = false;
            this.ServerNamecbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ServerNamecbx.Depth = 0;
            this.ServerNamecbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ServerNamecbx.DropDownHeight = 118;
            this.ServerNamecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerNamecbx.DropDownWidth = 121;
            this.ServerNamecbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ServerNamecbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServerNamecbx.FormattingEnabled = true;
            this.ServerNamecbx.Hint = "Server Name";
            this.ServerNamecbx.IntegralHeight = false;
            this.ServerNamecbx.ItemHeight = 29;
            this.ServerNamecbx.Location = new System.Drawing.Point(35, 55);
            this.ServerNamecbx.MaxDropDownItems = 4;
            this.ServerNamecbx.MouseState = MaterialSkin.MouseState.OUT;
            this.ServerNamecbx.Name = "ServerNamecbx";
            this.ServerNamecbx.Size = new System.Drawing.Size(423, 35);
            this.ServerNamecbx.StartIndex = 0;
            this.ServerNamecbx.TabIndex = 9;
            this.ServerNamecbx.UseTallSize = false;
            // 
            // ServerTypecbx
            // 
            this.ServerTypecbx.AutoResize = false;
            this.ServerTypecbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ServerTypecbx.Depth = 0;
            this.ServerTypecbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ServerTypecbx.DropDownHeight = 118;
            this.ServerTypecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerTypecbx.DropDownWidth = 121;
            this.ServerTypecbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ServerTypecbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ServerTypecbx.FormattingEnabled = true;
            this.ServerTypecbx.Hint = "Server Type";
            this.ServerTypecbx.IntegralHeight = false;
            this.ServerTypecbx.ItemHeight = 29;
            this.ServerTypecbx.Items.AddRange(new object[] {
            "Database Engine",
            "Analysis Services",
            "Reporting Services",
            "Integration Services",
            "Azure-SSIS Integration Runtime"});
            this.ServerTypecbx.Location = new System.Drawing.Point(35, 13);
            this.ServerTypecbx.MaxDropDownItems = 4;
            this.ServerTypecbx.MouseState = MaterialSkin.MouseState.OUT;
            this.ServerTypecbx.Name = "ServerTypecbx";
            this.ServerTypecbx.Size = new System.Drawing.Size(423, 35);
            this.ServerTypecbx.StartIndex = 0;
            this.ServerTypecbx.TabIndex = 8;
            this.ServerTypecbx.UseTallSize = false;
            // 
            // SaveConnectionbtn
            // 
            this.SaveConnectionbtn.AutoSize = false;
            this.SaveConnectionbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveConnectionbtn.Depth = 0;
            this.SaveConnectionbtn.DrawShadows = true;
            this.SaveConnectionbtn.Enabled = false;
            this.SaveConnectionbtn.HighEmphasis = true;
            this.SaveConnectionbtn.Icon = null;
            this.SaveConnectionbtn.Location = new System.Drawing.Point(151, 268);
            this.SaveConnectionbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveConnectionbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveConnectionbtn.Name = "SaveConnectionbtn";
            this.SaveConnectionbtn.Size = new System.Drawing.Size(118, 34);
            this.SaveConnectionbtn.TabIndex = 7;
            this.SaveConnectionbtn.Text = "Save";
            this.SaveConnectionbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveConnectionbtn.UseAccentColor = false;
            this.SaveConnectionbtn.UseVisualStyleBackColor = true;
            this.SaveConnectionbtn.Click += new System.EventHandler(this.SaveConnectionbtn_Click);
            // 
            // TestConnectionbtn
            // 
            this.TestConnectionbtn.AutoSize = false;
            this.TestConnectionbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TestConnectionbtn.Depth = 0;
            this.TestConnectionbtn.DrawShadows = true;
            this.TestConnectionbtn.HighEmphasis = true;
            this.TestConnectionbtn.Icon = null;
            this.TestConnectionbtn.Location = new System.Drawing.Point(35, 268);
            this.TestConnectionbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TestConnectionbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.TestConnectionbtn.Name = "TestConnectionbtn";
            this.TestConnectionbtn.Size = new System.Drawing.Size(108, 34);
            this.TestConnectionbtn.TabIndex = 6;
            this.TestConnectionbtn.Text = "Test";
            this.TestConnectionbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.TestConnectionbtn.UseAccentColor = false;
            this.TestConnectionbtn.UseVisualStyleBackColor = true;
            this.TestConnectionbtn.Click += new System.EventHandler(this.TestConnectionbtn_Click);
            // 
            // AuthTypecbx
            // 
            this.AuthTypecbx.AutoResize = false;
            this.AuthTypecbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AuthTypecbx.Depth = 0;
            this.AuthTypecbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.AuthTypecbx.DropDownHeight = 118;
            this.AuthTypecbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthTypecbx.DropDownWidth = 121;
            this.AuthTypecbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.AuthTypecbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AuthTypecbx.FormattingEnabled = true;
            this.AuthTypecbx.Hint = "Authentication Type";
            this.AuthTypecbx.IntegralHeight = false;
            this.AuthTypecbx.ItemHeight = 29;
            this.AuthTypecbx.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.AuthTypecbx.Location = new System.Drawing.Point(35, 96);
            this.AuthTypecbx.MaxDropDownItems = 4;
            this.AuthTypecbx.MouseState = MaterialSkin.MouseState.OUT;
            this.AuthTypecbx.Name = "AuthTypecbx";
            this.AuthTypecbx.Size = new System.Drawing.Size(423, 35);
            this.AuthTypecbx.StartIndex = 0;
            this.AuthTypecbx.TabIndex = 5;
            this.AuthTypecbx.UseTallSize = false;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordtxt.Depth = 0;
            this.Passwordtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Passwordtxt.Hint = "Password";
            this.Passwordtxt.Location = new System.Drawing.Point(35, 181);
            this.Passwordtxt.MaxLength = 50;
            this.Passwordtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Passwordtxt.Multiline = false;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Password = true;
            this.Passwordtxt.Size = new System.Drawing.Size(423, 36);
            this.Passwordtxt.TabIndex = 3;
            this.Passwordtxt.Text = "";
            this.Passwordtxt.UseTallSize = false;
            // 
            // Usernametxt
            // 
            this.Usernametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usernametxt.Depth = 0;
            this.Usernametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Usernametxt.Hint = "Username";
            this.Usernametxt.Location = new System.Drawing.Point(35, 139);
            this.Usernametxt.MaxLength = 50;
            this.Usernametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Usernametxt.Multiline = false;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(423, 36);
            this.Usernametxt.TabIndex = 2;
            this.Usernametxt.Text = "";
            this.Usernametxt.UseTallSize = false;
            // 
            // ServerConfigScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 382);
            this.ControlBox = false;
            this.Controls.Add(this.Container);
            this.Name = "ServerConfigScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerConfigScreen";
            this.TopMost = true;
            this.Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGroupBox Container;
        private FontAwesome.Sharp.IconButton RestartAppbtn;
        private MaterialSkin.Controls.MaterialComboBox DatabaseNamecbx;
        private MaterialSkin.Controls.MaterialComboBox ServerNamecbx;
        private MaterialSkin.Controls.MaterialComboBox ServerTypecbx;
        private MaterialSkin.Controls.MaterialButton SaveConnectionbtn;
        private MaterialSkin.Controls.MaterialButton TestConnectionbtn;
        private MaterialSkin.Controls.MaterialComboBox AuthTypecbx;
        private MaterialSkin.Controls.MaterialTextBox Passwordtxt;
        private MaterialSkin.Controls.MaterialTextBox Usernametxt;
        private MaterialSkin.Controls.MaterialButton CleanDb;
    }
}