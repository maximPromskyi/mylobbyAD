using MyLobbyAD.Services;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Windows.Forms;

namespace MyLobbyAD
{
    partial class ActiveDirectoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveDirectoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.settingPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.domainName = new System.Windows.Forms.Label();
            this.timerInfo = new MaterialSkin.Controls.MaterialLabel();
            this.loader = new System.Windows.Forms.PictureBox();
            this.previousUpdate = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IsSynchron = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneSms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.serverName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IsSyncCompany = new MaterialSkin.Controls.MaterialCheckbox();
            this.IsSyncJobTitle = new MaterialSkin.Controls.MaterialCheckbox();
            this.IsSyncEmail = new MaterialSkin.Controls.MaterialCheckbox();
            this.IsSyncPhone = new MaterialSkin.Controls.MaterialCheckbox();
            this.Save = new MaterialSkin.Controls.MaterialButton();
            this.IsSyncName = new MaterialSkin.Controls.MaterialCheckbox();
            this.countInfo = new System.Windows.Forms.Label();
            this.ProgressBarUsers = new MaterialSkin.Controls.MaterialProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = false;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Depth = 0;
            this.LoginButton.DrawShadows = true;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.HighEmphasis = true;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(600, 614);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(251, 40);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Update immediately";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // settingPicture
            // 
            this.settingPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingPicture.BackColor = System.Drawing.Color.Transparent;
            this.settingPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingPicture.Image = ((System.Drawing.Image)(resources.GetObject("settingPicture.Image")));
            this.settingPicture.Location = new System.Drawing.Point(851, 25);
            this.settingPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingPicture.Name = "settingPicture";
            this.settingPicture.Size = new System.Drawing.Size(37, 35);
            this.settingPicture.TabIndex = 11;
            this.settingPicture.TabStop = false;
            this.settingPicture.Click += new System.EventHandler(this.Setting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(25, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Secure Connection";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(522, 30);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(45, 18);
            this.emailLabel.TabIndex = 23;
            this.emailLabel.Text = "email";
            // 
            // domainName
            // 
            this.domainName.AutoSize = true;
            this.domainName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.domainName.ForeColor = System.Drawing.Color.White;
            this.domainName.Location = new System.Drawing.Point(84, 28);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(105, 19);
            this.domainName.TabIndex = 24;
            this.domainName.Text = "domainName";
            // 
            // timerInfo
            // 
            this.timerInfo.AutoSize = true;
            this.timerInfo.Depth = 0;
            this.timerInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timerInfo.Location = new System.Drawing.Point(600, 582);
            this.timerInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.timerInfo.Name = "timerInfo";
            this.timerInfo.Size = new System.Drawing.Size(65, 19);
            this.timerInfo.TabIndex = 25;
            this.timerInfo.Text = "timerInfo";
            this.timerInfo.Visible = false;
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(715, 618);
            this.loader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(39, 34);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loader.TabIndex = 26;
            this.loader.TabStop = false;
            this.loader.Visible = false;
            // 
            // previousUpdate
            // 
            this.previousUpdate.AutoSize = true;
            this.previousUpdate.Depth = 0;
            this.previousUpdate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.previousUpdate.Location = new System.Drawing.Point(600, 554);
            this.previousUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousUpdate.Name = "previousUpdate";
            this.previousUpdate.Size = new System.Drawing.Size(188, 19);
            this.previousUpdate.TabIndex = 27;
            this.previousUpdate.Text = "Previous update: unknown";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsSynchron,
            this.Photo,
            this.UserName,
            this.Company,
            this.JobTitle,
            this.Email,
            this.PhoneSms,
            this.UserId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(1, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.Size = new System.Drawing.Size(918, 395);
            this.dataGridView1.TabIndex = 28;
            // 
            // IsSynchron
            // 
            this.IsSynchron.HeaderText = "Upload";
            this.IsSynchron.Name = "IsSynchron";
            this.IsSynchron.Width = 60;
            // 
            // Photo
            // 
            this.Photo.HeaderText = "Photo";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Width = 80;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 200;
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.MinimumWidth = 6;
            this.Company.Name = "Company";
            this.Company.Width = 150;
            // 
            // JobTitle
            // 
            this.JobTitle.HeaderText = "Job Title";
            this.JobTitle.MinimumWidth = 6;
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 190;
            // 
            // PhoneSms
            // 
            this.PhoneSms.HeaderText = "Telephone number";
            this.PhoneSms.MinimumWidth = 6;
            this.PhoneSms.Name = "PhoneSms";
            this.PhoneSms.Width = 205;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.serverName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.domainName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 74);
            this.panel1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Server:";
            // 
            // serverName
            // 
            this.serverName.AutoSize = true;
            this.serverName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.serverName.ForeColor = System.Drawing.Color.White;
            this.serverName.Location = new System.Drawing.Point(91, 52);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(93, 19);
            this.serverName.TabIndex = 34;
            this.serverName.Text = "serverName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(463, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Secure Connection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(464, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(625, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "MyLobby";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(183, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Active Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Select fields to upload";
            // 
            // IsSyncCompany
            // 
            this.IsSyncCompany.AutoSize = true;
            this.IsSyncCompany.Depth = 0;
            this.IsSyncCompany.Location = new System.Drawing.Point(40, 608);
            this.IsSyncCompany.Margin = new System.Windows.Forms.Padding(0);
            this.IsSyncCompany.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsSyncCompany.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsSyncCompany.Name = "IsSyncCompany";
            this.IsSyncCompany.Ripple = true;
            this.IsSyncCompany.Size = new System.Drawing.Size(103, 37);
            this.IsSyncCompany.TabIndex = 32;
            this.IsSyncCompany.Text = "Company";
            this.IsSyncCompany.UseVisualStyleBackColor = true;
            // 
            // IsSyncJobTitle
            // 
            this.IsSyncJobTitle.AutoSize = true;
            this.IsSyncJobTitle.Depth = 0;
            this.IsSyncJobTitle.Location = new System.Drawing.Point(40, 642);
            this.IsSyncJobTitle.Margin = new System.Windows.Forms.Padding(0);
            this.IsSyncJobTitle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsSyncJobTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsSyncJobTitle.Name = "IsSyncJobTitle";
            this.IsSyncJobTitle.Ripple = true;
            this.IsSyncJobTitle.Size = new System.Drawing.Size(97, 37);
            this.IsSyncJobTitle.TabIndex = 33;
            this.IsSyncJobTitle.Text = "Job Title";
            this.IsSyncJobTitle.UseVisualStyleBackColor = true;
            // 
            // IsSyncEmail
            // 
            this.IsSyncEmail.AutoSize = true;
            this.IsSyncEmail.Depth = 0;
            this.IsSyncEmail.Location = new System.Drawing.Point(160, 576);
            this.IsSyncEmail.Margin = new System.Windows.Forms.Padding(0);
            this.IsSyncEmail.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsSyncEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsSyncEmail.Name = "IsSyncEmail";
            this.IsSyncEmail.Ripple = true;
            this.IsSyncEmail.Size = new System.Drawing.Size(75, 37);
            this.IsSyncEmail.TabIndex = 34;
            this.IsSyncEmail.Text = "Email";
            this.IsSyncEmail.UseVisualStyleBackColor = true;
            // 
            // IsSyncPhone
            // 
            this.IsSyncPhone.AutoSize = true;
            this.IsSyncPhone.Depth = 0;
            this.IsSyncPhone.Location = new System.Drawing.Point(160, 608);
            this.IsSyncPhone.Margin = new System.Windows.Forms.Padding(0);
            this.IsSyncPhone.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsSyncPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsSyncPhone.Name = "IsSyncPhone";
            this.IsSyncPhone.Ripple = true;
            this.IsSyncPhone.Size = new System.Drawing.Size(167, 37);
            this.IsSyncPhone.TabIndex = 35;
            this.IsSyncPhone.Text = "Telephone number";
            this.IsSyncPhone.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.AutoSize = false;
            this.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Depth = 0;
            this.Save.DrawShadows = true;
            this.Save.HighEmphasis = true;
            this.Save.Icon = null;
            this.Save.Location = new System.Drawing.Point(372, 614);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(190, 40);
            this.Save.TabIndex = 36;
            this.Save.Text = "Save Setting";
            this.Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Save.UseAccentColor = false;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // IsSyncName
            // 
            this.IsSyncName.AutoSize = true;
            this.IsSyncName.Checked = true;
            this.IsSyncName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IsSyncName.Depth = 0;
            this.IsSyncName.Enabled = false;
            this.IsSyncName.Location = new System.Drawing.Point(40, 576);
            this.IsSyncName.Margin = new System.Windows.Forms.Padding(0);
            this.IsSyncName.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsSyncName.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsSyncName.Name = "IsSyncName";
            this.IsSyncName.Ripple = true;
            this.IsSyncName.Size = new System.Drawing.Size(77, 37);
            this.IsSyncName.TabIndex = 31;
            this.IsSyncName.Text = "Name";
            this.IsSyncName.UseVisualStyleBackColor = true;
            // 
            // countInfo
            // 
            this.countInfo.AutoSize = true;
            this.countInfo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countInfo.Location = new System.Drawing.Point(357, 549);
            this.countInfo.Name = "countInfo";
            this.countInfo.Size = new System.Drawing.Size(211, 23);
            this.countInfo.TabIndex = 37;
            this.countInfo.Text = "Total number of users 0";
            // 
            // ProgressBarUsers
            // 
            this.ProgressBarUsers.Depth = 0;
            this.ProgressBarUsers.Location = new System.Drawing.Point(1, 700);
            this.ProgressBarUsers.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProgressBarUsers.Name = "ProgressBarUsers";
            this.ProgressBarUsers.Size = new System.Drawing.Size(918, 5);
            this.ProgressBarUsers.TabIndex = 38;
            // 
            // ActiveDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(919, 709);
            this.Controls.Add(this.ProgressBarUsers);
            this.Controls.Add(this.countInfo);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.IsSyncPhone);
            this.Controls.Add(this.IsSyncEmail);
            this.Controls.Add(this.IsSyncJobTitle);
            this.Controls.Add(this.IsSyncCompany);
            this.Controls.Add(this.IsSyncName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.previousUpdate);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.timerInfo);
            this.Controls.Add(this.settingPicture);
            this.Controls.Add(this.LoginButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ActiveDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synchronization";
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private System.Windows.Forms.PictureBox settingPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label domainName;
        public MaterialSkin.Controls.MaterialLabel timerInfo;
        public System.Windows.Forms.PictureBox loader;
        public MaterialSkin.Controls.MaterialLabel previousUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label serverName;
        private Label label2;
        private MaterialSkin.Controls.MaterialCheckbox IsSyncCompany;
        private MaterialSkin.Controls.MaterialCheckbox IsSyncJobTitle;
        private MaterialSkin.Controls.MaterialCheckbox IsSyncEmail;
        private MaterialSkin.Controls.MaterialCheckbox IsSyncPhone;
        private DataGridViewCheckBoxColumn IsSynchron;
        private DataGridViewImageColumn Photo;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Company;
        private DataGridViewTextBoxColumn JobTitle;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn PhoneSms;
        private DataGridViewTextBoxColumn UserId;
        private MaterialSkin.Controls.MaterialButton Save;
        private MaterialSkin.Controls.MaterialCheckbox IsSyncName;
        private Label countInfo;
        private MaterialSkin.Controls.MaterialProgressBar ProgressBarUsers;
    }
}