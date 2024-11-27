using projetErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetErov.Core.IService
{
    public interface IPlaceService
    {
        List<PlaceEntity> GetAllPlace();
        PlaceEntity GetPlaceById(int id);
        int GetPlaceByIdIndex(int id);
        bool AddPlace(PlaceEntity place);
        bool UpdatePlace(int id, PlaceEntity place);
        bool DeletePlace(int id);
    }
}
