using projectErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.IService
{
    public interface IPlaceService
    {
        List<PlaceEntity> GetAllPlace();
        PlaceEntity GetPlaceById(int id);
        bool AddPlace(PlaceEntity place);
        bool UpdatePlace(int id, PlaceEntity place);
        bool DeletePlace(int id);
    }
}
