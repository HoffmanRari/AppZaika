using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Programme
{
    public class UserProgrammeDTO
    {
        public long UserProgrammeId { get; set; }
        public DateTime Date { get; set; }
        public long? MemberId { get; set; }

        public long? ProgrammeId { get; set; }
    }
}
