using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.User
{
    public class UserRoleDTO
    {
        public long UserRoleId { get; set; }
        public long?  UserId { get; set; }
        public long? RoleId { get; set; }
    }
}
