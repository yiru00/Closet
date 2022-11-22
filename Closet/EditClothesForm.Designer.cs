namespace Closet
{
	partial class EditClothesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClothesForm));
			this.ClothesNameLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ClothesNameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.CategoryNameComboBox = new System.Windows.Forms.ComboBox();
			this.categoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.ColorTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.BrandTextBox = new System.Windows.Forms.TextBox();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ucWeather1 = new Closet.Controls.ucWeather();
			this.ucOccasion1 = new Closet.Controls.ucOccasion();
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// ClothesNameLabel
			// 
			this.ClothesNameLabel.AutoSize = true;
			this.ClothesNameLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClothesNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ClothesNameLabel.Location = new System.Drawing.Point(42, 45);
			this.ClothesNameLabel.Name = "ClothesNameLabel";
			this.ClothesNameLabel.Size = new System.Drawing.Size(65, 24);
			this.ClothesNameLabel.TabIndex = 1;
			this.ClothesNameLabel.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label3.Location = new System.Drawing.Point(42, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "名稱：";
			// 
			// ClothesNameTextBox
			// 
			this.ClothesNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ClothesNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClothesNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ClothesNameTextBox.Location = new System.Drawing.Point(104, 104);
			this.ClothesNameTextBox.MaxLength = 10;
			this.ClothesNameTextBox.Name = "ClothesNameTextBox";
			this.ClothesNameTextBox.Size = new System.Drawing.Size(120, 26);
			this.ClothesNameTextBox.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label4.Location = new System.Drawing.Point(42, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = "種類：";
			// 
			// CategoryNameComboBox
			// 
			this.CategoryNameComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.CategoryNameComboBox.DataSource = this.categoryIndexVMBindingSource;
			this.CategoryNameComboBox.DisplayMember = "CategoryName";
			this.CategoryNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CategoryNameComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CategoryNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.CategoryNameComboBox.FormattingEnabled = true;
			this.CategoryNameComboBox.Location = new System.Drawing.Point(104, 165);
			this.CategoryNameComboBox.Name = "CategoryNameComboBox";
			this.CategoryNameComboBox.Size = new System.Drawing.Size(120, 32);
			this.CategoryNameComboBox.TabIndex = 2;
			// 
			// categoryIndexVMBindingSource
			// 
			this.categoryIndexVMBindingSource.DataSource = typeof(Closet.Models.ViewModels.CategoryIndexVM);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label5.Location = new System.Drawing.Point(264, 105);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 24);
			this.label5.TabIndex = 6;
			this.label5.Text = "花色：";
			// 
			// ColorTextBox
			// 
			this.ColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ColorTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ColorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ColorTextBox.Location = new System.Drawing.Point(327, 104);
			this.ColorTextBox.MaxLength = 10;
			this.ColorTextBox.Name = "ColorTextBox";
			this.ColorTextBox.Size = new System.Drawing.Size(120, 26);
			this.ColorTextBox.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label6.Location = new System.Drawing.Point(264, 169);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 24);
			this.label6.TabIndex = 8;
			this.label6.Text = "品牌：";
			// 
			// BrandTextBox
			// 
			this.BrandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BrandTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.BrandTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.BrandTextBox.Location = new System.Drawing.Point(327, 168);
			this.BrandTextBox.MaxLength = 15;
			this.BrandTextBox.Name = "BrandTextBox";
			this.BrandTextBox.Size = new System.Drawing.Size(120, 26);
			this.BrandTextBox.TabIndex = 3;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.DeleteButton.FlatAppearance.BorderSize = 3;
			this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.DeleteButton.Location = new System.Drawing.Point(367, 32);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(80, 37);
			this.DeleteButton.TabIndex = 5;
			this.DeleteButton.Text = "刪除";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label7.Location = new System.Drawing.Point(42, 227);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 24);
			this.label7.TabIndex = 11;
			this.label7.Text = "適合天氣：";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label8.Location = new System.Drawing.Point(42, 280);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 24);
			this.label8.TabIndex = 12;
			this.label8.Text = "適合場合：";
			// 
			// UpdateButton
			// 
			this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.UpdateButton.FlatAppearance.BorderSize = 3;
			this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UpdateButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.UpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.UpdateButton.Location = new System.Drawing.Point(367, 331);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(80, 37);
			this.UpdateButton.TabIndex = 4;
			this.UpdateButton.Text = "更新";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ucWeather1
			// 
			this.ucWeather1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ucWeather1.Location = new System.Drawing.Point(142, 229);
			this.ucWeather1.Name = "ucWeather1";
			this.ucWeather1.Size = new System.Drawing.Size(305, 20);
			this.ucWeather1.TabIndex = 4;
			this.ucWeather1.TabStop = false;
			// 
			// ucOccasion1
			// 
			this.ucOccasion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ucOccasion1.Location = new System.Drawing.Point(142, 280);
			this.ucOccasion1.Name = "ucOccasion1";
			this.ucOccasion1.Size = new System.Drawing.Size(305, 20);
			this.ucOccasion1.TabIndex = 5;
			this.ucOccasion1.TabStop = false;
			// 
			// EditClothesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.ClientSize = new System.Drawing.Size(489, 401);
			this.Controls.Add(this.ucOccasion1);
			this.Controls.Add(this.ucWeather1);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.BrandTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ColorTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CategoryNameComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ClothesNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.ClothesNameLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EditClothesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯衣物";
			this.Load += new System.EventHandler(this.EditClothesForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Label ClothesNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClothesNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CategoryNameComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.BindingSource categoryIndexVMBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controls.ucWeather ucWeather1;
        private Controls.ucOccasion ucOccasion1;
    }
}