using Closet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.DTOs
{
	public class OccasionDTO
	{
		public int ID { get; set; }
		public int Formal { get; set; }
		public int Casual { get; set; }
		public int Sports { get; set; }
	}
	public static class OccasionDTOExist
	{
		public static OccasionIndexVM ToIndexVM(this OccasionDTO dto)
		{
			return new OccasionIndexVM
			{
				ID = dto.ID,
				Formal = dto.Formal,
				Casual = dto.Casual,
				Sports = dto.Sports,

			};
		}
		public static OccasionVM ToVM(this OccasionDTO dto)
		{
			return new OccasionVM
			{
				ID = dto.ID,
				Formal = dto.Formal,
				Casual = dto.Casual,
				Sports = dto.Sports,

			};
		}
	}
}
