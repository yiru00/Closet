using Closet.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.ViewModels
{
	public class ClothesIndexVM
	{
		public int ID { get; set; }
		public string ClothesName { get; set; }
		public string Brand { get; set; }
		public string Color { get; set; }
		public int Fk_CategoryID { get; set; }
		public int Fk_UserID { get; set; }
		public int Fk_OccasionID { get; set; }
		public int Fk_WeatherID { get; set; }
		public string CategoryName { get; set; }

	}
	public class ClothesVM
	{
		public int ID { get; set; }
		[Required(ErrorMessage = "必填")]
		public string ClothesName { get; set; }
		[Required(ErrorMessage = "必填")]
		public string Brand { get; set; }
		[Required(ErrorMessage = "必填")]
		public string Color { get; set; }
		
		public int Fk_CategoryID { get; set; }
		public int Fk_UserID { get; set; }
		public int Fk_OccasionID { get; set; }
		public int Fk_WeatherID { get; set; }
		public string CategoryName { get; set; }

	}
	public static class ClothesVMExts
	{
		public static ClothesDTO ToDTO(this ClothesVM vm)
		{
			return new ClothesDTO
			{
				ID = vm.ID,
				ClothesName = vm.ClothesName,
				Brand = vm.Brand,
				Color = vm.Color,
				Fk_CategoryID = vm.Fk_CategoryID,
				Fk_UserID = vm.Fk_UserID,
				Fk_OccasionID = vm.Fk_OccasionID,
				Fk_WeatherID = vm.Fk_WeatherID,
				CategoryName = vm.CategoryName,
			};
		}
	}
}
