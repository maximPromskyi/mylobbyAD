namespace MyLobbyAD
{
    partial class LoginADForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginADForm));
            this.domainName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.LoginButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.warning = new MaterialSkin.Controls.MaterialLabel();
            this.loader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // domainName
            // 
            this.domainName.Location = new System.Drawing.Point(96, 119);
            this.domainName.Name = "domainName";
            this.domainName.Size = new System.Drawing.Size(207, 27);
            this.domainName.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(96, 257);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(207, 27);
            this.password.TabIndex = 4;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(96, 187);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(207, 27);
            this.username.TabIndex = 4;
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
            this.LoginButton.Location = new System.Drawing.Point(96, 331);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(5);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(208, 45);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Sign in";
            this.LoginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LoginButton.UseAccentColor = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(96, 93);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Domain";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(96, 160);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Username";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(96, 231);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(71, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Password";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Depth = 0;
            this.warning.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.warning.ForeColor = System.Drawing.Color.White;
            this.warning.HighEmphasis = true;
            this.warning.Location = new System.Drawing.Point(96, 297);
            this.warning.MouseState = MaterialSkin.MouseState.HOVER;
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(60, 19);
            this.warning.TabIndex = 12;
            this.warning.Text = "Warning";
            this.warning.UseAccent = true;
            this.warning.Visible = false;
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(178, 331);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(45, 45);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loader.TabIndex = 13;
            this.loader.TabStop = false;
            this.loader.Visible = false;
            // 
            // LoginADForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 399);
            this.Controls.Add(this.loader);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.domainName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = this.ClientSize;
            this.MinimumSize = this.ClientSize;
            this.Name = "LoginADForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Directory";
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox domainName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private MaterialSkin.Controls.MaterialButton LoginButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel warning;
        private System.Windows.Forms.PictureBox loader;
    }
}