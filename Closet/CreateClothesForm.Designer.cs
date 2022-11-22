namespace Closet
{
	partial class CreateClothesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClothesForm));
			this.AddNewButton = new System.Windows.Forms.Button();
			this.categoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.ucOccasion1 = new Closet.Controls.ucOccasion();
			this.ucWeather1 = new Closet.Controls.ucWeather();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BrandTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ColorTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.CategoryNameComboBox = new System.Windows.Forms.ComboBox();
			this.categoryIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.ClothesNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// AddNewButton
			// 
			this.AddNewButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddNewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.AddNewButton.FlatAppearance.BorderSize = 3;
			this.AddNewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.AddNewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNewButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AddNewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.AddNewButton.Location = new System.Drawing.Point(367, 311);
			this.AddNewButton.Name = "AddNewButton";
			this.AddNewButton.Size = new System.Drawing.Size(80, 37);
			this.AddNewButton.TabIndex = 4;
			this.AddNewButton.Text = "儲存";
			this.AddNewButton.UseVisualStyleBackColor = true;
			this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// categoryIndexVMBindingSource
			// 
			this.categoryIndexVMBindingSource.DataSource = typeof(Closet.Models.ViewModels.CategoryIndexVM);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// ucOccasion1
			// 
			this.ucOccasion1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ucOccasion1.Location = new System.Drawing.Point(142, 253);
			this.ucOccasion1.Name = "ucOccasion1";
			this.ucOccasion1.Size = new System.Drawing.Size(305, 20);
			this.ucOccasion1.TabIndex = 5;
			this.ucOccasion1.TabStop = false;
			// 
			// ucWeather1
			// 
			this.ucWeather1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ucWeather1.Location = new System.Drawing.Point(142, 195);
			this.ucWeather1.Name = "ucWeather1";
			this.ucWeather1.Size = new System.Drawing.Size(305, 20);
			this.ucWeather1.TabIndex = 4;
			this.ucWeather1.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label8.Location = new System.Drawing.Point(42, 251);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 24);
			this.label8.TabIndex = 39;
			this.label8.Text = "適合場合：";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label7.Location = new System.Drawing.Point(42, 193);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 24);
			this.label7.TabIndex = 38;
			this.label7.Text = "適合天氣：";
			// 
			// BrandTextBox
			// 
			this.BrandTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BrandTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.BrandTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.BrandTextBox.Location = new System.Drawing.Point(327, 127);
			this.BrandTextBox.MaxLength = 15;
			this.BrandTextBox.Name = "BrandTextBox";
			this.BrandTextBox.Size = new System.Drawing.Size(120, 26);
			this.BrandTextBox.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label6.Location = new System.Drawing.Point(262, 128);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 24);
			this.label6.TabIndex = 36;
			this.label6.Text = "品牌：";
			// 
			// ColorTextBox
			// 
			this.ColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ColorTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ColorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ColorTextBox.Location = new System.Drawing.Point(327, 56);
			this.ColorTextBox.MaxLength = 10;
			this.ColorTextBox.Name = "ColorTextBox";
			this.ColorTextBox.Size = new System.Drawing.Size(120, 26);
			this.ColorTextBox.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label5.Location = new System.Drawing.Point(262, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 24);
			this.label5.TabIndex = 34;
			this.label5.Text = "花色：";
			// 
			// CategoryNameComboBox
			// 
			this.CategoryNameComboBox.DataSource = this.categoryIndexVMBindingSource1;
			this.CategoryNameComboBox.DisplayMember = "CategoryName";
			this.CategoryNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CategoryNameComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CategoryNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.CategoryNameComboBox.FormattingEnabled = true;
			this.CategoryNameComboBox.Location = new System.Drawing.Point(109, 124);
			this.CategoryNameComboBox.Name = "CategoryNameComboBox";
			this.CategoryNameComboBox.Size = new System.Drawing.Size(120, 32);
			this.CategoryNameComboBox.TabIndex = 2;
			// 
			// categoryIndexVMBindingSource1
			// 
			this.categoryIndexVMBindingSource1.DataSource = typeof(Closet.Models.ViewModels.CategoryIndexVM);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label4.Location = new System.Drawing.Point(44, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 24);
			this.label4.TabIndex = 32;
			this.label4.Text = "種類：";
			// 
			// ClothesNameTextBox
			// 
			this.ClothesNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ClothesNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ClothesNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ClothesNameTextBox.Location = new System.Drawing.Point(109, 56);
			this.ClothesNameTextBox.MaxLength = 10;
			this.ClothesNameTextBox.Name = "ClothesNameTextBox";
			this.ClothesNameTextBox.Size = new System.Drawing.Size(120, 26);
			this.ClothesNameTextBox.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label3.Location = new System.Drawing.Point(44, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 24);
			this.label3.TabIndex = 30;
			this.label3.Text = "名稱：";
			// 
			// CreateClothesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.ClientSize = new System.Drawing.Size(489, 401);
			this.Controls.Add(this.ucOccasion1);
			this.Controls.Add(this.ucWeather1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BrandTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.ColorTextBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.CategoryNameComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ClothesNameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddNewButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CreateClothesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "新增衣物";
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.BindingSource categoryIndexVMBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controls.ucOccasion ucOccasion1;
        private Controls.ucWeather ucWeather1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CategoryNameComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ClothesNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource categoryIndexVMBindingSource1;
    }
}