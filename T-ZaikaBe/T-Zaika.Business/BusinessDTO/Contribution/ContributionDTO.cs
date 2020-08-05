using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Contribution
{
    public class ContributionDTO
    {
        public long ContributionId { get; set; }
        public float AmountPaid { get; set; }
        public float RemainingAmount { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime Date { get; set; }

        public long? MemberId { get; set; }
        public long? ContributionTypeId { get; set; }
    }
}
