using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessModels.User;

namespace T_Zaika.Business.Service.User
{
    public interface IUserLoginService
    {
        UserSessionDetails Authenticate(UserLoginModel userLogin);
    }
}
