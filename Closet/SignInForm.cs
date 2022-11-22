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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        

        private void SignInButton_Click(object sender, EventArgs e)
        {
            // 將表單欄位值繫結到view model
            SignInVM model = new SignInVM
            {
                Account = AccountTextBox.Text,
                Password = PasswordTextBox.Text
            };

            // 驗證欄位輸入是否正確
            Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
            {
                {"Account", AccountTextBox},
                {"Password", PasswordTextBox},
            };

            bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
            if (!isValid) return;

            // 判斷帳密是否正確
            bool result = new UserService().Authenticate(model,out UserDTO registrand);
            if (result == false)
            {
                MessageBox.Show("帳號或密碼錯誤");
                return;
            }

            // 若正確, 就開啟MainForm
            AccountTextBox.Text = String.Empty;
            PasswordTextBox.Text = String.Empty;

            var frm = new MainForm(registrand);
            frm.Owner = this;

            frm.Show();
            this.Hide();

            
        }

        private void SignUpLabel_Click(object sender, EventArgs e)
        {
            var frm = new SignUpForm();

            frm.Owner = this;
            frm.Show();
            this.Hide();
            
        }
    }
}
