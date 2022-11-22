using Closet.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closet.Models.DTOs
{
    public class UserDTO
    {
        public int ID { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }


        public string UserName{ get; set; }
    }
    public static class UserVMExts
    {
        public static UserDTO ToDTO(this UserVM vm)
        {
            return new UserDTO
            {
                ID = vm.ID,
                Account = vm.Account,
                Password = vm.Password,
                UserName = vm.UserName
            };
        }
    }
}
