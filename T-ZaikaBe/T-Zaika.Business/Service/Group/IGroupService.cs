using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Group;

namespace T_Zaika.Business.Service.Group
{
    public interface IGroupService
    {
        IEnumerable<GroupDTO> GetAllGroups();
        GroupDTO GetGroup(long id);
        void InsertGroup(GroupDTO groupDto);
        void UpdateGroup(GroupDTO groupDto);
        void DeleteGroup(long id);
    }
}
