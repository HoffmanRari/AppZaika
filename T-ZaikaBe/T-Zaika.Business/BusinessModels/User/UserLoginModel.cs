using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace T_Zaika.Business.BusinessModels.User
{
    public class UserLoginModel
    {
        [Required(ErrorMessage = "Enter UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Password")]
        public string Password { get; set; }
        public string Token { get; set; }
        public long Usertype { get; set; }
    }
}
