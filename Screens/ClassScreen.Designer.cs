namespace CanteenManagementSystem.Screens
{
    partial class ClassScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassScreen));
            this.Container = new System.Windows.Forms.Panel();
            this.Exitbtn = new MaterialSkin.Controls.MaterialButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.TbClasses = new System.Windows.Forms.DataGridView();
            this.Savebtn = new MaterialSkin.Controls.MaterialButton();
            this.Updatebtn = new MaterialSkin.Controls.MaterialButton();
            this.CbxClasses = new MaterialSkin.Controls.MaterialComboBox();
            this.Classtitletxt = new MaterialSkin.Controls.MaterialTextBox();
            this.Deletebtn = new MaterialSkin.Controls.MaterialButton();
            this.Container.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TbClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container.Controls.Add(this.Deletebtn);
            this.Container.Controls.Add(this.Classtitletxt);
            this.Container.Controls.Add(this.CbxClasses);
            this.Container.Controls.Add(this.Updatebtn);
            this.Container.Controls.Add(this.Savebtn);
            this.Container.Controls.Add(this.bunifuPanel1);
            this.Container.Location = new System.Drawing.Point(19, 41);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(550, 337);
            this.Container.TabIndex = 0;
            // 
            // Exitbtn
            // 
            this.Exitbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitbtn.AutoSize = false;
            this.Exitbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Exitbtn.Depth = 0;
            this.Exitbtn.DrawShadows = true;
            this.Exitbtn.HighEmphasis = true;
            this.Exitbtn.Icon = null;
            this.Exitbtn.Location = new System.Drawing.Point(509, 4);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Exitbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(60, 28);
            this.Exitbtn.TabIndex = 1;
            this.Exitbtn.Text = "exit";
            this.Exitbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Exitbtn.UseAccentColor = false;
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.TbClasses);
            this.bunifuPanel1.Location = new System.Drawing.Point(17, 133);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(519, 194);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // TbClasses
            // 
            this.TbClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TbClasses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TbClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbClasses.Location = new System.Drawing.Point(0, 0);
            this.TbClasses.Name = "TbClasses";
            this.TbClasses.Size = new System.Drawing.Size(515, 190);
            this.TbClasses.TabIndex = 0;
            // 
            // Savebtn
            // 
            this.Savebtn.AutoSize = false;
            this.Savebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Savebtn.Depth = 0;
            this.Savebtn.DrawShadows = true;
            this.Savebtn.HighEmphasis = true;
            this.Savebtn.Icon = null;
            this.Savebtn.Location = new System.Drawing.Point(404, 18);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Savebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(132, 39);
            this.Savebtn.TabIndex = 1;
            this.Savebtn.Text = "save";
            this.Savebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Savebtn.UseAccentColor = false;
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.AutoSize = false;
            this.Updatebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Updatebtn.Depth = 0;
            this.Updatebtn.DrawShadows = true;
            this.Updatebtn.HighEmphasis = true;
            this.Updatebtn.Icon = null;
            this.Updatebtn.Location = new System.Drawing.Point(313, 69);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Updatebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(84, 39);
            this.Updatebtn.TabIndex = 3;
            this.Updatebtn.Text = "update";
            this.Updatebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Updatebtn.UseAccentColor = false;
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // CbxClasses
            // 
            this.CbxClasses.AutoResize = false;
            this.CbxClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CbxClasses.Depth = 0;
            this.CbxClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.CbxClasses.DropDownHeight = 174;
            this.CbxClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxClasses.DropDownWidth = 121;
            this.CbxClasses.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.CbxClasses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CbxClasses.FormattingEnabled = true;
            this.CbxClasses.Hint = "Select Class To Perform Update";
            this.CbxClasses.IntegralHeight = false;
            this.CbxClasses.ItemHeight = 43;
            this.CbxClasses.Location = new System.Drawing.Point(22, 66);
            this.CbxClasses.MaxDropDownItems = 4;
            this.CbxClasses.MouseState = MaterialSkin.MouseState.OUT;
            this.CbxClasses.Name = "CbxClasses";
            this.CbxClasses.Size = new System.Drawing.Size(284, 49);
            this.CbxClasses.StartIndex = 0;
            this.CbxClasses.TabIndex = 4;
            // 
            // Classtitletxt
            // 
            this.Classtitletxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Classtitletxt.Depth = 0;
            this.Classtitletxt.Font = new System.Drawing.Font("Roboto", 12F);
            this.Classtitletxt.Hint = "Class Title / Name";
            this.Classtitletxt.Location = new System.Drawing.Point(22, 12);
            this.Classtitletxt.MaxLength = 50;
            this.Classtitletxt.MouseState = MaterialSkin.MouseState.OUT;
            this.Classtitletxt.Multiline = false;
            this.Classtitletxt.Name = "Classtitletxt";
            this.Classtitletxt.Size = new System.Drawing.Size(375, 50);
            this.Classtitletxt.TabIndex = 5;
            this.Classtitletxt.Text = "";
            // 
            // Deletebtn
            // 
            this.Deletebtn.AutoSize = false;
            this.Deletebtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Deletebtn.Depth = 0;
            this.Deletebtn.DrawShadows = true;
            this.Deletebtn.HighEmphasis = true;
            this.Deletebtn.Icon = null;
            this.Deletebtn.Location = new System.Drawing.Point(405, 66);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Deletebtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(129, 39);
            this.Deletebtn.TabIndex = 6;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.Deletebtn.UseAccentColor = false;
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // ClassScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 388);
            this.ControlBox = false;
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Container);
            this.Name = "ClassScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClassScreen_Load);
            this.Container.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TbClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private MaterialSkin.Controls.MaterialButton Exitbtn;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.DataGridView TbClasses;
        private MaterialSkin.Controls.MaterialButton Updatebtn;
        private MaterialSkin.Controls.MaterialButton Savebtn;
        private MaterialSkin.Controls.MaterialComboBox CbxClasses;
        private MaterialSkin.Controls.MaterialTextBox Classtitletxt;
        private MaterialSkin.Controls.MaterialButton Deletebtn;
    }
}