using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T_Zaika.Business.BusinessDTO.Security;
using T_Zaika.Business.BusinessModels.User;
using T_Zaika.Business.Operations;
using T_Zaika.Domain.Entities;

namespace T_Zaika.Business.Service.User
{
    public class UserLoginService : IUserLoginService
    {

        private IOperations<T_USER> user;
        private IOperations<T_USER_ROLES> userRole;
        private IOperations<T_ROLES> role;

        public UserLoginService(
            IOperations<T_USER> _user,
            IOperations<T_USER_ROLES> _userRole,
            IOperations<T_ROLES> _role
            )
        {
            this.user = _user;
            this.userRole = _userRole;
            this.role = _role;
        }
        public UserSessionDetails Authenticate(UserLoginModel userLogin)
        {
            long userId = 0;

            try
            {
                userId = this.user.FindAll(usr => usr.USER_NAME.ToLower().Equals(userLogin.UserName.ToLower()) && usr.USER_PASSWORD.Equals(userLogin.Password)).SingleOrDefault().Id;


            }
            catch (Exception ex)
            {

            }
            return GenerateUserDetails(userId);
        }

        private UserSessionDetails GenerateUserDetails(long userId)
        {
            try
            {
                var userDetails = (
            from user in this.user.FindAll(usr => usr.Id == userId)
            join userrole in this.userRole.FindAll() on user.Id equals userrole.Id
            select new UserSessionDetails()
            {
                UserId = user.Id,
                UserName = user.USER_NAME,
                RoleId = userrole.Id,
                RoleName = (from securityRole in this.role.FindAll(rs => rs.Id == userrole.ROLE_ID) select securityRole.ROLE_NAME ).FirstOrDefault()
            }).ToList(); 

            var userSessionDetail = userDetails?.FirstOrDefault();
            return userSessionDetail;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
