using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using projetErov.Core.IService;
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
            if (GetPlaceByIdIndex(place.Id) >= 0)
                return false;
            return _repPlace.Add(place);
        }

        public bool DeletePlace(int id)
        {
            int i = GetPlaceByIdIndex(id);
            if (i >= 0)
                return _repPlace.Delete(i);
            return false;
        }

        public List<PlaceEntity> GetAllPlace()
        {
           return _repPlace.GetAll();
        }

        public PlaceEntity GetPlaceById(int id)
        {
            return _repPlace.GetById(id);
        }

        public int GetPlaceByIdIndex(int id)
        {
            return _repPlace.GetIndexId(id);
        }

        public bool UpdatePlace(int id, PlaceEntity place)
        {
            int i = GetPlaceByIdIndex(id);
            if (i >= 0)
                return _repPlace.Update(i,place);
            return false;
        }
    }
}
