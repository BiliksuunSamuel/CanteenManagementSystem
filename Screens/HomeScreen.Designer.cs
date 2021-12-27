namespace CanteenManagementSystem.Screens
{
    partial class HomeScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.ParentDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MainContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.Usernamelbl = new MaterialSkin.Controls.MaterialLabel();
            this.Avatar = new FontAwesome.Sharp.IconButton();
            this.AddPaymentGroup = new System.Windows.Forms.GroupBox();
            this.LoadAllPaymentsbtn = new MaterialSkin.Controls.MaterialButton();
            this.Msglbl = new MaterialSkin.Controls.MaterialLabel();
            this.SavePaymentbtn = new MaterialSkin.Controls.MaterialButton();
            this.AmountPaidtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.DatePaidtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Studentscbx = new MaterialSkin.Controls.MaterialComboBox();
            this.Classescbx = new MaterialSkin.Controls.MaterialComboBox();
            this.ControlsGroup = new System.Windows.Forms.GroupBox();
            this.Feesbtn = new MaterialSkin.Controls.MaterialButton();
            this.ConfigureServer = new MaterialSkin.Controls.MaterialButton();
            this.RegisterUserbtn = new MaterialSkin.Controls.MaterialButton();
            this.Amountslbl = new MaterialSkin.Controls.MaterialLabel();
            this.GetPaymentsByfilterbtn = new MaterialSkin.Controls.MaterialButton();
            this.DatePickertxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Refreshdatabtn = new MaterialSkin.Controls.MaterialButton();
            this.ExportDatabtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.FilterClasscbx = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ClassesScreen = new MaterialSkin.Controls.MaterialButton();
            this.StudentsScreen = new MaterialSkin.Controls.MaterialButton();
            this.PaymentstbGroup = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.PaymentstbPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.Paymentstb = new System.Windows.Forms.DataGridView();
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.MainContainer.SuspendLayout();
            this.AddPaymentGroup.SuspendLayout();
            this.ControlsGroup.SuspendLayout();
            this.PaymentstbGroup.SuspendLayout();
            this.PaymentstbPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paymentstb)).BeginInit();
            this.SuspendLayout();
            // 
            // ParentDrag
            // 
            this.ParentDrag.Fixed = true;
            this.ParentDrag.Horizontal = true;
            this.ParentDrag.TargetControl = null;
            this.ParentDrag.Vertical = true;
            // 
            // MainContainer
            // 
            this.MainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContainer.BackgroundColor = System.Drawing.Color.Transparent;
            this.MainContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainContainer.BackgroundImage")));
            this.MainContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainContainer.BorderColor = System.Drawing.Color.Gainsboro;
            this.MainContainer.BorderRadius = 3;
            this.MainContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainContainer.BorderThickness = 1;
            this.MainContainer.Controls.Add(this.Usernamelbl);
            this.MainContainer.Controls.Add(this.Avatar);
            this.MainContainer.Controls.Add(this.AddPaymentGroup);
            this.MainContainer.Controls.Add(this.ControlsGroup);
            this.MainContainer.Controls.Add(this.PaymentstbGroup);
            this.MainContainer.Location = new System.Drawing.Point(21, 6);
            this.MainContainer.Name = "MainContainer";
            this.MainContainer.ShowBorders = true;
            this.MainContainer.Size = new System.Drawing.Size(956, 591);
            this.MainContainer.TabIndex = 0;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.Depth = 0;
            this.Usernamelbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Usernamelbl.Location = new System.Drawing.Point(62, 11);
            this.Usernamelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(71, 19);
            this.Usernamelbl.TabIndex = 7;
            this.Usernamelbl.Text = "username";
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.SystemColors.Window;
            this.Avatar.FlatAppearance.BorderSize = 0;
            this.Avatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Avatar.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Avatar.IconColor = System.Drawing.Color.Gainsboro;
            this.Avatar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Avatar.IconSize = 30;
            this.Avatar.Location = new System.Drawing.Point(13, 10);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(42, 23);
            this.Avatar.TabIndex = 6;
            this.Avatar.UseVisualStyleBackColor = false;
            // 
            // AddPaymentGroup
            // 
            this.AddPaymentGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPaymentGroup.Controls.Add(this.LoadAllPaymentsbtn);
            this.AddPaymentGroup.Controls.Add(this.Msglbl);
            this.AddPaymentGroup.Controls.Add(this.SavePaymentbtn);
            this.AddPaymentGroup.Controls.Add(this.AmountPaidtxt);
            this.AddPaymentGroup.Controls.Add(this.DatePaidtxt);
            this.AddPaymentGroup.Controls.Add(this.Studentscbx);
            this.AddPaymentGroup.Controls.Add(this.Classescbx);
            this.AddPaymentGroup.Location = new System.Drawing.Point(624, 155);
            this.AddPaymentGroup.Name = "AddPaymentGroup";
            this.AddPaymentGroup.Size = new System.Drawing.Size(317, 421);
            this.AddPaymentGroup.TabIndex = 2;
            this.AddPaymentGroup.TabStop = false;
            // 
            // LoadAllPaymentsbtn
            // 
            this.LoadAllPaymentsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadAllPaymentsbtn.AutoSize = false;
            this.LoadAllPaymentsbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadAllPaymentsbtn.Depth = 0;
            this.LoadAllPaymentsbtn.DrawShadows = true;
            this.LoadAllPaymentsbtn.HighEmphasis = true;
            this.LoadAllPaymentsbtn.Icon = null;
            this.LoadAllPaymentsbtn.Location = new System.Drawing.Point(7, 379);
            this.LoadAllPaymentsbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadAllPaymentsbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadAllPaymentsbtn.Name = "LoadAllPaymentsbtn";
            this.LoadAllPaymentsbtn.Size = new System.Drawing.Size(303, 33);
            this.LoadAllPaymentsbtn.TabIndex = 12;
            this.LoadAllPaymentsbtn.Text = "Fetch All Payments";
            this.LoadAllPaymentsbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.LoadAllPaymentsbtn.UseAccentColor = false;
            this.LoadAllPaymentsbtn.UseVisualStyleBackColor = true;
            this.LoadAllPaymentsbtn.Click += new System.EventHandler(this.LoadAllPaymentsbtn_Click);
            // 
            // Msglbl
            // 
            this.Msglbl.Depth = 0;
            this.Msglbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Msglbl.ForeColor = System.Drawing.Color.SeaGreen;
            this.Msglbl.Location = new System.Drawing.Point(6, 273);
            this.Msglbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Msglbl.Name = "Msglbl";
            this.Msglbl.Size = new System.Drawing.Size(305, 23);
            this.Msglbl.TabIndex = 6;
            this.Msglbl.Text = "..";
            this.Msglbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SavePaymentbtn
            // 
            this.SavePaymentbtn.AutoSize = false;
            this.SavePaymentbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SavePaymentbtn.Depth = 0;
            this.SavePaymentbtn.DrawShadows = true;
            this.SavePaymentbtn.HighEmphasis = false;
            this.SavePaymentbtn.Icon = null;
            this.SavePaymentbtn.Location = new System.Drawing.Point(223, 222);
            this.SavePaymentbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SavePaymentbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SavePaymentbtn.Name = "SavePaymentbtn";
            this.SavePaymentbtn.Size = new System.Drawing.Size(77, 37);
            this.SavePaymentbtn.TabIndex = 5;
            this.SavePaymentbtn.Text = "Save";
            this.SavePaymentbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SavePaymentbtn.UseAccentColor = false;
            this.SavePaymentbtn.UseVisualStyleBackColor = true;
            this.SavePaymentbtn.Click += new System.EventHandler(this.SavePaymentbtn_Click);
            // 
            // AmountPaidtxt
            // 
            this.AmountPaidtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountPaidtxt.Depth = 0;
            this.AmountPaidtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.AmountPaidtxt.Hint = "Amount Paid (Ghs)";
            this.AmountPaidtxt.Location = new System.Drawing.Point(20, 217);
            this.AmountPaidtxt.MaxLength = 50;
            this.AmountPaidtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.AmountPaidtxt.Multiline = false;
            this.AmountPaidtxt.Name = "AmountPaidtxt";
            this.AmountPaidtxt.Size = new System.Drawing.Size(196, 50);
            this.AmountPaidtxt.TabIndex = 3;
            this.AmountPaidtxt.Text = "";
            // 
            // DatePaidtxt
            // 
            this.DatePaidtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatePaidtxt.Depth = 0;
            this.DatePaidtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.DatePaidtxt.Hint = "Date Paid";
            this.DatePaidtxt.Location = new System.Drawing.Point(20, 152);
            this.DatePaidtxt.MaxLength = 50;
            this.DatePaidtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DatePaidtxt.Multiline = false;
            this.DatePaidtxt.Name = "DatePaidtxt";
            this.DatePaidtxt.Size = new System.Drawing.Size(280, 50);
            this.DatePaidtxt.TabIndex = 2;
            this.DatePaidtxt.Text = "";
            // 
            // Studentscbx
            // 
            this.Studentscbx.AutoResize = false;
            this.Studentscbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Studentscbx.Depth = 0;
            this.Studentscbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Studentscbx.DropDownHeight = 174;
            this.Studentscbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Studentscbx.DropDownWidth = 121;
            this.Studentscbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Studentscbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Studentscbx.FormattingEnabled = true;
            this.Studentscbx.Hint = "Student";
            this.Studentscbx.IntegralHeight = false;
            this.Studentscbx.ItemHeight = 43;
            this.Studentscbx.Location = new System.Drawing.Point(20, 97);
            this.Studentscbx.MaxDropDownItems = 4;
            this.Studentscbx.MouseState = MaterialSkin.MouseState.OUT;
            this.Studentscbx.Name = "Studentscbx";
            this.Studentscbx.Size = new System.Drawing.Size(280, 49);
            this.Studentscbx.StartIndex = 0;
            this.Studentscbx.TabIndex = 1;
            // 
            // Classescbx
            // 
            this.Classescbx.AutoResize = false;
            this.Classescbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Classescbx.Depth = 0;
            this.Classescbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Classescbx.DropDownHeight = 174;
            this.Classescbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Classescbx.DropDownWidth = 121;
            this.Classescbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Classescbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Classescbx.FormattingEnabled = true;
            this.Classescbx.Hint = "Class";
            this.Classescbx.IntegralHeight = false;
            this.Classescbx.ItemHeight = 43;
            this.Classescbx.Location = new System.Drawing.Point(20, 33);
            this.Classescbx.MaxDropDownItems = 4;
            this.Classescbx.MouseState = MaterialSkin.MouseState.OUT;
            this.Classescbx.Name = "Classescbx";
            this.Classescbx.Size = new System.Drawing.Size(280, 49);
            this.Classescbx.StartIndex = 0;
            this.Classescbx.TabIndex = 0;
            this.Classescbx.SelectedIndexChanged += new System.EventHandler(this.Classescbx_SelectedIndexChanged);
            // 
            // ControlsGroup
            // 
            this.ControlsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsGroup.Controls.Add(this.Feesbtn);
            this.ControlsGroup.Controls.Add(this.ConfigureServer);
            this.ControlsGroup.Controls.Add(this.RegisterUserbtn);
            this.ControlsGroup.Controls.Add(this.Amountslbl);
            this.ControlsGroup.Controls.Add(this.GetPaymentsByfilterbtn);
            this.ControlsGroup.Controls.Add(this.DatePickertxt);
            this.ControlsGroup.Controls.Add(this.Refreshdatabtn);
            this.ControlsGroup.Controls.Add(this.ExportDatabtn);
            this.ControlsGroup.Controls.Add(this.materialLabel2);
            this.ControlsGroup.Controls.Add(this.materialLabel1);
            this.ControlsGroup.Controls.Add(this.FilterClasscbx);
            this.ControlsGroup.Controls.Add(this.ClassesScreen);
            this.ControlsGroup.Controls.Add(this.StudentsScreen);
            this.ControlsGroup.Location = new System.Drawing.Point(13, 39);
            this.ControlsGroup.Name = "ControlsGroup";
            this.ControlsGroup.Size = new System.Drawing.Size(928, 116);
            this.ControlsGroup.TabIndex = 1;
            this.ControlsGroup.TabStop = false;
            // 
            // Feesbtn
            // 
            this.Feesbtn.AutoSize = false;
            this.Feesbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Feesbtn.Depth = 0;
            this.Feesbtn.DrawShadows = true;
            this.Feesbtn.HighEmphasis = true;
            this.Feesbtn.Icon = null;
            this.Feesbtn.Location = new System.Drawing.Point(468, 16);
            this.Feesbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Feesbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Feesbtn.Name = "Feesbtn";
            this.Feesbtn.Size = new System.Drawing.Size(102, 33);
            this.Feesbtn.TabIndex = 14;
            this.Feesbtn.Text = "Fees";
            this.Feesbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Feesbtn.UseAccentColor = false;
            this.Feesbtn.UseVisualStyleBackColor = true;
            this.Feesbtn.Click += new System.EventHandler(this.Feesbtn_Click);
            // 
            // ConfigureServer
            // 
            this.ConfigureServer.AutoSize = false;
            this.ConfigureServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ConfigureServer.Depth = 0;
            this.ConfigureServer.DrawShadows = true;
            this.ConfigureServer.HighEmphasis = true;
            this.ConfigureServer.Icon = null;
            this.ConfigureServer.Location = new System.Drawing.Point(578, 15);
            this.ConfigureServer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ConfigureServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.ConfigureServer.Name = "ConfigureServer";
            this.ConfigureServer.Size = new System.Drawing.Size(103, 33);
            this.ConfigureServer.TabIndex = 13;
            this.ConfigureServer.Text = "Server";
            this.ConfigureServer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ConfigureServer.UseAccentColor = false;
            this.ConfigureServer.UseVisualStyleBackColor = true;
            this.ConfigureServer.Click += new System.EventHandler(this.ConfigureServer_Click);
            // 
            // RegisterUserbtn
            // 
            this.RegisterUserbtn.AutoSize = false;
            this.RegisterUserbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterUserbtn.Depth = 0;
            this.RegisterUserbtn.DrawShadows = true;
            this.RegisterUserbtn.HighEmphasis = true;
            this.RegisterUserbtn.Icon = null;
            this.RegisterUserbtn.Location = new System.Drawing.Point(336, 16);
            this.RegisterUserbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterUserbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterUserbtn.Name = "RegisterUserbtn";
            this.RegisterUserbtn.Size = new System.Drawing.Size(124, 33);
            this.RegisterUserbtn.TabIndex = 12;
            this.RegisterUserbtn.Text = "Register User";
            this.RegisterUserbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.RegisterUserbtn.UseAccentColor = false;
            this.RegisterUserbtn.UseVisualStyleBackColor = true;
            this.RegisterUserbtn.Click += new System.EventHandler(this.RegisterUserbtn_Click);
            // 
            // Amountslbl
            // 
            this.Amountslbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Amountslbl.Depth = 0;
            this.Amountslbl.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Amountslbl.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.Amountslbl.Location = new System.Drawing.Point(688, 16);
            this.Amountslbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Amountslbl.Name = "Amountslbl";
            this.Amountslbl.Size = new System.Drawing.Size(223, 27);
            this.Amountslbl.TabIndex = 11;
            this.Amountslbl.Text = "00.00";
            this.Amountslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GetPaymentsByfilterbtn
            // 
            this.GetPaymentsByfilterbtn.AutoSize = false;
            this.GetPaymentsByfilterbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GetPaymentsByfilterbtn.Depth = 0;
            this.GetPaymentsByfilterbtn.DrawShadows = true;
            this.GetPaymentsByfilterbtn.HighEmphasis = true;
            this.GetPaymentsByfilterbtn.Icon = null;
            this.GetPaymentsByfilterbtn.Location = new System.Drawing.Point(312, 77);
            this.GetPaymentsByfilterbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GetPaymentsByfilterbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.GetPaymentsByfilterbtn.Name = "GetPaymentsByfilterbtn";
            this.GetPaymentsByfilterbtn.Size = new System.Drawing.Size(71, 33);
            this.GetPaymentsByfilterbtn.TabIndex = 9;
            this.GetPaymentsByfilterbtn.Text = "GET";
            this.GetPaymentsByfilterbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.GetPaymentsByfilterbtn.UseAccentColor = false;
            this.GetPaymentsByfilterbtn.UseVisualStyleBackColor = true;
            this.GetPaymentsByfilterbtn.Click += new System.EventHandler(this.GetPaymentsByfilterbtn_Click);
            // 
            // DatePickertxt
            // 
            this.DatePickertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatePickertxt.Depth = 0;
            this.DatePickertxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.DatePickertxt.Location = new System.Drawing.Point(569, 73);
            this.DatePickertxt.MaxLength = 50;
            this.DatePickertxt.MouseState = MaterialSkin.MouseState.OUT;
            this.DatePickertxt.Multiline = false;
            this.DatePickertxt.Name = "DatePickertxt";
            this.DatePickertxt.Size = new System.Drawing.Size(154, 36);
            this.DatePickertxt.TabIndex = 7;
            this.DatePickertxt.Text = "";
            this.DatePickertxt.UseTallSize = false;
            this.DatePickertxt.TextChanged += new System.EventHandler(this.DatePickertxt_TextChanged);
            // 
            // Refreshdatabtn
            // 
            this.Refreshdatabtn.AutoSize = false;
            this.Refreshdatabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Refreshdatabtn.Depth = 0;
            this.Refreshdatabtn.DrawShadows = true;
            this.Refreshdatabtn.HighEmphasis = true;
            this.Refreshdatabtn.Icon = null;
            this.Refreshdatabtn.Location = new System.Drawing.Point(231, 15);
            this.Refreshdatabtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Refreshdatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Refreshdatabtn.Name = "Refreshdatabtn";
            this.Refreshdatabtn.Size = new System.Drawing.Size(97, 33);
            this.Refreshdatabtn.TabIndex = 8;
            this.Refreshdatabtn.Text = "Refresh";
            this.Refreshdatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Refreshdatabtn.UseAccentColor = false;
            this.Refreshdatabtn.UseVisualStyleBackColor = true;
            this.Refreshdatabtn.Click += new System.EventHandler(this.Refreshdatabtn_Click);
            // 
            // ExportDatabtn
            // 
            this.ExportDatabtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportDatabtn.AutoSize = false;
            this.ExportDatabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportDatabtn.Depth = 0;
            this.ExportDatabtn.DrawShadows = true;
            this.ExportDatabtn.HighEmphasis = true;
            this.ExportDatabtn.Icon = null;
            this.ExportDatabtn.Location = new System.Drawing.Point(806, 71);
            this.ExportDatabtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExportDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDatabtn.Name = "ExportDatabtn";
            this.ExportDatabtn.Size = new System.Drawing.Size(105, 33);
            this.ExportDatabtn.TabIndex = 7;
            this.ExportDatabtn.Text = "Export Data";
            this.ExportDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ExportDatabtn.UseAccentColor = false;
            this.ExportDatabtn.UseVisualStyleBackColor = true;
            this.ExportDatabtn.Click += new System.EventHandler(this.ExportDatabtn_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(469, 83);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Filter by Date";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(7, 86);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Filter by Class";
            // 
            // FilterClasscbx
            // 
            this.FilterClasscbx.BackColor = System.Drawing.Color.Transparent;
            this.FilterClasscbx.BackgroundColor = System.Drawing.Color.White;
            this.FilterClasscbx.BorderColor = System.Drawing.Color.Silver;
            this.FilterClasscbx.BorderRadius = 1;
            this.FilterClasscbx.Color = System.Drawing.Color.Silver;
            this.FilterClasscbx.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.FilterClasscbx.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FilterClasscbx.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FilterClasscbx.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FilterClasscbx.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FilterClasscbx.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.FilterClasscbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterClasscbx.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.FilterClasscbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterClasscbx.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.FilterClasscbx.FillDropDown = true;
            this.FilterClasscbx.FillIndicator = false;
            this.FilterClasscbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterClasscbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterClasscbx.ForeColor = System.Drawing.Color.Black;
            this.FilterClasscbx.FormattingEnabled = true;
            this.FilterClasscbx.Icon = null;
            this.FilterClasscbx.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.FilterClasscbx.IndicatorColor = System.Drawing.Color.Gray;
            this.FilterClasscbx.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.FilterClasscbx.ItemBackColor = System.Drawing.Color.White;
            this.FilterClasscbx.ItemBorderColor = System.Drawing.Color.White;
            this.FilterClasscbx.ItemForeColor = System.Drawing.Color.Black;
            this.FilterClasscbx.ItemHeight = 26;
            this.FilterClasscbx.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.FilterClasscbx.ItemHighLightForeColor = System.Drawing.Color.White;
            this.FilterClasscbx.ItemTopMargin = 3;
            this.FilterClasscbx.Location = new System.Drawing.Point(113, 77);
            this.FilterClasscbx.Name = "FilterClasscbx";
            this.FilterClasscbx.Size = new System.Drawing.Size(192, 32);
            this.FilterClasscbx.TabIndex = 3;
            this.FilterClasscbx.Text = null;
            this.FilterClasscbx.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.FilterClasscbx.TextLeftMargin = 5;
            // 
            // ClassesScreen
            // 
            this.ClassesScreen.AutoSize = false;
            this.ClassesScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClassesScreen.Depth = 0;
            this.ClassesScreen.DrawShadows = true;
            this.ClassesScreen.HighEmphasis = true;
            this.ClassesScreen.Icon = null;
            this.ClassesScreen.Location = new System.Drawing.Point(128, 14);
            this.ClassesScreen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ClassesScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.ClassesScreen.Name = "ClassesScreen";
            this.ClassesScreen.Size = new System.Drawing.Size(95, 33);
            this.ClassesScreen.TabIndex = 2;
            this.ClassesScreen.Text = "Classes";
            this.ClassesScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ClassesScreen.UseAccentColor = false;
            this.ClassesScreen.UseVisualStyleBackColor = true;
            this.ClassesScreen.Click += new System.EventHandler(this.ClassesScreen_Click);
            // 
            // StudentsScreen
            // 
            this.StudentsScreen.AutoSize = false;
            this.StudentsScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StudentsScreen.Depth = 0;
            this.StudentsScreen.DrawShadows = true;
            this.StudentsScreen.HighEmphasis = true;
            this.StudentsScreen.Icon = null;
            this.StudentsScreen.Location = new System.Drawing.Point(18, 14);
            this.StudentsScreen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StudentsScreen.MouseState = MaterialSkin.MouseState.HOVER;
            this.StudentsScreen.Name = "StudentsScreen";
            this.StudentsScreen.Size = new System.Drawing.Size(102, 33);
            this.StudentsScreen.TabIndex = 1;
            this.StudentsScreen.Text = "Students";
            this.StudentsScreen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.StudentsScreen.UseAccentColor = false;
            this.StudentsScreen.UseVisualStyleBackColor = true;
            this.StudentsScreen.Click += new System.EventHandler(this.StudentsScreen_Click);
            // 
            // PaymentstbGroup
            // 
            this.PaymentstbGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentstbGroup.BorderColor = System.Drawing.Color.LightGray;
            this.PaymentstbGroup.BorderRadius = 1;
            this.PaymentstbGroup.BorderThickness = 1;
            this.PaymentstbGroup.Controls.Add(this.PaymentstbPanel);
            this.PaymentstbGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PaymentstbGroup.LabelAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PaymentstbGroup.LabelIndent = 10;
            this.PaymentstbGroup.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.PaymentstbGroup.Location = new System.Drawing.Point(13, 155);
            this.PaymentstbGroup.Name = "PaymentstbGroup";
            this.PaymentstbGroup.Size = new System.Drawing.Size(605, 421);
            this.PaymentstbGroup.TabIndex = 0;
            this.PaymentstbGroup.TabStop = false;
            // 
            // PaymentstbPanel
            // 
            this.PaymentstbPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentstbPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.PaymentstbPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentstbPanel.BackgroundImage")));
            this.PaymentstbPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PaymentstbPanel.BorderColor = System.Drawing.Color.LightGray;
            this.PaymentstbPanel.BorderRadius = 3;
            this.PaymentstbPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PaymentstbPanel.BorderThickness = 1;
            this.PaymentstbPanel.Controls.Add(this.Paymentstb);
            this.PaymentstbPanel.Location = new System.Drawing.Point(18, 19);
            this.PaymentstbPanel.Name = "PaymentstbPanel";
            this.PaymentstbPanel.ShowBorders = true;
            this.PaymentstbPanel.Size = new System.Drawing.Size(572, 396);
            this.PaymentstbPanel.TabIndex = 0;
            // 
            // Paymentstb
            // 
            this.Paymentstb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Paymentstb.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Paymentstb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Paymentstb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Paymentstb.Location = new System.Drawing.Point(0, 0);
            this.Paymentstb.Name = "Paymentstb";
            this.Paymentstb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Paymentstb.Size = new System.Drawing.Size(568, 392);
            this.Paymentstb.TabIndex = 0;
            // 
            // MsgTimer
            // 
            this.MsgTimer.Enabled = true;
            this.MsgTimer.Interval = 5000;
            this.MsgTimer.Tick += new System.EventHandler(this.MsgTimer_Tick);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.MainContainer);
            this.MinimizeBox = false;
            this.Name = "HomeScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CANTEEN MANAGEMENT SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.MainContainer.ResumeLayout(false);
            this.MainContainer.PerformLayout();
            this.AddPaymentGroup.ResumeLayout(false);
            this.ControlsGroup.ResumeLayout(false);
            this.ControlsGroup.PerformLayout();
            this.PaymentstbGroup.ResumeLayout(false);
            this.PaymentstbPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Paymentstb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl ParentDrag;
        private Bunifu.UI.WinForms.BunifuPanel MainContainer;
        private Bunifu.UI.WinForms.BunifuGroupBox PaymentstbGroup;
        private System.Windows.Forms.GroupBox AddPaymentGroup;
        private System.Windows.Forms.GroupBox ControlsGroup;
        private Bunifu.UI.WinForms.BunifuPanel PaymentstbPanel;
        private System.Windows.Forms.DataGridView Paymentstb;
        private MaterialSkin.Controls.MaterialButton SavePaymentbtn;
        private MaterialSkin.Controls.MaterialTextBox AmountPaidtxt;
        private MaterialSkin.Controls.MaterialTextBox DatePaidtxt;
        private MaterialSkin.Controls.MaterialComboBox Studentscbx;
        private MaterialSkin.Controls.MaterialComboBox Classescbx;
        private MaterialSkin.Controls.MaterialButton ClassesScreen;
        private MaterialSkin.Controls.MaterialButton StudentsScreen;
        private MaterialSkin.Controls.MaterialLabel Msglbl;
        private System.Windows.Forms.Timer MsgTimer;
        private MaterialSkin.Controls.MaterialButton ExportDatabtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown FilterClasscbx;
        private MaterialSkin.Controls.MaterialButton Refreshdatabtn;
        private MaterialSkin.Controls.MaterialTextBox DatePickertxt;
        private MaterialSkin.Controls.MaterialButton GetPaymentsByfilterbtn;
        private MaterialSkin.Controls.MaterialLabel Amountslbl;
        private MaterialSkin.Controls.MaterialButton LoadAllPaymentsbtn;
        private MaterialSkin.Controls.MaterialButton RegisterUserbtn;
        private MaterialSkin.Controls.MaterialButton ConfigureServer;
        private MaterialSkin.Controls.MaterialLabel Usernamelbl;
        private FontAwesome.Sharp.IconButton Avatar;
        private MaterialSkin.Controls.MaterialButton Feesbtn;
    }
}