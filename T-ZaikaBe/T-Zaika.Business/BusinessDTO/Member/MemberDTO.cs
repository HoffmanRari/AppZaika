using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Member
{
    public class MemberDTO
    {
        public long MemberId { get; set; }
        public string FisrtName { set; get; }
        public string LastName { set; get; }
	public string Gender {get; set;}
        public string PhoneNumber { set; get; }
        public DateTime CreationDate { set; get; }
        public long? ParishId { get; set; }
        public long? GroupId { get; set; }
        public long? ResponsabilityId { get; set; }
    }
}
