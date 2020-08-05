using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.User;

namespace T_Zaika.Business.Service.User
{
    public interface IUserRoleService
    {
        IEnumerable<UserRoleDTO> GetUserRoles();
        UserRoleDTO GetUserRole(long id);
        void InsertUserRole(UserRoleDTO UserRoleDto);
        void UpdateUserRole(UserRoleDTO userRoleDto);
        void DeleteUserRole(long id);
    }
}
