using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.ExpenseManagement
{
    public class ExpenseManagementDTO
    {
        public long ExpenseManagementId { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public long? MemberID { get; set; }
    }
}
