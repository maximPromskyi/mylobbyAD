
namespace MyLobbyAD
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.ShedulerButton = new MaterialSkin.Controls.MaterialButton();
            this.SignOutButton = new MaterialSkin.Controls.MaterialButton();
            this.CloseButton = new MaterialSkin.Controls.MaterialButton();
            this.SwitchADButton = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ShedulerButton
            // 
            this.ShedulerButton.AutoSize = false;
            this.ShedulerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShedulerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShedulerButton.Depth = 0;
            this.ShedulerButton.DrawShadows = true;
            this.ShedulerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShedulerButton.HighEmphasis = true;
            this.ShedulerButton.Icon = null;
            this.ShedulerButton.Location = new System.Drawing.Point(13, 96);
            this.ShedulerButton.Margin = new System.Windows.Forms.Padding(5);
            this.ShedulerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShedulerButton.Name = "ShedulerButton";
            this.ShedulerButton.Size = new System.Drawing.Size(376, 47);
            this.ShedulerButton.TabIndex = 10;
            this.ShedulerButton.Text = "scheduler";
            this.ShedulerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ShedulerButton.UseAccentColor = false;
            this.ShedulerButton.UseVisualStyleBackColor = true;
            this.ShedulerButton.Click += new System.EventHandler(this.SchedulerButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.AutoSize = false;
            this.SignOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOutButton.Depth = 0;
            this.SignOutButton.DrawShadows = true;
            this.SignOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOutButton.HighEmphasis = true;
            this.SignOutButton.Icon = null;
            this.SignOutButton.Location = new System.Drawing.Point(11, 203);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(5);
            this.SignOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(376, 45);
            this.SignOutButton.TabIndex = 12;
            this.SignOutButton.Text = "Sign out";
            this.SignOutButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.SignOutButton.UseAccentColor = true;
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = false;
            this.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Depth = 0;
            this.CloseButton.DrawShadows = true;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.HighEmphasis = true;
            this.CloseButton.Icon = null;
            this.CloseButton.Location = new System.Drawing.Point(215, 293);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(5);
            this.CloseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(173, 45);
            this.CloseButton.TabIndex = 13;
            this.CloseButton.Text = "Close";
            this.CloseButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseButton.UseAccentColor = false;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.SwitchADButton.Location = new System.Drawing.Point(11, 149);
            this.SwitchADButton.Margin = new System.Windows.Forms.Padding(5);
            this.SwitchADButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SwitchADButton.Name = "SwitchADButton";
            this.SwitchADButton.Size = new System.Drawing.Size(376, 47);
            this.SwitchADButton.TabIndex = 14;
            this.SwitchADButton.Text = "Switch active directory";
            this.SwitchADButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.SwitchADButton.UseAccentColor = false;
            this.SwitchADButton.UseVisualStyleBackColor = true;
            this.SwitchADButton.Click += new System.EventHandler(this.SwitchADButton_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 357);
            this.Controls.Add(this.SwitchADButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SignOutButton);
            this.Controls.Add(this.ShedulerButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = this.ClientSize;
            this.MinimumSize = this.ClientSize;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton ShedulerButton;
        private MaterialSkin.Controls.MaterialButton SignOutButton;
        private MaterialSkin.Controls.MaterialButton CloseButton;
        private MaterialSkin.Controls.MaterialButton SwitchADButton;
    }
}