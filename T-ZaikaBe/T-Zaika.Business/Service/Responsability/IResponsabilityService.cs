using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Responsability;

namespace T_Zaika.Business.Service.Responsability
{
    public interface IResponsabilityService
    {
        IEnumerable<ResponsabilityDTO> GetAllResponsabilities();
        ResponsabilityDTO GetResponsability(long id);
        void InsertResponsability(ResponsabilityDTO responsabilityDTO);
        void UpdateResponsability(ResponsabilityDTO responsabilityDTO);
        void DeleteResponsability(long id);
    }
}
