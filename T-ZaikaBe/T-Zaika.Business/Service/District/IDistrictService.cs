using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.District;

namespace T_Zaika.Business.Service.District
{
    public interface IDistrictService
    {
        IEnumerable<DistrictDTO> GetAllDistricts();
        DistrictDTO GetDistrict(long id);
        void InsertDistrict(DistrictDTO districtdto);
        void UpdateDistrict(DistrictDTO districtdto);
        void DeleteDistrict(long id);
    }
}
