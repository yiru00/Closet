using Closet.Models.DTOs;
using ISpan.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Infra.DAOs
{
    public class UserDAO
    {
        public UserDTO Get(string account)
        {
            string sql = "SELECT * FROM Users WHERE Account=@Account";
            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Account", 50, account)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);

            if (data.Rows.Count == 0)
            {
                return null;
            }

            // 將找到的一筆記錄由DataTable 轉換到 UserDTO
            return ToUserDTO(data.Rows[0]);
        }
        private UserDTO ToUserDTO(DataRow row)
        {
            return new UserDTO
            {
                ID = row.Field<int>("ID"),
                Account = row.Field<string>("Account"),
                Password = row.Field<string>("Password"),
                UserName = row.Field<string>("UserName"),
            };
        }

        public bool AccountExists(string account)
        {
            string sql = @"SELECT Count(*) as count FROM Users WHERE Account=@Account";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Account", 50, account)
                .Build();

            DataTable data = new SqlDbHelper("default").Select(sql, parameters);
            return data.Rows[0].Field<int>("count") > 0;
        }
        public void Create(UserDTO model)
        {
            string sql = @"INSERT INTO Users (Account,Password, UserName)
                            VALUES (@Account,@Password, @Name)";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("@Account", 50, model.Account)
                .AddNVarchar("@Password", 50, model.Password)
                .AddNVarchar("@Name", 50, model.UserName)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
        }
        public void Update(UserDTO model)
        {
            string sql = @"UPDATE Users
			SET Account=@Account, Password=@Password, UserName=@UserName
			WHERE Id=@Id";

            var parameters = new SqlParameterBuilder()
                .AddNVarchar("Account", 50, model.Account)
                .AddNVarchar("Password", 50, model.Password)
                .AddNVarchar("UserName", 50, model.UserName)
                .AddInt("Id", model.ID)
                .Build();

            new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

        }
    }
}
