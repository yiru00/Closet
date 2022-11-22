using Closet.Infra.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Closet.Controls
{
    public partial class ucOccasionRB : UserControl
    {
        public ucOccasionRB()
        {
            InitializeComponent();
        }
        public string GetValue()
        {
            RadioButton[] controls = new RadioButton[] { radioButton1, radioButton2, radioButton3 };

            string value = string.Empty; //記錄哪個值被勾選，value=勾選的TAG值 
            foreach (RadioButton item in controls)
            {
                if (item.Checked)
                {
                    value += item.Tag;
                    break;
                }
            }
            return value;
        }
    }
}
