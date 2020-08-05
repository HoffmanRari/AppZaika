using System;
using System.Collections.Generic;
using System.Text;

namespace T_Zaika.Business.BusinessDTO.Lodgement
{
    public class PlaceDTO
    {
        public long PlaceId { get; set; }
        public DateTime AssignationDate { get; set; }

        public long? MemberId { get; set; }

        public long? LodgementId { get; set; }
    }
}
