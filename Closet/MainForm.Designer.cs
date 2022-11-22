namespace Closet
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.UserNameLabel = new System.Windows.Forms.Label();
			this.ClothesButton = new System.Windows.Forms.Button();
			this.WhatToWearButton = new System.Windows.Forms.Button();
			this.UserEditButton = new System.Windows.Forms.Button();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.logoutLabel = new System.Windows.Forms.Label();
			this.clothesPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.userLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.clothesPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// UserNameLabel
			// 
			this.UserNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(53)))), ((int)(((byte)(29)))));
			this.UserNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
			this.UserNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.UserNameLabel.Location = new System.Drawing.Point(30, 37);
			this.UserNameLabel.Name = "UserNameLabel";
			this.UserNameLabel.Size = new System.Drawing.Size(165, 61);
			this.UserNameLabel.TabIndex = 0;
			this.UserNameLabel.Text = "UserName的衣櫃";
			this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ClothesButton
			// 
			this.ClothesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.ClothesButton.BackgroundImage = global::Closet.Properties.Resources.clothes6;
			this.ClothesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClothesButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ClothesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(53)))), ((int)(((byte)(29)))));
			this.ClothesButton.FlatAppearance.BorderSize = 3;
			this.ClothesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.ClothesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClothesButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClothesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
			this.ClothesButton.Location = new System.Drawing.Point(30, 114);
			this.ClothesButton.Name = "ClothesButton";
			this.ClothesButton.Size = new System.Drawing.Size(165, 215);
			this.ClothesButton.TabIndex = 1;
			this.ClothesButton.Text = "查看衣櫃";
			this.ClothesButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.ClothesButton.UseVisualStyleBackColor = false;
			this.ClothesButton.Click += new System.EventHandler(this.ClothesButton_Click);
			this.ClothesButton.MouseLeave += new System.EventHandler(this.ClothesButton_MouseLeave);
			this.ClothesButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClothesButton_MouseMove);
			// 
			// WhatToWearButton
			// 
			this.WhatToWearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
			this.WhatToWearButton.BackgroundImage = global::Closet.Properties.Resources._1841902;
			this.WhatToWearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.WhatToWearButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WhatToWearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(1)))));
			this.WhatToWearButton.FlatAppearance.BorderSize = 10;
			this.WhatToWearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
			this.WhatToWearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WhatToWearButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.WhatToWearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
			this.WhatToWearButton.Location = new System.Drawing.Point(219, 37);
			this.WhatToWearButton.Name = "WhatToWearButton";
			this.WhatToWearButton.Size = new System.Drawing.Size(165, 292);
			this.WhatToWearButton.TabIndex = 2;
			this.WhatToWearButton.Text = "今天穿什麼";
			this.WhatToWearButton.UseVisualStyleBackColor = false;
			this.WhatToWearButton.Click += new System.EventHandler(this.WhatToWearButton_Click);
			this.WhatToWearButton.MouseLeave += new System.EventHandler(this.WhatToWearButton_MouseLeave);
			this.WhatToWearButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WhatToWearButton_MouseMove);
			// 
			// UserEditButton
			// 
			this.UserEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.UserEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UserEditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(53)))), ((int)(((byte)(29)))));
			this.UserEditButton.FlatAppearance.BorderSize = 3;
			this.UserEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.UserEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.UserEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UserEditButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.UserEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
			this.UserEditButton.Location = new System.Drawing.Point(30, 356);
			this.UserEditButton.Name = "UserEditButton";
			this.UserEditButton.Size = new System.Drawing.Size(165, 82);
			this.UserEditButton.TabIndex = 4;
			this.UserEditButton.Text = "資料修改";
			this.UserEditButton.UseVisualStyleBackColor = false;
			this.UserEditButton.Click += new System.EventHandler(this.UserEditButton_Click);
			this.UserEditButton.MouseLeave += new System.EventHandler(this.UserEditButton_MouseLeave);
			this.UserEditButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserEditButton_MouseMove);
			// 
			// LogoutButton
			// 
			this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.LogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(53)))), ((int)(((byte)(29)))));
			this.LogoutButton.FlatAppearance.BorderSize = 3;
			this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(95)))), ((int)(((byte)(56)))));
			this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogoutButton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.LogoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(248)))), ((int)(((byte)(241)))));
			this.LogoutButton.Location = new System.Drawing.Point(219, 356);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(165, 82);
			this.LogoutButton.TabIndex = 5;
			this.LogoutButton.Text = "登出";
			this.LogoutButton.UseVisualStyleBackColor = false;
			this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
			this.LogoutButton.MouseLeave += new System.EventHandler(this.LogoutButton_MouseLeave);
			this.LogoutButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoutButton_MouseMove);
			// 
			// logoutLabel
			// 
			this.logoutLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(1)))));
			this.logoutLabel.Cursor = System.Windows.Forms.Cursors.Default;
			this.logoutLabel.Location = new System.Drawing.Point(276, 400);
			this.logoutLabel.Name = "logoutLabel";
			this.logoutLabel.Size = new System.Drawing.Size(51, 16);
			this.logoutLabel.TabIndex = 6;
			// 
			// clothesPanel
			// 
			this.clothesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(53)))), ((int)(((byte)(29)))));
			this.clothesPanel.Controls.Add(this.label1);
			this.clothesPanel.Location = new System.Drawing.Point(30, 114);
			this.clothesPanel.Name = "clothesPanel";
			this.clothesPanel.Size = new System.Drawing.Size(165, 147);
			this.clothesPanel.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(1)))));
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Location = new System.Drawing.Point(136, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 51);
			this.label1.TabIndex = 11;
			// 
			// userLabel
			// 
			this.userLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(28)))), ((int)(((byte)(1)))));
			this.userLabel.Cursor = System.Windows.Forms.Cursors.Default;
			this.userLabel.Location = new System.Drawing.Point(87, 400);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(51, 16);
			this.userLabel.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(73)))), ((int)(((byte)(39)))));
			this.label2.Location = new System.Drawing.Point(21, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 88);
			this.label2.TabIndex = 12;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = global::Closet.Properties.Resources.closet2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(418, 500);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.clothesPanel);
			this.Controls.Add(this.WhatToWearButton);
			this.Controls.Add(this.logoutLabel);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.UserEditButton);
			this.Controls.Add(this.UserNameLabel);
			this.Controls.Add(this.ClothesButton);
			this.Controls.Add(this.label2);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(434, 539);
			this.MinimumSize = new System.Drawing.Size(434, 539);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "首頁";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.clothesPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button ClothesButton;
        private System.Windows.Forms.Button WhatToWearButton;
        private System.Windows.Forms.Button UserEditButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label logoutLabel;
        private System.Windows.Forms.Panel clothesPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label2;
    }
}