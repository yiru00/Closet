using Closet.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.ViewModels
{
    public class UserVM
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "帳號必填")]
		[StringLength(20, ErrorMessage = "不可大於20個字")]
		public string Account { get; set; }


        [Required(ErrorMessage = "密碼必填")]
		[StringLength(20, ErrorMessage = "不可大於20個字")]

		public string Password { get; set; }


        [Required(ErrorMessage = "姓名必填")]
        [StringLength(10, ErrorMessage = "不可大於10個字")]
        public string UserName { get; set; }
    }
    public static class UserDTOExts
    {
        public static UserVM ToVM(this UserDTO dto)
        {
            return new UserVM
            {
                ID = dto.ID,
                Account = dto.Account,
                Password = dto.Password,
                UserName = dto.UserName,
            };
        }

        //public static UserIndexVM ToIndexVM(this UserDTO dto)
        //{
        //    return new UserIndexVM
        //    {
        //        Id = dto.Id,
        //        Account = dto.Account,
        //        // Password = dto.Password,
        //        Name = dto.Name,
        //    };
        //}
    }
}
