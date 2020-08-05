using System;
using System.Collections.Generic;
using System.Text;
using T_Zaika.Business.BusinessDTO.Lodgement;

namespace T_Zaika.Business.Service.Lodgement
{
    public interface IPlaceService
    {
        IEnumerable<PlaceDTO> GetAllPlaces();
        PlaceDTO GetPlace(long id);
        void InsertPlace(PlaceDTO placeDto);
        void UpdatePlace(PlaceDTO placeDto);
        void DeletePlace(long id);
    }
}
