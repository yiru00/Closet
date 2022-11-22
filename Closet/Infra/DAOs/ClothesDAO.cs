using Closet.Models.DTOs;
using Closet.Models.ViewModels;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Infra.DAOs
{

	public class ClothesDAO

	{
		public ClothesDTO Get(int clothesId,UserDTO registrand)
		{
			string sql = "SELECT * FROM Clothes join categories on clothes.fk_CategoryId=categories.id WHERE clothes.Id=@Id and fk_userId=@Fk_UserID";
			var parameters = new SqlParameterBuilder()
				.AddInt("@Id", clothesId)
                .AddInt("@Fk_UserID", registrand.ID)
                .Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到ClothesDTO
			return ToClothesDTO(data.Rows[0]);
		}
		private ClothesDTO ToClothesDTO(DataRow row)
		{
			return new ClothesDTO
			{
				ID = row.Field<int>("ID"),
				ClothesName = row.Field<string>("ClothesName"),
				Brand = row.Field<string>("Brand"),
				Color = row.Field<string>("Color"),
				Fk_CategoryID = row.Field<int>("Fk_CategoryID"),
				Fk_UserID = row.Field<int>("Fk_UserID"),
				Fk_OccasionID = row.Field<int>("Fk_OccasionID"),
				Fk_WeatherID = row.Field<int>("Fk_WeatherID"),
				CategoryName = row.Field<string>("CategoryName"),
			};
		}

		/// <summary>
		/// 有comboBox搜尋完後的呈現
		/// </summary>
		/// <param name="categoryId">分類comboBox選取的選項</param>
		/// <param name="brand">品牌comboBox選取的選項</param>
		/// <param name="color">顏色comboBox選取的選項</param>
		/// <returns></returns>
		public IEnumerable<ClothesDTO> GetAll(int categoryId, string brand, string color, UserDTO registrand) //有combox搜尋的
		{
            string sql = $"SELECT * FROM Clothes join categories on clothes.fk_CategoryId=categories.id Where Fk_UserID={registrand.ID}";

        
            //if (categoryId > -1 || brand!="全選" || color!="全選")
            //{
            //sql += "WHERE ";

            //bool isFirst = true;
                if (categoryId >0)
                {
                    //if (!isFirst) sql += " AND ";
                    sql += $" and fk_CategoryId={categoryId}";

                    //isFirst = false;
                }
                if (brand != "全選")
                {
                    //if (!isFirst) sql += " AND ";
                    sql += $" and Brand='{brand}'";
                    //isFirst = false;
                }
                if (color != "全選")
                {
                    //if (!isFirst) sql += " AND ";
                    sql += $" and Color='{color}'";
                    //isFirst = false;
                }

            //}
            

            var dbHelper = new SqlDbHelper("default");
            return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new ClothesDTO
				{
					ID = row.Field<int>("ID"),
					ClothesName = row.Field<string>("ClothesName"),
					Brand = row.Field<string>("Brand"),
					Color = row.Field<string>("Color"),
					Fk_CategoryID = row.Field<int>("Fk_CategoryID"),
					Fk_UserID = row.Field<int>("Fk_UserID"),
					Fk_OccasionID = row.Field<int>("Fk_OccasionID"),
					Fk_WeatherID = row.Field<int>("Fk_WeatherID"),
					CategoryName = row.Field<string>("CategoryName"),
				});

		}
		
        public IEnumerable<CategoryIndexVM> GetCategoryNameComboBox()
        {
            var sql = "SELECT * FROM Categories ORDER BY ID";  
            var dbHelper = new SqlDbHelper("default");

            return dbHelper.Select(sql, null)
            .AsEnumerable()
            .Select(row => ToCategoryIndexVM(row))
            .Prepend(new CategoryIndexVM { ID = 0, CategoryName ="全選"})

            ;

        }
		public IEnumerable<CategoryIndexVM> GetCategoryNameEditClothesComboBox()
		{
			var sql = "SELECT * FROM Categories ORDER BY ID";
			var dbHelper = new SqlDbHelper("default");

			return dbHelper.Select(sql, null)
			.AsEnumerable()
			.Select(row => ToCategoryIndexVM(row))
			.Prepend(new CategoryIndexVM { ID = 0, CategoryName = String.Empty })
			//第一項是空白=>驗證會寫不能空白 id不能<0
			;

		}
		
		private CategoryIndexVM ToCategoryIndexVM(DataRow row)
		{
			return new CategoryIndexVM
            {
				ID = row.Field<int>("ID"),
				CategoryName = row.Field<string>("CategoryName"),

			};
		}
		public IEnumerable<ClothesIndexVM> GetBrandComboBox(UserDTO registrand)
		{
			var sql = "SELECT DISTINCT Brand FROM Clothes where Fk_UserID=@Fk_UserID ORDER BY brand";
			var dbHelper = new SqlDbHelper("default");
            var parameters = new SqlParameterBuilder()
                .AddInt("@Fk_UserID", registrand.ID)
                .Build();

            return dbHelper.Select(sql, parameters)
			.AsEnumerable()
			.Select(row => ToClothesBrandIndexVM(row))
            .Prepend(new ClothesIndexVM {  Brand = "全選" })
			;

		}
        public IEnumerable<ClothesIndexVM> GetColorComboBox(UserDTO registrand)
        {
            var sql = "SELECT DISTINCT Color FROM Clothes where Fk_UserID=@Fk_UserID ORDER BY color";
            var dbHelper = new SqlDbHelper("default");
            var parameters = new SqlParameterBuilder()
                .AddInt("@Fk_UserID", registrand.ID)
                .Build();

            return dbHelper.Select(sql, parameters)
            .AsEnumerable()
            .Select(row => ToClothesColorIndexVM(row))
            .Prepend(new ClothesIndexVM { Color = "全選" })
            ;

        }
        private ClothesIndexVM ToClothesColorIndexVM(DataRow row)
        {
            return new ClothesIndexVM
            {
                //ID = row.Field<int>("ID"),
                //ClothesName = row.Field<string>("ClothesName"),
                //Brand = row.Field<string>("Brand"),
                Color = row.Field<string>("Color"),
                //Fk_CategoryID = row.Field<int>("Fk_CategoryID"),
                //Fk_UserID = row.Field<int>("Fk_UserID"),
                //Fk_OccasionID = row.Field<int>("Fk_OccasionID"),
                //Fk_WeatherID = row.Field<int>("Fk_WeatherID"),
            };
        }
        private ClothesIndexVM ToClothesBrandIndexVM(DataRow row)
		{
			return new ClothesIndexVM
			{
				//ID = row.Field<int>("ID"),
				//ClothesName = row.Field<string>("ClothesName"),
				Brand = row.Field<string>("Brand"),
				//Color = row.Field<string>("Color"),
				//Fk_CategoryID = row.Field<int>("Fk_CategoryID"),
				//Fk_UserID = row.Field<int>("Fk_UserID"),
				//Fk_OccasionID = row.Field<int>("Fk_OccasionID"),
				//Fk_WeatherID = row.Field<int>("Fk_WeatherID"),
			};
		}

		//public bool ClothesNameExists(ClothesDTO model)
		//{
		//	string sql = @"SELECT Count(*) as count FROM Clothes WHERE ClothesName=@ClothesName AND fk_userId=@fk_userId";

		//	var parameters = new SqlParameterBuilder()
		//		.AddNVarchar("@ClothesName", 50, model.ClothesName)
		//		.AddInt("@fk_userId", model.ID)
  //              .Build();

		//	DataTable data = new SqlDbHelper("default").Select(sql, parameters);
		//	return data.Rows[0].Field<int>("count") > 0;
		//}
		public void Update(ClothesDTO model)
		{
			string sql = "update clothes set ClothesName=@ClothesName ,color=@color ,brand=@brand ,fk_categoryId=@fk_categoryId,fk_WeatherID=@fk_WeatherID,Fk_OccasionID=@Fk_OccasionID,Fk_UserID=@Fk_UserID where ID=@id";

			var parameters = new SqlParameterBuilder()
				.AddInt("@id", model.ID)
				.AddInt("@fk_categoryId", model.Fk_CategoryID)
				.AddInt("@fk_WeatherID", model.Fk_WeatherID)
				.AddInt("@Fk_OccasionID", model.Fk_OccasionID)
                .AddInt("@Fk_UserID", model.Fk_UserID)
                .AddNVarchar("@ClothesName", 50, model.ClothesName)
				.AddNVarchar("@color", 50, model.Color)
				.AddNVarchar("@brand", 50, model.Brand)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
		public void Delete(int id)
		{
			string sql = "delete clothes where ID=@id";

			var parameters = new SqlParameterBuilder()
				.AddInt("@id", id)
				.Build();
			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Create(ClothesDTO model)
		{
			string sql = "INSERT INTO clothes(ClothesName,Brand,color,Fk_CategoryID,Fk_WeatherID,fk_OccasionId,fk_UserID) values(@ClothesName,@Brand,@color,@Fk_CategoryID,@Fk_WeatherID,@fk_OccasionId,@fk_UserId)";
			var parameters = new SqlParameterBuilder()
				.AddInt("@Fk_CategoryID", model.Fk_CategoryID)
				.AddInt("@Fk_WeatherID", model.Fk_WeatherID)
				.AddInt("@fk_OccasionId", model.Fk_OccasionID)
				.AddInt("@fk_UserId",model.Fk_UserID)
				.AddNVarchar("@ClothesName", 50, model.ClothesName)
				.AddNVarchar("@Brand", 50, model.Brand)
				.AddNVarchar("@color", 50, model.Color)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
        public IEnumerable<ClothesDTO> GetData(string weatherValue, string occasionValue, int fk_userId,string category) 
        {
            string sql = $@"SELECT * FROM Clothes join categories on clothes.fk_CategoryId=categories.id 
							Where Fk_UserID={fk_userId} and categoryName='{category}' and
							Fk_OccasionID in (select id from occasions where {occasionValue}=1) and 
							Fk_WeatherID in (select id from weather where {weatherValue}=1)
							";

            var dbHelper = new SqlDbHelper("default");
            return dbHelper.Select(sql, null)
                .AsEnumerable()
                .Select(row => new ClothesDTO
                {
                    ID = row.Field<int>("ID"),
                    ClothesName = row.Field<string>("ClothesName"),
                    Brand = row.Field<string>("Brand"),
                    Color = row.Field<string>("Color"),
                    Fk_CategoryID = row.Field<int>("Fk_CategoryID"),
                    Fk_UserID = row.Field<int>("Fk_UserID"),
                    Fk_OccasionID = row.Field<int>("Fk_OccasionID"),
                    Fk_WeatherID = row.Field<int>("Fk_WeatherID"),
                    CategoryName = row.Field<string>("CategoryName"),
                });

        }



    }
}
