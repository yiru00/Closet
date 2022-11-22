using Closet.Infra;
using Closet.Infra.DAOs;
using Closet.Models.DTOs;
using Closet.Models.Service;
using Closet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Closet
{
	public partial class CreateClothesForm : Form
	{
        private UserDTO registrand;
        public CreateClothesForm( UserDTO registrand)
		{
			InitializeComponent();
			this.registrand = registrand;
			CategoryNameInitForm();
		}


		private void AddNewButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string clothesName = ClothesNameTextBox.Text;
			string brand = BrandTextBox.Text;
			string color = ColorTextBox.Text;
			int fk_CategoryId = ((CategoryIndexVM)this.CategoryNameComboBox.SelectedItem).ID;

			string weatherValue = ucWeather1.GetValue();
			int fk_WeatherId = 8;
			#region 根據得到的字串 取得fk_WeatherId
			if (weatherValue == "0,0,0")
			{
				fk_WeatherId = 8;
				//MessageBox.Show("至少選擇一種適合天氣");
				//return;
			}
			else if (weatherValue == "1,1,1")
			{
				fk_WeatherId = 1;
			}
			else if (weatherValue == "1,0,0")
			{
				fk_WeatherId = 2;
			}
			else if (weatherValue == "1,0,1")
			{
				fk_WeatherId = 3;
			}
			else if (weatherValue == "1,1,0")
			{
				fk_WeatherId = 4;
			}
			else if (weatherValue == "0,1,1")
			{
				fk_WeatherId = 5;
			}
			else if (weatherValue == "0,1,0")
			{
				fk_WeatherId = 6;
			}
			else if (weatherValue == "0,0,1")
			{
				fk_WeatherId = 7;
			}
			#endregion

			string Occasionvalue = ucOccasion1.GetValue();
			int fk_OccasionId=8;
			
			#region 根據得到的字串 取得fk_OccasionId
			if (Occasionvalue == "0,0,0")
			{
				fk_OccasionId = 8;
				//MessageBox.Show("至少選擇一種場合");
				//return;
			}
			else if (Occasionvalue == "1,1,1")
			{
				fk_OccasionId = 1;
			}
			else if (Occasionvalue == "1,0,0")
			{
				fk_OccasionId = 2;
			}
			else if (Occasionvalue == "1,0,1")
			{
				fk_OccasionId = 3;
			}
			else if (Occasionvalue == "1,1,0")
			{
				fk_OccasionId = 4;
			}
			else if (Occasionvalue == "0,1,1")
			{
				fk_OccasionId = 5;
			}
			else if (Occasionvalue == "0,1,0")
			{
				fk_OccasionId = 6;
			}
			else if (Occasionvalue == "0,0,1")
			{
				fk_OccasionId = 7;
			}
		
			#endregion

			int fk_UserId = registrand.ID;

			// 將它們繫結到ViewModel
			ClothesVM model = new ClothesVM
			{
				
				ClothesName = clothesName,
				Brand = brand,
				Color = color,
				Fk_CategoryID = fk_CategoryId,
				Fk_WeatherID = fk_WeatherId,
				Fk_OccasionID = fk_OccasionId,
				Fk_UserID=fk_UserId

			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"clothesName", ClothesNameTextBox},
				{ "Brand",BrandTextBox},
				{"Color", ColorTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			if (fk_CategoryId == 0)
			{
				MessageBox.Show("記得選取種類");
				return;
			}
			if (fk_WeatherId == 8)
			{
				MessageBox.Show("至少選擇一種適合天氣");
				return;
			}
			if (fk_OccasionId == 8)
			{
				MessageBox.Show("至少選擇一種適合場合");
				return;
			}
			//確認資料
			DialogResult result = MessageBox.Show($"確定新增 {model.ClothesName} ？",
               "新增衣物",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
			{

                // 如果通過驗證,就新增記錄
                // 將ViewModel轉成DTO
                ClothesDTO dto = model.ToDTO();

                new ClothesService().Create(dto);
            }
            if (result == DialogResult.No) return;


            this.DialogResult = DialogResult.OK;
			
		}

		private void CategoryNameInitForm()
		{
			// 設定 categoryIdComboBox property，不顯示未分類
			CategoryNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			List<CategoryIndexVM> categories = new ClothesDAO().GetCategoryNameEditClothesComboBox().ToList();

			this.CategoryNameComboBox.DataSource = categories;

		}
	}
}

