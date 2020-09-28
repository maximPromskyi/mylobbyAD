using MyLobbyAD.Services;
using System.DirectoryServices.AccountManagement;

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
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.Domain = new MaterialSkin.Controls.MaterialLabel();
            this.settingPicture = new System.Windows.Forms.PictureBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.username = new System.Windows.Forms.Label();
            this.domainName = new System.Windows.Forms.Label();
            this.timerInfo = new MaterialSkin.Controls.MaterialLabel();
            this.loader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
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
            this.LoginButton.Location = new System.Drawing.Point(46, 340);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(251, 40);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Upload users";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Domain
            // 
            this.Domain.AutoSize = true;
            this.Domain.BackColor = System.Drawing.SystemColors.Control;
            this.Domain.Depth = 0;
            this.Domain.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Domain.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.Domain.Location = new System.Drawing.Point(28, 197);
            this.Domain.MouseState = MaterialSkin.MouseState.HOVER;
            this.Domain.Name = "Domain";
            this.Domain.Size = new System.Drawing.Size(172, 29);
            this.Domain.TabIndex = 9;
            this.Domain.Text = "Active Directory";
            // 
            // settingPicture
            // 
            this.settingPicture.BackColor = System.Drawing.Color.Transparent;
            this.settingPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingPicture.Image = ((System.Drawing.Image)(resources.GetObject("settingPicture.Image")));
            this.settingPicture.Location = new System.Drawing.Point(310, 25);
            this.settingPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingPicture.Name = "settingPicture";
            this.settingPicture.Size = new System.Drawing.Size(33, 35);
            this.settingPicture.TabIndex = 11;
            this.settingPicture.TabStop = false;
            this.settingPicture.Click += new System.EventHandler(this.Setting_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.Location = new System.Drawing.Point(28, 74);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 29);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "MyLobby";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.Location = new System.Drawing.Point(53, 147);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(45, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Email:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel5.Location = new System.Drawing.Point(53, 278);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(47, 19);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Name:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel4.Location = new System.Drawing.Point(53, 114);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(51, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(109, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Secure Connection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(106, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Secure Connection";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.Location = new System.Drawing.Point(53, 243);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Status:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(103, 147);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(79, 19);
            this.username.TabIndex = 23;
            this.username.Text = "username";
            // 
            // domainName
            // 
            this.domainName.AutoSize = true;
            this.domainName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.domainName.ForeColor = System.Drawing.Color.Black;
            this.domainName.Location = new System.Drawing.Point(106, 278);
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
            this.timerInfo.Location = new System.Drawing.Point(46, 314);
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
            this.loader.Location = new System.Drawing.Point(153, 344);
            this.loader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(39, 34);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loader.TabIndex = 26;
            this.loader.TabStop = false;
            this.loader.Visible = false;
            // 
            // ActiveDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 412);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.timerInfo);
            this.Controls.Add(this.domainName);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.settingPicture);
            this.Controls.Add(this.Domain);
            this.Controls.Add(this.LoginButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ActiveDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Synchronization";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActiveDirectoryForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel Domain;
        private System.Windows.Forms.PictureBox settingPicture;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label domainName;
        public MaterialSkin.Controls.MaterialLabel timerInfo;
        public System.Windows.Forms.PictureBox loader;
    }
}