using Closet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.DTOs
{
	public class WeatherDTO
	{
		public int ID { get; set; }
		public int Cold { get; set; }
		public int Comfortable { get; set; }
		public int Hot { get; set; }

	}
	public static class WeatherDTOExist
	{
		public static WeatherIndexVM ToIndexVM(this WeatherDTO dto)
		{
			return new WeatherIndexVM
			{
				ID = dto.ID,
				Cold = dto.Cold,
				Comfortable = dto.Comfortable,
				Hot = dto.Hot,
			};
		}
		public static WeatherVM ToVM(this WeatherDTO dto)
		{
			return new WeatherVM
			{
				ID = dto.ID,
				Cold = dto.Cold,
				Comfortable = dto.Comfortable,
				Hot = dto.Hot,

			};
		}
	}
}
