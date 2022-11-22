namespace Closet
{
    partial class SignInForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
			this.label1 = new System.Windows.Forms.Label();
			this.AccountTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SignUpLabel = new System.Windows.Forms.Label();
			this.SignInButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label1.Location = new System.Drawing.Point(48, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "帳號：";
			// 
			// AccountTextBox
			// 
			this.AccountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.AccountTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AccountTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.AccountTextBox.Location = new System.Drawing.Point(117, 55);
			this.AccountTextBox.MaxLength = 20;
			this.AccountTextBox.Name = "AccountTextBox";
			this.AccountTextBox.Size = new System.Drawing.Size(140, 26);
			this.AccountTextBox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.label2.Location = new System.Drawing.Point(48, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "密碼：";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PasswordTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PasswordTextBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.PasswordTextBox.Location = new System.Drawing.Point(117, 121);
			this.PasswordTextBox.MaxLength = 20;
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(140, 26);
			this.PasswordTextBox.TabIndex = 1;
			// 
			// SignUpLabel
			// 
			this.SignUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignUpLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.SignUpLabel.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.SignUpLabel.Location = new System.Drawing.Point(48, 190);
			this.SignUpLabel.Name = "SignUpLabel";
			this.SignUpLabel.Size = new System.Drawing.Size(86, 39);
			this.SignUpLabel.TabIndex = 3;
			this.SignUpLabel.Text = "新用戶？";
			this.SignUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.SignUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
			// 
			// SignInButton
			// 
			this.SignInButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SignInButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
			this.SignInButton.FlatAppearance.BorderSize = 3;
			this.SignInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignInButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.SignInButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
			this.SignInButton.Location = new System.Drawing.Point(181, 190);
			this.SignInButton.Name = "SignInButton";
			this.SignInButton.Size = new System.Drawing.Size(76, 39);
			this.SignInButton.TabIndex = 2;
			this.SignInButton.Text = "登入";
			this.SignInButton.UseVisualStyleBackColor = true;
			this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// SignInForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(235)))));
			this.ClientSize = new System.Drawing.Size(304, 281);
			this.Controls.Add(this.SignInButton);
			this.Controls.Add(this.SignUpLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AccountTextBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SignInForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "我的衣櫃";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}