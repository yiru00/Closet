using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Closet.Controls
{
	public partial class ucOccasion : UserControl
	{
		public ucOccasion()
		{
			InitializeComponent();
		}
		public string GetValue()
		{
			CheckBox[] controls = new CheckBox[] { checkBox1, checkBox2, checkBox3, };

			string value = string.Empty; //記錄哪些值被勾選，勾選是1，未勾是0 
			foreach (CheckBox item in controls)
			{
				if (item.Checked)
				{
					value += ",1";
					continue;
				}
				if (!item.Checked)
				{
					value += ",0";
				}
			}

			value = value.Substring(1); // 把最前面的逗號刪除


			return value;  //三個都勾會得到字串"1,1,1"

		}
		public void SetValue(int fk_OccasionId)
		{
			CheckBox[] controls = new CheckBox[] { checkBox1, checkBox2, checkBox3 };
			// 先將所有checkbox取消勾選
			foreach (CheckBox item in controls)
			{
				item.Checked = false;
			}

			#region 根據 fk_weatherId值,決定哪些checkbox要勾選
			if (fk_OccasionId == 1)
			{
				checkBox1.Checked = true;
				checkBox2.Checked = true;
				checkBox3.Checked = true;
			}
			else if (fk_OccasionId == 2)
			{
				checkBox1.Checked = true;
				checkBox2.Checked = false;
				checkBox3.Checked = false;
			}
			else if (fk_OccasionId == 3)
			{
				checkBox1.Checked = true;
				checkBox2.Checked = false;
				checkBox3.Checked = true;
			}
			else if (fk_OccasionId == 4)
			{
				checkBox1.Checked = true;
				checkBox2.Checked = true;
				checkBox3.Checked = false;
			}
			else if (fk_OccasionId == 5)
			{
				checkBox1.Checked = false;
				checkBox2.Checked = true;
				checkBox3.Checked = true;
			}
			else if (fk_OccasionId == 6)
			{
				checkBox1.Checked = false;
				checkBox2.Checked = true;
				checkBox3.Checked = false;
			}
			else if (fk_OccasionId == 7)
			{
				checkBox1.Checked = false;
				checkBox2.Checked = false;
				checkBox3.Checked = true;
			}
			else if (fk_OccasionId == 8)
			{
				checkBox1.Checked = false;
				checkBox2.Checked = false;
				checkBox3.Checked = false;
			}
			#endregion
		}
    }
}
