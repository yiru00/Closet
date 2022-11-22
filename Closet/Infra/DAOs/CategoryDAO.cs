using Closet.Models.DTOs;
using Closet.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Infra.DAOs
{
	public class CategoryDAO
	{
		public void Create(CategoryDTO model, UserDTO registrand)
		{
			string sql = "INSERT INTO categories(CategoryName,fk_userID) values(@CategoryName,@fk_userID)";
			var parameters = new SqlParameterBuilder()
				//.AddInt("@ID",model.ID)
				.AddNVarchar("@CategoryName", 50, model.CategoryName)
                .AddInt("@fk_userID",registrand.ID)
                .Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(CategoryDTO model, UserDTO registrand)
		{
			string sql = "update Categories set CategoryName=@CategoryName where ID=@categoryId and fk_userID=@userID";

			var parameters = new SqlParameterBuilder()
				.AddInt("@categoryId", model.ID)
				.AddNVarchar("@CategoryName", 50, model.CategoryName)
                .AddInt("@userID", registrand.ID)
                .Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
		public void Delete(int categoryId, UserDTO registrand)
		{
			string sql = "delete Categories where ID=@categoryId and fk_userID=@userID";

			var parameters = new SqlParameterBuilder()
				.AddInt("@id", categoryId)
                .AddInt("@userID", registrand.ID)
                .Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		//todo 
		//新增預設分類
		public IEnumerable<CategoryDTO> GetAll(int userID)
		{
			string sql = @"SELECT * FROM categories 
						where fk_userID=@userId order by id;";

            var parameters = new SqlParameterBuilder()
                .AddInt("@userId", userID)
                .Build();

            var dbHelper = new SqlDbHelper("default");
            // 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
            return dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => new CategoryDTO
				{
					ID = row.Field<int>("categories.ID"),
					CategoryName = row.Field<string>("CategoryName"),
					Fk_userID=row.Field<int>("fk_userid")
				}
                );
        }
		
		//private CategoryDTO ParseToDTO(DataRow row)
		//{
		//	return new CategoryDTO
		//	{
		//		ID = row.Field<int>("ID"),
		//		CategoryName = row.Field<string>("CategoryName"),
		//	};
		//}
		
		public bool CategoryNameExists(CategoryDTO model, UserDTO registrand)
		{
			string sql = @"SELECT Count(*) as count FROM Categories 
							join users on fk_userID=@userID
							WHERE CategoryName=@CategoryName AND ID!=@Id";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("CategoryName", 50, model.CategoryName)
				.AddInt("ID", model.ID)
				.AddInt("@userID", registrand.ID)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		public CategoryDTO Get(int categoryID, UserDTO registrand ) //點選到的ID
		{
			string sql = "SELECT * FROM Categories WHERE Id=@categoryID and fk_userID=@userID";
			var parameters = new SqlParameterBuilder()
				.AddInt("@categoryID", categoryID)
                .AddInt("@userID", registrand.ID)
                .Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到CategoryDTO
			return ToCategoryDTO(data.Rows[0]);
		}
		private CategoryDTO ToCategoryDTO(DataRow row)
		{
			return new CategoryDTO
			{
				ID = row.Field<int>("ID"),
				CategoryName = row.Field<string>("CategoryName"),
				Fk_userID=row.Field<int>("Fk_userID")
			};
		}
	}
}
