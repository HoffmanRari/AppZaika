using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Programme;

namespace T_Zaika.Business.Service.Programme
{
    public interface IProgrammeService
    {
        IEnumerable<ProgrammeDTO> GetAllProgrammes();
        ProgrammeDTO GetProgramme(long id);
        void InsertProgramme(ProgrammeDTO programmedto);
        void UpdateProgramme(ProgrammeDTO programmedto);
        void DeleteProgramme(long id);
    }
}
