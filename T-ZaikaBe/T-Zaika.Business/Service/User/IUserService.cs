using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.User;

namespace T_Zaika.Business.Service.User
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetUsers();
        UserDTO GetUser(long id);
        void InsertUser(UserDTO Userdto);
        void UpdateUser(UserDTO userdto);
        void DeleteUser(long id);
    }
}
