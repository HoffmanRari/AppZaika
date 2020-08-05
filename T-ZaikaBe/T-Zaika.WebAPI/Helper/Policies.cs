using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T_Zaika.Utilities.Enums;

namespace T_Zaika.WebAPI.Helper
{
    public class Policies
    {
        
        public static AuthorizationPolicy AdminPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(UserRoleEnum.Admin.ToString()).Build();
        }

        public static AuthorizationPolicy SupervisorPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(UserRoleEnum.Supervisor.ToString()).Build();
        }
        public static AuthorizationPolicy UserPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(UserRoleEnum.User.ToString()).Build();
        }
    }
}
