using Closet.Infra.DAOs;
using Closet.Models.DTOs;
using Closet.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.Service
{
	public class CategoryService
	{
		private CategoryDAO _dao;

		public CategoryService()
		{
			_dao = new CategoryDAO();
		}

		public void Create(CategoryDTO model, UserDTO registrand)
		{
			
			bool isExists = _dao.CategoryNameExists(model,registrand);
			if (isExists) throw new Exception("分類已存在！！！");

            new CategoryDAO().Create(model, registrand);

        }


		public void Update(CategoryDTO model, UserDTO registrand)
		{
			bool isExists = _dao.CategoryNameExists(model, registrand);
			if (isExists) throw new Exception("分類已存在！！！");

			new CategoryDAO().Update(model, registrand);
		}

		internal void Delete(int categoryId, UserDTO registrand)
		{
			_dao.Delete(categoryId, registrand);
		}

		//public bool Authenticate(LoginVM model)
		//{
		//	var user = _dao.Get(model.Account);
		//	if (user == null) return false; // 找不到符合的帳號

		//	return (user.Password == model.Password);
		//}

	}
}