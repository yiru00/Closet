using Closet.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.ViewModels
{
	public class WeatherIndexVM
	{
		public int ID { get; set; }
		public int Cold { get; set; }
		public int Comfortable { get; set; }
		public int Hot { get; set; }
	}
	public class WeatherVM
	{
		public int ID { get; set; }
		public int Cold { get; set; }
		public int Comfortable { get; set; }
		public int Hot { get; set; }
	}
	public static class WeatherVMExts
	{
		public static WeatherDTO ToDTO(this WeatherVM vm)
		{
			return new WeatherDTO
			{
				ID = vm.ID,
				Cold = vm.Cold,
				Comfortable = vm.Comfortable,
				Hot = vm.Hot,
			};
		}
	}
}
