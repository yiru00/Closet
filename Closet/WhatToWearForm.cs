using Closet.Infra.DAOs;
using Closet.Models.DTOs;
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
	public partial class WhatToWearForm : Form
	{
		private UserDTO registrand;
        private ClothesIndexVM[] top = null;
        private ClothesIndexVM[] outerwear = null;
        private ClothesIndexVM[] bottom = null;
        private ClothesIndexVM[] acc = null;


        public WhatToWearForm(UserDTO registrand)
		{
			InitializeComponent();
			this.registrand = registrand;
			UserNameLabel.Text = $"HI!{registrand.UserName }";
        }

        private void DisplayData(string weatherValue,string occasionValue,int fk_userId,string categoryName, ClothesIndexVM[] data,DataGridView table) 
        {

            data = new ClothesDAO().GetData(weatherValue, occasionValue, fk_userId, categoryName)
                        .Select(dto => dto.ToIndexVM())
                        .ToArray();
           //bind data
            table.DataSource= data;
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //取得篩選值
            string weatherValue = ucWeatherRB1.GetValue(); //得"hot"代表勾炎熱
            string occasionValue = ucOccasionRB1.GetValue();
            int fk_userId = registrand.ID;
            if (string.IsNullOrEmpty(weatherValue))
            {
                MessageBox.Show("請選擇天氣如何");
                return;
            }
            if (string.IsNullOrEmpty(occasionValue))
            {
                MessageBox.Show("請選擇哪種場合");
                return;
            }
            
            DisplayData(weatherValue, occasionValue, fk_userId, "上衣", top, topDataGridView);
            DisplayData(weatherValue, occasionValue, fk_userId, "下身", bottom, BottomDataGridView);
            DisplayData(weatherValue, occasionValue, fk_userId, "外套", outerwear, OuterwearDataGridView);
            DisplayData(weatherValue, occasionValue, fk_userId, "配件", acc, accDataGridView);
        }

    }
}
