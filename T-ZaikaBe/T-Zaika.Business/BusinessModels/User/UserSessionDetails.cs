using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Security;

namespace T_Zaika.Business.BusinessModels.User
{
    public class UserSessionDetails
    {
        public long UserId { get; set; }
        public String UserName { get; set; }
        public long RoleId { get; set; }
        public String RoleName { get; set; }

    }
}
