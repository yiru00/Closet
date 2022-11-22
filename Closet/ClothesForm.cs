using Closet.Infra.DAOs;
using Closet.Models.DTOs;
using Closet.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Closet
{
	public partial class ClothesForm : Form
	{
		private ClothesIndexVM[] clothes = null;
        private UserDTO registrand;
        public ClothesForm(UserDTO registrand)
		{
			InitializeComponent();
            this.registrand = registrand;
            CategoryNameInitForm();
			ColorInitForm(registrand);
			BrandInitForm(registrand);
			
			// 顯示所有衣服
			DisplayClothes(registrand);
		}
		
		private void DisplayClothes(UserDTO registrand) //searchButton的display
		{

            //取得篩選值
            int categoryId = ((CategoryIndexVM)CategoryNameComboBox.SelectedItem).ID;
            string brand=((ClothesIndexVM)BrandComboBox.SelectedItem).Brand;
			string color= ((ClothesIndexVM)ColorComboBox.SelectedItem).Color;

			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			clothes = new ClothesDAO().GetAll(categoryId, brand,color, registrand)
						.Select(dto => dto.ToIndexVM())
						.ToArray();

			BindData(clothes);

            //搜尋完後data grid view 上方顯示搜尋的條件
            string categoryName = ((CategoryIndexVM)CategoryNameComboBox.SelectedItem).CategoryName;

            BindLabel(categoryName, brand, color);
			
		}

		private void BindLabel(string categoryName,string brand,string color)
		{
            string result = $"種類： {categoryName}       品牌： {brand}        顏色: {color}";
			DataGridViewLabel.Text = result;
        }

		private void BindData(ClothesIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void CategoryNameInitForm( )
		{
			// 設定 categoryIdComboBox property
			CategoryNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			List<CategoryIndexVM> categories = new ClothesDAO().GetCategoryNameComboBox() .ToList();

			this.CategoryNameComboBox.DataSource = categories;

		}
		private void BrandInitForm(UserDTO registrand)
		{
			// 設定 categoryIdComboBox property
			BrandComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			

			List<ClothesIndexVM> categories = new ClothesDAO().
				GetBrandComboBox(registrand).ToList();

			this.BrandComboBox.DataSource = categories;
			

		}
		private void ColorInitForm(UserDTO registrand)
		{
			// 設定 categoryIdComboBox property
			ColorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			List<ClothesIndexVM> categories = new ClothesDAO().
				GetColorComboBox(registrand).ToList();

			this.ColorComboBox.DataSource = categories;

		}

		private void SearchClothesButton_Click(object sender, EventArgs e)
		{
			DisplayClothes(registrand);
			
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;//取得選取欄位索引

			if (rowIndex == -1) return;//找不到索引=> index = -1
			
			ClothesIndexVM row = this.clothes[rowIndex]; // 使用者點到的那一筆記錄

			int clothesId = row.ID; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditClothesForm( clothesId, registrand);

			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
                //datagridview要重新顯示'全部'內容，下拉選單的選項也要更新

                //下拉選單重新繫結(預設是全選)
                CategoryNameInitForm();
                ColorInitForm(registrand);
                BrandInitForm(registrand);


				//datagridview顯示
				DisplayClothes(registrand);
            }
		}

		private void AddNewClothesButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateClothesForm(registrand);
			//frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
                //datagridview要重新顯示'全部'內容，下拉選單的選項也要更新


                //下拉選單重新繫結(預設是全選)
                CategoryNameInitForm();
                ColorInitForm(registrand);
                BrandInitForm(registrand);

				//datagridview顯示
				DisplayClothes(registrand);
            }
		}
	}
}
