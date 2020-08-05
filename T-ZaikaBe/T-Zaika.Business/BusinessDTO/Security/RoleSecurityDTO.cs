using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Security
{
    public class RoleSecurityDTO
    {
        public long RoleSecurityId { get; set; }
        public DateTime AssignationDate { get; set; }
        public long? SecurityId { get; set; }
        public long? RoleId { get; set; }
    }
}
