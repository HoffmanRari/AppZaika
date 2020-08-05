using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Programme
{
    public class ProgrammeDTO
    {

        public long ProgrammeId { get; set; }
        public string ProgrammeName { set; get; }
        public DateTime ProgrammeDate { set; get; }
        public string StartTime { set; get; }
        public string EndTime { set; get; }
        public string Duration { set; get; }
    }
}
