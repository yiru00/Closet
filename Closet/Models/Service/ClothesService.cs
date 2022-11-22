using Closet.Infra.DAOs;
using Closet.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.Service
{

	public class ClothesService
	{
		private ClothesDAO _dao;

		public ClothesService()
		{
			_dao = new ClothesDAO();
		}
		internal void Update(ClothesDTO model)
		{

            _dao.Update(model);
		}
		internal void Delete(int id)
		{
			_dao.Delete(id);
		}
		public void Create(ClothesDTO model)
		{

            _dao.Create(model);

		}

	}


}
