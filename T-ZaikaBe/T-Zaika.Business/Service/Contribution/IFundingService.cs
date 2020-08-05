using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Contribution;

namespace T_Zaika.Business.Service.Contribution
{
    public interface IFundingService
    {
        IEnumerable<FundingDTO> GetAllFundings();
        FundingDTO GetFunding(long id);
        void InsertFunding(FundingDTO fundingDto);
        void UpdateFunding(FundingDTO fundingDto);
        void DeleteFunding(long id);
    }
}
