using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using projectErov.Core.IService;
using System.Collections.Generic;


namespace projectErov.Service
{
    public class PlaceService : IPlaceService
    {
       readonly IRepository<PlaceEntity> _repPlace;

        public PlaceService(IRepository<PlaceEntity> repPlace)
        {
            _repPlace = repPlace;
        }

        public bool AddPlace(PlaceEntity place)
        {
            if (GetPlaceById(place.Id) !=null)
                return false;
            return _repPlace.ToAdd(place);
        }
        public bool DeletePlace(int id)
        {

            if (GetPlaceById(id)!=null)
                return _repPlace.ToDelete(id);
            return false;
        }

        public List<PlaceEntity> GetAllPlace()
        {
            return _repPlace.ToGetAll();
        }

        public PlaceEntity GetPlaceById(int id)
        {
            return _repPlace.ToGetById(id);
        }

        public bool UpdatePlace(int id, PlaceEntity place)
        {
            
            if (GetPlaceById(id)!=null)
                return _repPlace.ToUpdate(id, place);
            return AddPlace(place);
        }
    }
}
