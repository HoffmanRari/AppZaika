
using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.User;
using T_Zaika.Business.Operations;
using T_Zaika.Domain.Entities;

namespace T_Zaika.Business.Service.User
{
    public class UserService: IUserService
    {
        private IOperations<T_USER> user;

        public UserService(IOperations<T_USER> _user)
        {
            this.user = _user;
        }
        public void DeleteUser(long id)
        {
            throw new NotImplementedException();
        }

        public UserDTO GetUser(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void InsertUser(UserDTO Userdto)
        {
            T_USER tUser = new T_USER
            {
              
            };
            this.user.AddOrUpdate(tUser);
        }

        public void UpdateUser(UserDTO userdto)
        {
            T_USER tUser = new T_USER
            {
                
            };
            this.user.AddOrUpdate(tUser);
        }
    }
}
