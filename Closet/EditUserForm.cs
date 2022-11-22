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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Closet
{
    public partial class EditUserForm : Form
    {
        private UserDTO registrand;
        public EditUserForm(UserDTO registrand)
        {
            InitializeComponent();
            this.registrand= registrand;
            this.Load += EditUserForm_Load;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            BindData(registrand);
        }
        private void BindData(UserDTO registrand)
        {
            //登入者資料
            UserDTO dto = registrand;

            // 把DTO轉型為ViewModel
            UserVM model = dto.ToVM();

            // 再將 viewModel值繫結到各控制項
            AccountLabel.Text = model.Account; //不能修改帳號
            PasswordTextBox.Text = model.Password;
            UserNameTextBox.Text = model.UserName;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // 取得表單的各欄位值
            string account = AccountLabel.Text;
            string password = PasswordTextBox.Text;
            string userName = UserNameTextBox.Text;

            // 將它們繫結到ViewModel
            UserVM model = new UserVM
            {
                ID = this.registrand.ID,
                Account = account,
                Password = password,
                UserName = userName,
            };

            // 針對ViewModel進行欄位驗證
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                //{"Account", AccountBox},
                {"Password", PasswordTextBox},
                {"Name", UserNameTextBox},
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

                // 如果通過驗證&確認資料無誤，就編輯帳戶資料
                // 將ViewModel轉成DTO
                UserDTO dto = model.ToDTO();
                try
                {
                    new UserService().Update(dto);
                    MessageBox.Show("成功修改，請重新登入！");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
            }
            if (result == DialogResult.No) return;
            


        }
    }
}
