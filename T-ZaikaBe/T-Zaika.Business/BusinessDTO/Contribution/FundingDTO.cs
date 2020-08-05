using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Contribution
{
    public class FundingDTO
    {
        public long FundingId { get; set; }
        public float? Amount { get; set; }
        public string Helper { get; set; }
        public DateTime FoundingDate { get; set; }
    }
}
