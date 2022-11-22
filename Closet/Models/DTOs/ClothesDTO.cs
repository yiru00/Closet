using Closet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.DTOs
{
	public class ClothesDTO
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
	public static class clothesDTOExist
	{
		public static ClothesIndexVM ToIndexVM(this ClothesDTO dto)
		{
			return new ClothesIndexVM
			{
				ID = dto.ID,
				ClothesName = dto.ClothesName,
				Brand = dto.Brand,
				Color = dto.Color,
				Fk_CategoryID = dto.Fk_CategoryID,
				Fk_UserID = dto.Fk_UserID,
				Fk_OccasionID = dto.Fk_OccasionID,
				Fk_WeatherID = dto.Fk_WeatherID,
				CategoryName = dto.CategoryName,

			};
		}
		public static ClothesVM ToVM(this ClothesDTO dto)
		{
			return new ClothesVM
			{
				ID = dto.ID,
				ClothesName = dto.ClothesName,
				Brand = dto.Brand,
				Color = dto.Color,
				Fk_CategoryID = dto.Fk_CategoryID,
				Fk_UserID = dto.Fk_UserID,
				Fk_OccasionID = dto.Fk_OccasionID,
				Fk_WeatherID = dto.Fk_WeatherID,
				CategoryName = dto.CategoryName,
			};
		}
	}
	
}
