using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Lodgement
{
    public class LodgementDTO
    {
        public long LodgementId { get; set; }
        public string LodgementName { get; set; }
        public int PlaceNumber { get; set; }
        public int LodgementCapacity { get; set; }
    }
}
