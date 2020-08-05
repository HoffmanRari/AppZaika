using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Member;

namespace T_Zaika.Business.Service.Member
{
    public interface IMemberService
    {
        IEnumerable<MemberDTO> GetAllMembers();
        MemberDTO GetMember(long id);
        void InsertMember(MemberDTO lodgementdto);
        void UpdateMember(MemberDTO lodgementdto);
        void DeleteMember(long id);
    }
}
