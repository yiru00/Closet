namespace Closet
{
    partial class SignUpForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
			this.SignUpButton = new System.Windows.Forms.Button();
			this.UserNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AccountTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// SignUpButton
			// 
			this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
			this.SignUpButton.FlatAppearance.BorderSize = 3;
			this.SignUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.SignUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignUpButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.SignUpButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.SignUpButton.Location = new System.Drawing.Point(181, 206);
			this.SignUpButton.Name = "SignUpButton";
			this.SignUpButton.Size = new System.Drawing.Size(76, 42);
			this.SignUpButton.TabIndex = 3;
			this.SignUpButton.Text = "註冊";
			this.SignUpButton.UseVisualStyleBackColor = true;
			this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
			// 
			// UserNameTextBox
			// 
			this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UserNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.UserNameTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.UserNameTextBox.Location = new System.Drawing.Point(117, 148);
			this.UserNameTextBox.MaxLength = 10;
			this.UserNameTextBox.Multiline = true;
			this.UserNameTextBox.Name = "UserNameTextBox";
			this.UserNameTextBox.Size = new System.Drawing.Size(140, 28);
			this.UserNameTextBox.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label3.Location = new System.Drawing.Point(48, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "姓名：";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PasswordTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.PasswordTextBox.Location = new System.Drawing.Point(117, 90);
			this.PasswordTextBox.MaxLength = 20;
			this.PasswordTextBox.Multiline = true;
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(140, 28);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label2.Location = new System.Drawing.Point(48, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 24);
			this.label2.TabIndex = 9;
			this.label2.Text = "密碼：";
			// 
			// AccountTextBox
			// 
			this.AccountTextBox.AllowDrop = true;
			this.AccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AccountTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AccountTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.AccountTextBox.Location = new System.Drawing.Point(117, 32);
			this.AccountTextBox.MaxLength = 20;
			this.AccountTextBox.Multiline = true;
			this.AccountTextBox.Name = "AccountTextBox";
			this.AccountTextBox.Size = new System.Drawing.Size(140, 28);
			this.AccountTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label1.Location = new System.Drawing.Point(48, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "帳號：";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// SignUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.ClientSize = new System.Drawing.Size(304, 281);
			this.Controls.Add(this.SignUpButton);
			this.Controls.Add(this.UserNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AccountTextBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SignUpForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新用戶";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignUpForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}