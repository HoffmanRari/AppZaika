using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Contribution;

namespace T_Zaika.Business.Service.Contribution
{
    public interface IContributionService
    {
        IEnumerable<ContributionDTO> GetAllContributions();
        ContributionDTO GetContribution(long id);
        void InsertContribution(ContributionDTO contributionDto);
        void UpdateContribution(ContributionDTO contributionDto);
        void DeleteContribution(long id);
    }
}
