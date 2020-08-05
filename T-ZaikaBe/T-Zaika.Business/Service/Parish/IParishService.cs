using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Parish;

namespace T_Zaika.Business.Service.Parish
{
    public interface IParishService
    {
        IEnumerable<ParishDTO> GetAllParishs();
        ParishDTO GetParish(long id);
        void InsertParish(ParishDTO parishdto);
        void UpdateParish(ParishDTO parishdto);
        void DeleteParish(long id);
    }
}
