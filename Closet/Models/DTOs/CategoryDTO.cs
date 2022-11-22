using Closet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.DTOs
{
	public class CategoryDTO
	{
		public int ID { get; set; }
		public string CategoryName { get; set; }
        public int Fk_userID {get; set;}
	}
	public static class categoryDTOExist
	{
		public static CategoryIndexVM ToIndexVM(this CategoryDTO dto)
		{
			return new CategoryIndexVM
			{
				ID = dto.ID,
				CategoryName = dto.CategoryName,
				Fk_userID = dto.Fk_userID,
			};
		}
		public static CategoryVM ToVM(this CategoryDTO dto)
		{
			return new CategoryVM
			{
				ID = dto.ID,
				CategoryName = dto.CategoryName,
                Fk_userID = dto.Fk_userID,
            };
		}
	}
}
