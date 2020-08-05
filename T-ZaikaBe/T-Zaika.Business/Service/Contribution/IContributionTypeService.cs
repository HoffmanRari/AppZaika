using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Contribution;

namespace T_Zaika.Business.Service.Contribution
{
    public interface IContributionTypeService
    {
        IEnumerable<ContributionTypeDTO> GetAllContributionTypes();
        ContributionTypeDTO GetContributionType(long id);
        void InsertContributionType(ContributionTypeDTO contributionTypeDto);
        void UpdateContributionType(ContributionTypeDTO contributionTypeDto);
        void DeleteContributionType(long id);
    }
}
