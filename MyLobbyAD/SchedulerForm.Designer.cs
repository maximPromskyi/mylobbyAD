
namespace MyLobbyAD
{
    partial class SchedulerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerForm));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TimeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.Run = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.timerInfo = new MaterialSkin.Controls.MaterialLabel();
            this.previousUpdate = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(76, 73);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(170, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Set update interval";
            // 
            // TimeComboBox
            // 
            this.TimeComboBox.AutoResize = false;
            this.TimeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TimeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimeComboBox.Depth = 0;
            this.TimeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TimeComboBox.DropDownHeight = 292;
            this.TimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimeComboBox.DropDownWidth = 121;
            this.TimeComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TimeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TimeComboBox.FormattingEnabled = true;
            this.TimeComboBox.Hint = "Select time";
            this.TimeComboBox.IntegralHeight = false;
            this.TimeComboBox.ItemHeight = 29;
            this.TimeComboBox.Location = new System.Drawing.Point(49, 108);
            this.TimeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimeComboBox.MaxDropDownItems = 10;
            this.TimeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TimeComboBox.Name = "TimeComboBox";
            this.TimeComboBox.Size = new System.Drawing.Size(229, 35);
            this.TimeComboBox.TabIndex = 11;
            this.TimeComboBox.UseAccent = false;
            this.TimeComboBox.UseTallSize = false;
            // 
            // Run
            // 
            this.Run.AutoSize = false;
            this.Run.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Run.Depth = 0;
            this.Run.DrawShadows = true;
            this.Run.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Run.HighEmphasis = true;
            this.Run.Icon = null;
            this.Run.Location = new System.Drawing.Point(49, 203);
            this.Run.Margin = new System.Windows.Forms.Padding(4);
            this.Run.MouseState = MaterialSkin.MouseState.HOVER;
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(229, 32);
            this.Run.TabIndex = 13;
            this.Run.Text = "Start";
            this.Run.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Run.UseAccentColor = false;
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(49, 245);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(229, 32);
            this.materialButton1.TabIndex = 14;
            this.materialButton1.Text = "Close";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = true;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // timerInfo
            // 
            this.timerInfo.AutoSize = true;
            this.timerInfo.Depth = 0;
            this.timerInfo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.timerInfo.Location = new System.Drawing.Point(49, 177);
            this.timerInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.timerInfo.Name = "timerInfo";
            this.timerInfo.Size = new System.Drawing.Size(65, 19);
            this.timerInfo.TabIndex = 15;
            this.timerInfo.Text = "timerInfo";
            this.timerInfo.Visible = false;
            // 
            // previousUpdate
            // 
            this.previousUpdate.AutoSize = true;
            this.previousUpdate.Depth = 0;
            this.previousUpdate.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.previousUpdate.Location = new System.Drawing.Point(49, 152);
            this.previousUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.previousUpdate.Name = "previousUpdate";
            this.previousUpdate.Size = new System.Drawing.Size(188, 19);
            this.previousUpdate.TabIndex = 28;
            this.previousUpdate.Text = "Previous update: unknown";
            // 
            // SchedulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 286);
            this.Controls.Add(this.previousUpdate);
            this.Controls.Add(this.timerInfo);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TimeComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 286);
            this.MinimumSize = new System.Drawing.Size(332, 286);
            this.Name = "SchedulerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox TimeComboBox;
        private MaterialSkin.Controls.MaterialButton Run;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        public MaterialSkin.Controls.MaterialLabel timerInfo;
        public MaterialSkin.Controls.MaterialLabel previousUpdate;
    }
}