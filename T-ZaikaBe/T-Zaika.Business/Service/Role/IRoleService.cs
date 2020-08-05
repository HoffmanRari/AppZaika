using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Role;

namespace T_Zaika.Business.Service.Role
{
    public interface IRoleService
    {
        IEnumerable<RoleDTO> GetRoles();
        RoleDTO GetRole(long id);
        void InsertRole(RoleDTO roleDto);
        void UpdateRole(RoleDTO roleDto);
        void DeleteRole(long id);
    }
}
