using Closet.Infra.DAOs;
using Closet.Models.DTOs;
using Closet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.Service
{
    public class UserService

    {
        private UserDAO _dao;
        public UserService()
        {
            _dao = new UserDAO();
        }
        public bool Authenticate(SignInVM model,out UserDTO registrand)
        {
            UserDTO user = _dao.Get(model.Account); //找到使用者輸入的帳號，回傳對應的一整筆資料(ID,Account,Password,UserName)
            registrand= new UserDAO().Get(model.Account);
            if (user == null) return false; // 找不到符合的帳號

            return (user.Password == model.Password);
        }

        internal void Create(UserDTO model)
        {
            bool isExists = _dao.AccountExists(model.Account);
            if (isExists) throw new Exception("已經有人使用此帳號");

            new UserDAO().Create(model);
        }
        internal void Update(UserDTO model)
        {
            //bool isExists = _dao.AccountExists(model.Account);
            //if (isExists) throw new Exception("已經有人使用此帳號");

            new UserDAO().Update(model);
        }
    }
}
