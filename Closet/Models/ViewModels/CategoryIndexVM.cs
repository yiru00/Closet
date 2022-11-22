using Closet.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.ViewModels
{
	public class CategoryIndexVM
	{
		public int ID { get; set; }
		public string CategoryName { get; set; }
		public int Fk_userID { get; set; }
	}

	public class CategoryVM
	{
		public int ID { get; set; }
		[Required(ErrorMessage = "必填")]
		public string CategoryName { get; set; }
        public int Fk_userID { get; set; }
    }
	public static class CategoryVMExts
	{
		public static CategoryDTO ToDTO(this CategoryVM vm)
		{
			return new CategoryDTO
			{
				ID = vm.ID,
				CategoryName = vm.CategoryName,
				Fk_userID=vm.Fk_userID
			};
		}
	}
}
