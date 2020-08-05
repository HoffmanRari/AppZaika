using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Lodgement;

namespace T_Zaika.Business.Service.Lodgement
{
    public  interface ILodgementService
    {
        IEnumerable<LodgementDTO> GetAllLodgements();
        LodgementDTO GetLodgement(long id);
        void InsertLodgement(LodgementDTO lodgementdto);
        void UpdateLodgement(LodgementDTO lodgementdto);
        void DeleteLodgement(long id);
    }
}
