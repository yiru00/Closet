namespace Closet
{
	partial class ClothesForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClothesForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CategoryNameComboBox = new System.Windows.Forms.ComboBox();
			this.categoryIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.BrandComboBox = new System.Windows.Forms.ComboBox();
			this.clothesIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ColorComboBox = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.clothesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SearchClothesButton = new System.Windows.Forms.Button();
			this.AddNewClothesButton = new System.Windows.Forms.Button();
			this.DataGridViewLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clothesIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label1.Location = new System.Drawing.Point(39, 273);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "種類：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label2.Location = new System.Drawing.Point(39, 313);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "品牌：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.label3.Location = new System.Drawing.Point(39, 353);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "花色：";
			// 
			// CategoryNameComboBox
			// 
			this.CategoryNameComboBox.DataSource = this.categoryIndexVMBindingSource;
			this.CategoryNameComboBox.DisplayMember = "CategoryName";
			this.CategoryNameComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CategoryNameComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.CategoryNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.CategoryNameComboBox.FormattingEnabled = true;
			this.CategoryNameComboBox.Location = new System.Drawing.Point(97, 269);
			this.CategoryNameComboBox.Name = "CategoryNameComboBox";
			this.CategoryNameComboBox.Size = new System.Drawing.Size(121, 32);
			this.CategoryNameComboBox.TabIndex = 0;
			this.CategoryNameComboBox.ValueMember = "ID";
			// 
			// categoryIndexVMBindingSource
			// 
			this.categoryIndexVMBindingSource.DataSource = typeof(Closet.Models.ViewModels.CategoryIndexVM);
			// 
			// BrandComboBox
			// 
			this.BrandComboBox.DataSource = this.clothesIndexVMBindingSource;
			this.BrandComboBox.DisplayMember = "Brand";
			this.BrandComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BrandComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.BrandComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.BrandComboBox.FormattingEnabled = true;
			this.BrandComboBox.Location = new System.Drawing.Point(97, 309);
			this.BrandComboBox.Name = "BrandComboBox";
			this.BrandComboBox.Size = new System.Drawing.Size(121, 32);
			this.BrandComboBox.TabIndex = 1;
			// 
			// clothesIndexVMBindingSource
			// 
			this.clothesIndexVMBindingSource.DataSource = typeof(Closet.Models.ViewModels.ClothesIndexVM);
			// 
			// ColorComboBox
			// 
			this.ColorComboBox.DataSource = this.clothesIndexVMBindingSource;
			this.ColorComboBox.DisplayMember = "Color";
			this.ColorComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ColorComboBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ColorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.ColorComboBox.FormattingEnabled = true;
			this.ColorComboBox.Location = new System.Drawing.Point(97, 349);
			this.ColorComboBox.Name = "ColorComboBox";
			this.ColorComboBox.Size = new System.Drawing.Size(121, 32);
			this.ColorComboBox.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clothesNameDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.clothesIndexVMBindingSource;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(49, 76);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(343, 180);
			this.dataGridView1.TabIndex = 6;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// clothesNameDataGridViewTextBoxColumn
			// 
			this.clothesNameDataGridViewTextBoxColumn.DataPropertyName = "ClothesName";
			this.clothesNameDataGridViewTextBoxColumn.HeaderText = "名稱";
			this.clothesNameDataGridViewTextBoxColumn.Name = "clothesNameDataGridViewTextBoxColumn";
			// 
			// brandDataGridViewTextBoxColumn
			// 
			this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
			this.brandDataGridViewTextBoxColumn.HeaderText = "品牌";
			this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
			// 
			// colorDataGridViewTextBoxColumn
			// 
			this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
			this.colorDataGridViewTextBoxColumn.HeaderText = "花色";
			this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
			// 
			// SearchClothesButton
			// 
			this.SearchClothesButton.BackgroundImage = global::Closet.Properties.Resources._300;
			this.SearchClothesButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SearchClothesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.SearchClothesButton.FlatAppearance.BorderSize = 3;
			this.SearchClothesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.SearchClothesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.SearchClothesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SearchClothesButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.SearchClothesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.SearchClothesButton.Location = new System.Drawing.Point(228, 286);
			this.SearchClothesButton.Name = "SearchClothesButton";
			this.SearchClothesButton.Size = new System.Drawing.Size(75, 75);
			this.SearchClothesButton.TabIndex = 7;
			this.SearchClothesButton.UseVisualStyleBackColor = true;
			this.SearchClothesButton.Click += new System.EventHandler(this.SearchClothesButton_Click);
			// 
			// AddNewClothesButton
			// 
			this.AddNewClothesButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddNewClothesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.AddNewClothesButton.FlatAppearance.BorderSize = 3;
			this.AddNewClothesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.AddNewClothesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.AddNewClothesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddNewClothesButton.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.AddNewClothesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.AddNewClothesButton.Location = new System.Drawing.Point(320, 286);
			this.AddNewClothesButton.Name = "AddNewClothesButton";
			this.AddNewClothesButton.Size = new System.Drawing.Size(75, 75);
			this.AddNewClothesButton.TabIndex = 8;
			this.AddNewClothesButton.Text = "+";
			this.AddNewClothesButton.UseVisualStyleBackColor = true;
			this.AddNewClothesButton.Click += new System.EventHandler(this.AddNewClothesButton_Click);
			// 
			// DataGridViewLabel
			// 
			this.DataGridViewLabel.AutoSize = true;
			this.DataGridViewLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.DataGridViewLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(2)))));
			this.DataGridViewLabel.Location = new System.Drawing.Point(49, 36);
			this.DataGridViewLabel.Name = "DataGridViewLabel";
			this.DataGridViewLabel.Size = new System.Drawing.Size(90, 21);
			this.DataGridViewLabel.TabIndex = 9;
			this.DataGridViewLabel.Text = "所有衣物：";
			// 
			// ClothesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(240)))));
			this.ClientSize = new System.Drawing.Size(440, 417);
			this.Controls.Add(this.DataGridViewLabel);
			this.Controls.Add(this.AddNewClothesButton);
			this.Controls.Add(this.SearchClothesButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ColorComboBox);
			this.Controls.Add(this.BrandComboBox);
			this.Controls.Add(this.CategoryNameComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(456, 456);
			this.MinimumSize = new System.Drawing.Size(456, 456);
			this.Name = "ClothesForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "查看衣櫃";
			((System.ComponentModel.ISupportInitialize)(this.categoryIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clothesIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CategoryNameComboBox;
        private System.Windows.Forms.ComboBox BrandComboBox;
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchClothesButton;
        private System.Windows.Forms.Button AddNewClothesButton;
        private System.Windows.Forms.Label DataGridViewLabel;
        private System.Windows.Forms.BindingSource categoryIndexVMBindingSource;
        private System.Windows.Forms.BindingSource clothesIndexVMBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clothesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
    }
}