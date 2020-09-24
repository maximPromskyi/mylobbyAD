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
            this.SwitchADButton = new MaterialSkin.Controls.MaterialButton();
            this.username = new System.Windows.Forms.Label();
            this.domainName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).BeginInit();
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
            this.LoginButton.Location = new System.Drawing.Point(96, 294);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(386, 46);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Upload Users";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // Domain
            // 
            this.Domain.AutoSize = true;
            this.Domain.BackColor = System.Drawing.SystemColors.Control;
            this.Domain.Depth = 0;
            this.Domain.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Domain.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.Domain.Location = new System.Drawing.Point(356, 91);
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
            this.settingPicture.Location = new System.Drawing.Point(539, 25);
            this.settingPicture.Name = "settingPicture";
            this.settingPicture.Size = new System.Drawing.Size(38, 38);
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
            this.materialLabel2.Location = new System.Drawing.Point(103, 91);
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
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(63, 175);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(55, 24);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Email:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(340, 175);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(59, 24);
            this.materialLabel5.TabIndex = 15;
            this.materialLabel5.Text = "Name:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(54, 137);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(64, 24);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(123, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(405, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Connected";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(335, 138);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 24);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Status:";
            // 
            // SwitchADButton
            // 
            this.SwitchADButton.AutoSize = false;
            this.SwitchADButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SwitchADButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchADButton.Depth = 0;
            this.SwitchADButton.DrawShadows = true;
            this.SwitchADButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SwitchADButton.HighEmphasis = true;
            this.SwitchADButton.Icon = null;
            this.SwitchADButton.Location = new System.Drawing.Point(329, 211);
            this.SwitchADButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SwitchADButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchADButton.Name = "SwitchADButton";
            this.SwitchADButton.Size = new System.Drawing.Size(211, 42);
            this.SwitchADButton.TabIndex = 22;
            this.SwitchADButton.Text = "Switch active directory";
            this.SwitchADButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.SwitchADButton.UseAccentColor = false;
            this.SwitchADButton.UseVisualStyleBackColor = true;
            this.SwitchADButton.Click += new System.EventHandler(this.SwitchADButton_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.Location = new System.Drawing.Point(124, 176);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(91, 22);
            this.username.TabIndex = 23;
            this.username.Text = "username";
            // 
            // domainName
            // 
            this.domainName.AutoSize = true;
            this.domainName.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.domainName.ForeColor = System.Drawing.Color.Black;
            this.domainName.Location = new System.Drawing.Point(405, 176);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(119, 22);
            this.domainName.TabIndex = 24;
            this.domainName.Text = "domainName";
            // 
            // ActiveDirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 364);
            this.Controls.Add(this.domainName);
            this.Controls.Add(this.username);
            this.Controls.Add(this.SwitchADButton);
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
            this.Name = "ActiveDirectoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Directory connected";
            ((System.ComponentModel.ISupportInitialize)(this.settingPicture)).EndInit();
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
        private MaterialSkin.Controls.MaterialButton SwitchADButton;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label domainName;
    }
}