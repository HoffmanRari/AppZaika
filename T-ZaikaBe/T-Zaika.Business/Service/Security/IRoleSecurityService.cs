using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Security;

namespace T_Zaika.Business.Service.Security
{
    public interface IRoleSecurityService
    {
        void DeleteRoleSecurity(long id);

        IEnumerable<RoleSecurityDTO> GetAllRoleSecurities();

        RoleSecurityDTO GetRoleSecurity(long id);

        void InsertRoleSecurity(RoleSecurityDTO roleSecuritydto);

        void UpdateRoleSecurity(RoleSecurityDTO roleSecuritydto);
    }
}
