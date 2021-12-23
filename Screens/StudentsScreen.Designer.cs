namespace CanteenManagementSystem.Screens
{
    partial class StudentsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsScreen));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.Container = new Bunifu.UI.WinForms.BunifuPanel();
            this.TableGroup = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.StudentstbContainer = new Bunifu.UI.WinForms.BunifuPanel();
            this.TbStudents = new System.Windows.Forms.DataGridView();
            this.ActionsGroup = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.FilterStudentscbx = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ReloadDatabtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.ExportDatabtn = new MaterialSkin.Controls.MaterialButton();
            this.Searchtxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.USclasstxt = new MaterialSkin.Controls.MaterialTextBox();
            this.USgendertxt = new MaterialSkin.Controls.MaterialTextBox();
            this.USphonetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.USnametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.SavebyFilebtn = new MaterialSkin.Controls.MaterialButton();
            this.Choosefilebtn = new MaterialSkin.Controls.MaterialButton();
            this.ChooseFromFilelbl = new MaterialSkin.Controls.MaterialLabel();
            this.DeleteStdbtn = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.Savebtn = new MaterialSkin.Controls.MaterialButton();
            this.Sclasscbx = new MaterialSkin.Controls.MaterialComboBox();
            this.Sgendercbx = new MaterialSkin.Controls.MaterialComboBox();
            this.Sidtxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Sphonetxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Snametxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Closebtn = new MaterialSkin.Controls.MaterialButton();
            this.Msglbl = new Bunifu.UI.WinForms.BunifuLabel();
            this.MsgTimer = new System.Windows.Forms.Timer(this.components);
            this.StudentEditcbx = new MaterialSkin.Controls.MaterialCheckbox();
            this.Container.SuspendLayout();
            this.TableGroup.SuspendLayout();
            this.StudentstbContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbStudents)).BeginInit();
            this.ActionsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BackgroundColor = System.Drawing.Color.Transparent;
            this.Container.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Container.BackgroundImage")));
            this.Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Container.BorderColor = System.Drawing.Color.Silver;
            this.Container.BorderRadius = 3;
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container.BorderThickness = 1;
            this.Container.Controls.Add(this.TableGroup);
            this.Container.Controls.Add(this.ActionsGroup);
            this.Container.Location = new System.Drawing.Point(15, 43);
            this.Container.Name = "Container";
            this.Container.ShowBorders = true;
            this.Container.Size = new System.Drawing.Size(984, 587);
            this.Container.TabIndex = 0;
            // 
            // TableGroup
            // 
            this.TableGroup.BorderColor = System.Drawing.Color.LightGray;
            this.TableGroup.BorderRadius = 1;
            this.TableGroup.BorderThickness = 1;
            this.TableGroup.Controls.Add(this.StudentstbContainer);
            this.TableGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TableGroup.LabelAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TableGroup.LabelIndent = 10;
            this.TableGroup.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.TableGroup.Location = new System.Drawing.Point(17, 261);
            this.TableGroup.Name = "TableGroup";
            this.TableGroup.Size = new System.Drawing.Size(948, 312);
            this.TableGroup.TabIndex = 1;
            this.TableGroup.TabStop = false;
            this.TableGroup.Text = "Students";
            // 
            // StudentstbContainer
            // 
            this.StudentstbContainer.BackgroundColor = System.Drawing.Color.Transparent;
            this.StudentstbContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StudentstbContainer.BackgroundImage")));
            this.StudentstbContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StudentstbContainer.BorderColor = System.Drawing.Color.Gainsboro;
            this.StudentstbContainer.BorderRadius = 3;
            this.StudentstbContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StudentstbContainer.BorderThickness = 1;
            this.StudentstbContainer.Controls.Add(this.TbStudents);
            this.StudentstbContainer.Location = new System.Drawing.Point(9, 15);
            this.StudentstbContainer.Name = "StudentstbContainer";
            this.StudentstbContainer.ShowBorders = true;
            this.StudentstbContainer.Size = new System.Drawing.Size(933, 285);
            this.StudentstbContainer.TabIndex = 0;
            // 
            // TbStudents
            // 
            this.TbStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TbStudents.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TbStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbStudents.GridColor = System.Drawing.Color.Gray;
            this.TbStudents.Location = new System.Drawing.Point(0, 0);
            this.TbStudents.Name = "TbStudents";
            this.TbStudents.ReadOnly = true;
            this.TbStudents.Size = new System.Drawing.Size(929, 281);
            this.TbStudents.TabIndex = 0;
            this.TbStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbStudents_CellClick);
            this.TbStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TbStudents_CellContentClick);
            // 
            // ActionsGroup
            // 
            this.ActionsGroup.BorderColor = System.Drawing.Color.LightGray;
            this.ActionsGroup.BorderRadius = 1;
            this.ActionsGroup.BorderThickness = 1;
            this.ActionsGroup.Controls.Add(this.StudentEditcbx);
            this.ActionsGroup.Controls.Add(this.FilterStudentscbx);
            this.ActionsGroup.Controls.Add(this.ReloadDatabtn);
            this.ActionsGroup.Controls.Add(this.materialLabel1);
            this.ActionsGroup.Controls.Add(this.ExportDatabtn);
            this.ActionsGroup.Controls.Add(this.Searchtxt);
            this.ActionsGroup.Controls.Add(this.USclasstxt);
            this.ActionsGroup.Controls.Add(this.USgendertxt);
            this.ActionsGroup.Controls.Add(this.USphonetxt);
            this.ActionsGroup.Controls.Add(this.USnametxt);
            this.ActionsGroup.Controls.Add(this.SavebyFilebtn);
            this.ActionsGroup.Controls.Add(this.Choosefilebtn);
            this.ActionsGroup.Controls.Add(this.ChooseFromFilelbl);
            this.ActionsGroup.Controls.Add(this.DeleteStdbtn);
            this.ActionsGroup.Controls.Add(this.materialButton1);
            this.ActionsGroup.Controls.Add(this.Savebtn);
            this.ActionsGroup.Controls.Add(this.Sclasscbx);
            this.ActionsGroup.Controls.Add(this.Sgendercbx);
            this.ActionsGroup.Controls.Add(this.Sidtxt);
            this.ActionsGroup.Controls.Add(this.Sphonetxt);
            this.ActionsGroup.Controls.Add(this.Snametxt);
            this.ActionsGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ActionsGroup.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ActionsGroup.LabelIndent = 10;
            this.ActionsGroup.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.ActionsGroup.Location = new System.Drawing.Point(17, 13);
            this.ActionsGroup.Name = "ActionsGroup";
            this.ActionsGroup.Size = new System.Drawing.Size(948, 242);
            this.ActionsGroup.TabIndex = 0;
            this.ActionsGroup.TabStop = false;
            this.ActionsGroup.Text = "Actions";
            // 
            // FilterStudentscbx
            // 
            this.FilterStudentscbx.BackColor = System.Drawing.Color.Transparent;
            this.FilterStudentscbx.BackgroundColor = System.Drawing.Color.White;
            this.FilterStudentscbx.BorderColor = System.Drawing.Color.Silver;
            this.FilterStudentscbx.BorderRadius = 1;
            this.FilterStudentscbx.Color = System.Drawing.Color.Silver;
            this.FilterStudentscbx.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.FilterStudentscbx.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FilterStudentscbx.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FilterStudentscbx.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FilterStudentscbx.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FilterStudentscbx.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.FilterStudentscbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FilterStudentscbx.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.FilterStudentscbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterStudentscbx.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.FilterStudentscbx.FillDropDown = true;
            this.FilterStudentscbx.FillIndicator = false;
            this.FilterStudentscbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterStudentscbx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterStudentscbx.ForeColor = System.Drawing.Color.Black;
            this.FilterStudentscbx.FormattingEnabled = true;
            this.FilterStudentscbx.Icon = null;
            this.FilterStudentscbx.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.FilterStudentscbx.IndicatorColor = System.Drawing.Color.Gray;
            this.FilterStudentscbx.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.FilterStudentscbx.ItemBackColor = System.Drawing.Color.White;
            this.FilterStudentscbx.ItemBorderColor = System.Drawing.Color.White;
            this.FilterStudentscbx.ItemForeColor = System.Drawing.Color.Black;
            this.FilterStudentscbx.ItemHeight = 26;
            this.FilterStudentscbx.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.FilterStudentscbx.ItemHighLightForeColor = System.Drawing.Color.White;
            this.FilterStudentscbx.ItemTopMargin = 3;
            this.FilterStudentscbx.Location = new System.Drawing.Point(674, 106);
            this.FilterStudentscbx.Name = "FilterStudentscbx";
            this.FilterStudentscbx.Size = new System.Drawing.Size(257, 32);
            this.FilterStudentscbx.TabIndex = 23;
            this.FilterStudentscbx.Text = null;
            this.FilterStudentscbx.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.FilterStudentscbx.TextLeftMargin = 5;
            this.FilterStudentscbx.SelectedIndexChanged += new System.EventHandler(this.FilterStudentscbx_SelectedIndexChanged_1);
            // 
            // ReloadDatabtn
            // 
            this.ReloadDatabtn.AutoSize = false;
            this.ReloadDatabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ReloadDatabtn.Depth = 0;
            this.ReloadDatabtn.DrawShadows = true;
            this.ReloadDatabtn.HighEmphasis = false;
            this.ReloadDatabtn.Icon = null;
            this.ReloadDatabtn.Location = new System.Drawing.Point(191, 188);
            this.ReloadDatabtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ReloadDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReloadDatabtn.Name = "ReloadDatabtn";
            this.ReloadDatabtn.Size = new System.Drawing.Size(105, 35);
            this.ReloadDatabtn.TabIndex = 22;
            this.ReloadDatabtn.Text = "Refresh";
            this.ReloadDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ReloadDatabtn.UseAccentColor = false;
            this.ReloadDatabtn.UseVisualStyleBackColor = true;
            this.ReloadDatabtn.Click += new System.EventHandler(this.ReloadDatabtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(632, 116);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(36, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Filter";
            // 
            // ExportDatabtn
            // 
            this.ExportDatabtn.AutoSize = false;
            this.ExportDatabtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExportDatabtn.Depth = 0;
            this.ExportDatabtn.DrawShadows = true;
            this.ExportDatabtn.HighEmphasis = false;
            this.ExportDatabtn.Icon = null;
            this.ExportDatabtn.Location = new System.Drawing.Point(635, 145);
            this.ExportDatabtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExportDatabtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExportDatabtn.Name = "ExportDatabtn";
            this.ExportDatabtn.Size = new System.Drawing.Size(296, 35);
            this.ExportDatabtn.TabIndex = 19;
            this.ExportDatabtn.Text = "Export Data";
            this.ExportDatabtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ExportDatabtn.UseAccentColor = false;
            this.ExportDatabtn.UseVisualStyleBackColor = true;
            this.ExportDatabtn.Click += new System.EventHandler(this.ExportDatabtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.AcceptsReturn = false;
            this.Searchtxt.AcceptsTab = false;
            this.Searchtxt.AnimationSpeed = 200;
            this.Searchtxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Searchtxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Searchtxt.BackColor = System.Drawing.Color.Transparent;
            this.Searchtxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchtxt.BackgroundImage")));
            this.Searchtxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Searchtxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Searchtxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Searchtxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.Searchtxt.BorderRadius = 1;
            this.Searchtxt.BorderThickness = 1;
            this.Searchtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Searchtxt.DefaultText = "";
            this.Searchtxt.FillColor = System.Drawing.Color.White;
            this.Searchtxt.HideSelection = true;
            this.Searchtxt.IconLeft = null;
            this.Searchtxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.IconPadding = 10;
            this.Searchtxt.IconRight = null;
            this.Searchtxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Searchtxt.Lines = new string[0];
            this.Searchtxt.Location = new System.Drawing.Point(635, 186);
            this.Searchtxt.MaxLength = 32767;
            this.Searchtxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.Searchtxt.Modified = false;
            this.Searchtxt.Multiline = false;
            this.Searchtxt.Name = "Searchtxt";
            stateProperties17.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Searchtxt.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Searchtxt.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Searchtxt.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.Silver;
            stateProperties20.FillColor = System.Drawing.Color.White;
            stateProperties20.ForeColor = System.Drawing.Color.Empty;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Searchtxt.OnIdleState = stateProperties20;
            this.Searchtxt.Padding = new System.Windows.Forms.Padding(3);
            this.Searchtxt.PasswordChar = '\0';
            this.Searchtxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Searchtxt.PlaceholderText = "Search .......";
            this.Searchtxt.ReadOnly = false;
            this.Searchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Searchtxt.SelectedText = "";
            this.Searchtxt.SelectionLength = 0;
            this.Searchtxt.SelectionStart = 0;
            this.Searchtxt.ShortcutsEnabled = true;
            this.Searchtxt.Size = new System.Drawing.Size(296, 37);
            this.Searchtxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Searchtxt.TabIndex = 17;
            this.Searchtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Searchtxt.TextMarginBottom = 0;
            this.Searchtxt.TextMarginLeft = 3;
            this.Searchtxt.TextMarginTop = 0;
            this.Searchtxt.TextPlaceholder = "Search .......";
            this.Searchtxt.UseSystemPasswordChar = false;
            this.Searchtxt.WordWrap = true;
            this.Searchtxt.TextChanged += new System.EventHandler(this.Searchtxt_TextChanged);
            // 
            // USclasstxt
            // 
            this.USclasstxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USclasstxt.Depth = 0;
            this.USclasstxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.USclasstxt.Hint = "Class";
            this.USclasstxt.Location = new System.Drawing.Point(331, 106);
            this.USclasstxt.MaxLength = 50;
            this.USclasstxt.MouseState = MaterialSkin.MouseState.OUT;
            this.USclasstxt.Multiline = false;
            this.USclasstxt.Name = "USclasstxt";
            this.USclasstxt.ReadOnly = true;
            this.USclasstxt.Size = new System.Drawing.Size(290, 36);
            this.USclasstxt.TabIndex = 16;
            this.USclasstxt.Text = "";
            this.USclasstxt.UseTallSize = false;
            // 
            // USgendertxt
            // 
            this.USgendertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USgendertxt.Depth = 0;
            this.USgendertxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.USgendertxt.Hint = "Gender";
            this.USgendertxt.Location = new System.Drawing.Point(465, 148);
            this.USgendertxt.MaxLength = 50;
            this.USgendertxt.MouseState = MaterialSkin.MouseState.OUT;
            this.USgendertxt.Multiline = false;
            this.USgendertxt.Name = "USgendertxt";
            this.USgendertxt.ReadOnly = true;
            this.USgendertxt.Size = new System.Drawing.Size(156, 36);
            this.USgendertxt.TabIndex = 15;
            this.USgendertxt.Text = "";
            this.USgendertxt.UseTallSize = false;
            // 
            // USphonetxt
            // 
            this.USphonetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USphonetxt.Depth = 0;
            this.USphonetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.USphonetxt.Hint = "Contact";
            this.USphonetxt.Location = new System.Drawing.Point(331, 64);
            this.USphonetxt.MaxLength = 50;
            this.USphonetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.USphonetxt.Multiline = false;
            this.USphonetxt.Name = "USphonetxt";
            this.USphonetxt.Size = new System.Drawing.Size(290, 36);
            this.USphonetxt.TabIndex = 14;
            this.USphonetxt.Text = "";
            this.USphonetxt.UseTallSize = false;
            // 
            // USnametxt
            // 
            this.USnametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USnametxt.Depth = 0;
            this.USnametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.USnametxt.Hint = "Student Name";
            this.USnametxt.Location = new System.Drawing.Point(331, 22);
            this.USnametxt.MaxLength = 50;
            this.USnametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.USnametxt.Multiline = false;
            this.USnametxt.Name = "USnametxt";
            this.USnametxt.Size = new System.Drawing.Size(290, 36);
            this.USnametxt.TabIndex = 13;
            this.USnametxt.Text = "";
            this.USnametxt.UseTallSize = false;
            // 
            // SavebyFilebtn
            // 
            this.SavebyFilebtn.AutoSize = false;
            this.SavebyFilebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SavebyFilebtn.Depth = 0;
            this.SavebyFilebtn.DrawShadows = true;
            this.SavebyFilebtn.Enabled = false;
            this.SavebyFilebtn.HighEmphasis = false;
            this.SavebyFilebtn.Icon = null;
            this.SavebyFilebtn.Location = new System.Drawing.Point(787, 49);
            this.SavebyFilebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SavebyFilebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SavebyFilebtn.Name = "SavebyFilebtn";
            this.SavebyFilebtn.Size = new System.Drawing.Size(144, 35);
            this.SavebyFilebtn.TabIndex = 12;
            this.SavebyFilebtn.Text = "Submit";
            this.SavebyFilebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.SavebyFilebtn.UseAccentColor = false;
            this.SavebyFilebtn.UseVisualStyleBackColor = true;
            // 
            // Choosefilebtn
            // 
            this.Choosefilebtn.AutoSize = false;
            this.Choosefilebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Choosefilebtn.Depth = 0;
            this.Choosefilebtn.DrawShadows = true;
            this.Choosefilebtn.Enabled = false;
            this.Choosefilebtn.HighEmphasis = false;
            this.Choosefilebtn.Icon = null;
            this.Choosefilebtn.Location = new System.Drawing.Point(635, 49);
            this.Choosefilebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Choosefilebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Choosefilebtn.Name = "Choosefilebtn";
            this.Choosefilebtn.Size = new System.Drawing.Size(137, 35);
            this.Choosefilebtn.TabIndex = 11;
            this.Choosefilebtn.Text = "Choose file";
            this.Choosefilebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Choosefilebtn.UseAccentColor = false;
            this.Choosefilebtn.UseVisualStyleBackColor = true;
            // 
            // ChooseFromFilelbl
            // 
            this.ChooseFromFilelbl.AutoSize = true;
            this.ChooseFromFilelbl.Depth = 0;
            this.ChooseFromFilelbl.Enabled = false;
            this.ChooseFromFilelbl.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ChooseFromFilelbl.Location = new System.Drawing.Point(700, 25);
            this.ChooseFromFilelbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChooseFromFilelbl.Name = "ChooseFromFilelbl";
            this.ChooseFromFilelbl.Size = new System.Drawing.Size(158, 19);
            this.ChooseFromFilelbl.TabIndex = 10;
            this.ChooseFromFilelbl.Text = "Add Student From File";
            // 
            // DeleteStdbtn
            // 
            this.DeleteStdbtn.AutoSize = false;
            this.DeleteStdbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteStdbtn.Depth = 0;
            this.DeleteStdbtn.DrawShadows = true;
            this.DeleteStdbtn.Enabled = false;
            this.DeleteStdbtn.HighEmphasis = false;
            this.DeleteStdbtn.Icon = null;
            this.DeleteStdbtn.Location = new System.Drawing.Point(329, 188);
            this.DeleteStdbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteStdbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteStdbtn.Name = "DeleteStdbtn";
            this.DeleteStdbtn.Size = new System.Drawing.Size(94, 35);
            this.DeleteStdbtn.TabIndex = 8;
            this.DeleteStdbtn.Text = "Delete";
            this.DeleteStdbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.DeleteStdbtn.UseAccentColor = false;
            this.DeleteStdbtn.UseVisualStyleBackColor = true;
            this.DeleteStdbtn.Click += new System.EventHandler(this.DeleteStdbtn_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.Enabled = false;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(431, 186);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(124, 35);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "Update";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.AutoSize = false;
            this.Savebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Savebtn.Depth = 0;
            this.Savebtn.DrawShadows = true;
            this.Savebtn.HighEmphasis = false;
            this.Savebtn.Icon = null;
            this.Savebtn.Location = new System.Drawing.Point(9, 188);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Savebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(177, 35);
            this.Savebtn.TabIndex = 6;
            this.Savebtn.Text = "Save";
            this.Savebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Savebtn.UseAccentColor = false;
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Sclasscbx
            // 
            this.Sclasscbx.AutoResize = false;
            this.Sclasscbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sclasscbx.Depth = 0;
            this.Sclasscbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Sclasscbx.DropDownHeight = 118;
            this.Sclasscbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sclasscbx.DropDownWidth = 121;
            this.Sclasscbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Sclasscbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sclasscbx.FormattingEnabled = true;
            this.Sclasscbx.Hint = "Class";
            this.Sclasscbx.IntegralHeight = false;
            this.Sclasscbx.ItemHeight = 29;
            this.Sclasscbx.Items.AddRange(new object[] {
            "",
            "MALE",
            "FEMALE"});
            this.Sclasscbx.Location = new System.Drawing.Point(9, 145);
            this.Sclasscbx.MaxDropDownItems = 4;
            this.Sclasscbx.MouseState = MaterialSkin.MouseState.OUT;
            this.Sclasscbx.Name = "Sclasscbx";
            this.Sclasscbx.Size = new System.Drawing.Size(287, 35);
            this.Sclasscbx.StartIndex = 0;
            this.Sclasscbx.TabIndex = 5;
            this.Sclasscbx.UseTallSize = false;
            this.Sclasscbx.SelectedIndexChanged += new System.EventHandler(this.Sclasscbx_SelectedIndexChanged);
            // 
            // Sgendercbx
            // 
            this.Sgendercbx.AutoResize = false;
            this.Sgendercbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Sgendercbx.Depth = 0;
            this.Sgendercbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Sgendercbx.DropDownHeight = 118;
            this.Sgendercbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sgendercbx.DropDownWidth = 121;
            this.Sgendercbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Sgendercbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Sgendercbx.FormattingEnabled = true;
            this.Sgendercbx.Hint = "Gender";
            this.Sgendercbx.IntegralHeight = false;
            this.Sgendercbx.ItemHeight = 29;
            this.Sgendercbx.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.Sgendercbx.Location = new System.Drawing.Point(9, 104);
            this.Sgendercbx.MaxDropDownItems = 4;
            this.Sgendercbx.MouseState = MaterialSkin.MouseState.OUT;
            this.Sgendercbx.Name = "Sgendercbx";
            this.Sgendercbx.Size = new System.Drawing.Size(287, 35);
            this.Sgendercbx.StartIndex = 0;
            this.Sgendercbx.TabIndex = 4;
            this.Sgendercbx.UseTallSize = false;
            // 
            // Sidtxt
            // 
            this.Sidtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sidtxt.Depth = 0;
            this.Sidtxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Sidtxt.Hint = "Student ID";
            this.Sidtxt.Location = new System.Drawing.Point(329, 148);
            this.Sidtxt.MaxLength = 50;
            this.Sidtxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Sidtxt.Multiline = false;
            this.Sidtxt.Name = "Sidtxt";
            this.Sidtxt.ReadOnly = true;
            this.Sidtxt.Size = new System.Drawing.Size(130, 36);
            this.Sidtxt.TabIndex = 2;
            this.Sidtxt.Text = "";
            this.Sidtxt.UseTallSize = false;
            // 
            // Sphonetxt
            // 
            this.Sphonetxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sphonetxt.Depth = 0;
            this.Sphonetxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Sphonetxt.Hint = "Contact";
            this.Sphonetxt.Location = new System.Drawing.Point(9, 62);
            this.Sphonetxt.MaxLength = 50;
            this.Sphonetxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Sphonetxt.Multiline = false;
            this.Sphonetxt.Name = "Sphonetxt";
            this.Sphonetxt.Size = new System.Drawing.Size(290, 36);
            this.Sphonetxt.TabIndex = 1;
            this.Sphonetxt.Text = "";
            this.Sphonetxt.UseTallSize = false;
            // 
            // Snametxt
            // 
            this.Snametxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Snametxt.Depth = 0;
            this.Snametxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Snametxt.Hint = "Student Name";
            this.Snametxt.Location = new System.Drawing.Point(9, 20);
            this.Snametxt.MaxLength = 50;
            this.Snametxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Snametxt.Multiline = false;
            this.Snametxt.Name = "Snametxt";
            this.Snametxt.Size = new System.Drawing.Size(290, 36);
            this.Snametxt.TabIndex = 0;
            this.Snametxt.Text = "";
            this.Snametxt.UseTallSize = false;
            // 
            // Closebtn
            // 
            this.Closebtn.AutoSize = false;
            this.Closebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Closebtn.Depth = 0;
            this.Closebtn.DrawShadows = true;
            this.Closebtn.HighEmphasis = false;
            this.Closebtn.Icon = null;
            this.Closebtn.Location = new System.Drawing.Point(935, 4);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Closebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(63, 35);
            this.Closebtn.TabIndex = 13;
            this.Closebtn.Text = "exit";
            this.Closebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Closebtn.UseAccentColor = false;
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // Msglbl
            // 
            this.Msglbl.AllowParentOverrides = false;
            this.Msglbl.AutoEllipsis = false;
            this.Msglbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.Msglbl.CursorType = System.Windows.Forms.Cursors.Default;
            this.Msglbl.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msglbl.ForeColor = System.Drawing.Color.SeaGreen;
            this.Msglbl.Location = new System.Drawing.Point(473, 13);
            this.Msglbl.Name = "Msglbl";
            this.Msglbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Msglbl.Size = new System.Drawing.Size(12, 23);
            this.Msglbl.TabIndex = 14;
            this.Msglbl.Text = "...";
            this.Msglbl.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Msglbl.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MsgTimer
            // 
            this.MsgTimer.Enabled = true;
            this.MsgTimer.Interval = 5000;
            this.MsgTimer.Tick += new System.EventHandler(this.MsgTimer_Tick);
            // 
            // StudentEditcbx
            // 
            this.StudentEditcbx.AutoSize = true;
            this.StudentEditcbx.Depth = 0;
            this.StudentEditcbx.Location = new System.Drawing.Point(559, 184);
            this.StudentEditcbx.Margin = new System.Windows.Forms.Padding(0);
            this.StudentEditcbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StudentEditcbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.StudentEditcbx.Name = "StudentEditcbx";
            this.StudentEditcbx.Ripple = true;
            this.StudentEditcbx.Size = new System.Drawing.Size(62, 37);
            this.StudentEditcbx.TabIndex = 24;
            this.StudentEditcbx.Text = "Edit";
            this.StudentEditcbx.UseVisualStyleBackColor = true;
            this.StudentEditcbx.CheckedChanged += new System.EventHandler(this.StudentEditcbx_CheckedChanged);
            // 
            // StudentsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 650);
            this.ControlBox = false;
            this.Controls.Add(this.Msglbl);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.Container);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentsScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudentForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StudentsScreen_Load);
            this.Container.ResumeLayout(false);
            this.TableGroup.ResumeLayout(false);
            this.StudentstbContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TbStudents)).EndInit();
            this.ActionsGroup.ResumeLayout(false);
            this.ActionsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Container;
        private Bunifu.UI.WinForms.BunifuGroupBox TableGroup;
        private Bunifu.UI.WinForms.BunifuGroupBox ActionsGroup;
        private Bunifu.UI.WinForms.BunifuPanel StudentstbContainer;
        private System.Windows.Forms.DataGridView TbStudents;
        private MaterialSkin.Controls.MaterialButton DeleteStdbtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton Savebtn;
        private MaterialSkin.Controls.MaterialComboBox Sclasscbx;
        private MaterialSkin.Controls.MaterialComboBox Sgendercbx;
        private MaterialSkin.Controls.MaterialTextBox Sidtxt;
        private MaterialSkin.Controls.MaterialTextBox Sphonetxt;
        private MaterialSkin.Controls.MaterialTextBox Snametxt;
        private MaterialSkin.Controls.MaterialButton SavebyFilebtn;
        private MaterialSkin.Controls.MaterialButton Choosefilebtn;
        private MaterialSkin.Controls.MaterialLabel ChooseFromFilelbl;
        private MaterialSkin.Controls.MaterialButton Closebtn;
        private MaterialSkin.Controls.MaterialTextBox USclasstxt;
        private MaterialSkin.Controls.MaterialTextBox USgendertxt;
        private MaterialSkin.Controls.MaterialTextBox USphonetxt;
        private MaterialSkin.Controls.MaterialTextBox USnametxt;
        private Bunifu.UI.WinForms.BunifuTextBox Searchtxt;
        private MaterialSkin.Controls.MaterialButton ExportDatabtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton ReloadDatabtn;
        private Bunifu.UI.WinForms.BunifuDropdown FilterStudentscbx;
        private Bunifu.UI.WinForms.BunifuLabel Msglbl;
        private System.Windows.Forms.Timer MsgTimer;
        private MaterialSkin.Controls.MaterialCheckbox StudentEditcbx;
    }
}