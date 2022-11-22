using Closet.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.ViewModels
{
	public class OccasionIndexVM
	{
		public int ID { get; set; }
		public int Formal { get; set; }
		public int Casual { get; set; }
		public int Sports { get; set; }
	}
	public class OccasionVM
	{
		public int ID { get; set; }
		public int Formal { get; set; }
		public int Casual { get; set; }
		public int Sports { get; set; }
	}
	public static class OccasionVMExts
	{
		public static OccasionDTO ToDTO(this OccasionVM vm)
		{
			return new OccasionDTO
			{
				ID = vm.ID,
				Formal = vm.Formal,
				Casual = vm.Casual,
				Sports = vm.Sports,

			};
		}
	}
}
