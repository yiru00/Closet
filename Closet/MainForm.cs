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
	public partial class MainForm : Form
	{
		private UserDTO registrand;
        public MainForm(UserDTO registrand)//傳入登入的使用者DTO
		{
			InitializeComponent();
			this.registrand = registrand;
			UserNameLabel.Text = $"{registrand.UserName} 的衣櫃";
			LogoutButton.Text = String.Empty;
			ClothesButton.Text = String.Empty ;
			WhatToWearButton.Text = string.Empty;
			UserEditButton.Text = String.Empty ;

		}

		private void ClothesButton_Click(object sender, EventArgs e)
		{
            var frm = new ClothesForm(registrand);
            frm.ShowDialog();
			
        }

		private void WhatToWearButton_Click(object sender, EventArgs e)
		{
            var frm = new WhatToWearForm(registrand);
            frm.ShowDialog();
        }

        private void UserEditButton_Click(object sender, EventArgs e)
        {
            var frm = new EditUserForm(registrand);
            DialogResult result = frm.ShowDialog();
            if (result==DialogResult.OK)//更改過資料要重新登入
            {
                this.Close();//關閉事件會開啟此表單擁有者(登入畫面表單)
            }

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"確定登出 {registrand.UserName} 的衣櫃？",
                "登出",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();//關閉事件會開啟此表單擁有者(登入畫面表單)
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }

		

		private void LogoutButton_MouseMove(object sender, MouseEventArgs e)
		{
			logoutLabel.Visible = false;
			LogoutButton.Text = "登出";
		}

		private void LogoutButton_MouseLeave(object sender, EventArgs e)
		{
			logoutLabel.Visible = true;
			LogoutButton.Text = String.Empty;
		}

		private void ClothesButton_MouseMove(object sender, MouseEventArgs e)
		{
			clothesPanel.Visible = false;
			ClothesButton.Text = "查看衣櫃";
		}

		private void ClothesButton_MouseLeave(object sender, EventArgs e)
		{
			clothesPanel.Visible = true;
			ClothesButton.Text = String.Empty;
		}

		private void WhatToWearButton_MouseMove(object sender, MouseEventArgs e)
		{
			WhatToWearButton.Text = "今天穿什麼";
			
		}

		private void WhatToWearButton_MouseLeave(object sender, EventArgs e)
		{
			WhatToWearButton.Text=String.Empty;
		}

		private void UserEditButton_MouseMove(object sender, MouseEventArgs e)
		{
			userLabel.Visible=false;
			UserEditButton.Text = "修改資料";

		}

		private void UserEditButton_MouseLeave(object sender, EventArgs e)
		{
			userLabel.Visible = true;
			UserEditButton.Text = String.Empty;
		}
	}
}
