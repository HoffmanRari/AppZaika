using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.User
{
    public class UserDTO
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }

        public string email { get; set; }
        public string Password { get; set; }
        public DateTime UserCreationDate { set; get; }
        public DateTime? UserUpdateDate { set; get; }
        public Boolean Status { get; set; }
    }
}
