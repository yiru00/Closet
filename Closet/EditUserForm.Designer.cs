namespace Closet
{
    partial class EditUserForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UserNameTextBox = new System.Windows.Forms.TextBox();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.AccountLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PasswordTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.PasswordTextBox.Location = new System.Drawing.Point(117, 91);
			this.PasswordTextBox.MaxLength = 20;
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(140, 26);
			this.PasswordTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label2.Location = new System.Drawing.Point(48, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "密碼：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label1.Location = new System.Drawing.Point(48, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "帳號：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label3.Location = new System.Drawing.Point(48, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "姓名：";
			// 
			// UserNameTextBox
			// 
			this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UserNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.UserNameTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.UserNameTextBox.Location = new System.Drawing.Point(117, 152);
			this.UserNameTextBox.MaxLength = 10;
			this.UserNameTextBox.Name = "UserNameTextBox";
			this.UserNameTextBox.Size = new System.Drawing.Size(140, 26);
			this.UserNameTextBox.TabIndex = 1;
			// 
			// UpdateButton
			// 
			this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
			this.UpdateButton.FlatAppearance.BorderSize = 3;
			this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpdateButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.UpdateButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.UpdateButton.Location = new System.Drawing.Point(181, 212);
			this.UpdateButton.MaximumSize = new System.Drawing.Size(76, 39);
			this.UpdateButton.MinimumSize = new System.Drawing.Size(76, 39);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(76, 39);
			this.UpdateButton.TabIndex = 2;
			this.UpdateButton.Text = "確認";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// AccountLabel
			// 
			this.AccountLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AccountLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.AccountLabel.Location = new System.Drawing.Point(113, 29);
			this.AccountLabel.Name = "AccountLabel";
			this.AccountLabel.Size = new System.Drawing.Size(140, 29);
			this.AccountLabel.TabIndex = 8;
			this.AccountLabel.Text = "label4";
			this.AccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// EditUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.ClientSize = new System.Drawing.Size(304, 281);
			this.Controls.Add(this.AccountLabel);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.UserNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(320, 320);
			this.MinimumSize = new System.Drawing.Size(320, 320);
			this.Name = "EditUserForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改資料";
			this.Load += new System.EventHandler(this.EditUserForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label AccountLabel;
    }
}