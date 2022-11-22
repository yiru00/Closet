using Closet.Infra;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            // 取得表單的各欄位值
            string account = AccountTextBox.Text;
            string password = PasswordTextBox.Text;
            string userName = UserNameTextBox.Text;

            
            // 將它們繫結到ViewModel
            UserVM model = new UserVM
            {
                Account = account,
                Password = password,
                UserName = userName,
            };
            


            // 針對ViewModel進行欄位驗證
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Account", AccountTextBox},
                {"Password", PasswordTextBox},
                {"UserName", UserNameTextBox},
            };

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;

            //確認資料
            DialogResult result = MessageBox.Show($"帳號：{model.Account}\r\n密碼：{model.Password}\r\n姓名：{model.UserName}",
                "確認資料是否正確？",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (result == DialogResult.Yes) 
            {
                // 如果通過驗證&確認資料無誤，就新增帳號
                // 將ViewModel轉成DTO
                UserDTO dto = model.ToDTO();
                try
                {
                    new UserService().Create(dto);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("成功註冊！");
                this.Close();
            }
            

            //if (result == DialogResult.Yes) this.Close();
            
            if (result == DialogResult.No) return;
        }

        

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
