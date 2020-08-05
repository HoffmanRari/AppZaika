using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Security;

namespace T_Zaika.Business.Service.Security
{
    public interface ISecurityService
    {
        IEnumerable<SecurityDTO> GetAllSecurities();
        SecurityDTO GetSecurity(long id);
        void InsertSecurity(SecurityDTO securitydto);
        void UpdateSecurity(SecurityDTO securitydto);
        void DeleteSecurity(long id);
    }
}
