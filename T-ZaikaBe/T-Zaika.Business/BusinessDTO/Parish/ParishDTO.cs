using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Parish
{
    public class ParishDTO
    {
        public long ParushId { get; set; }
        public string ParishName { set; get; }
        public long? DistrictId { get; set; }
    }
}
