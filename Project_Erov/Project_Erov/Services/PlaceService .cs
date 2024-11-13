using Project_Erov.Dto;
using Project_Erov.Entities;

namespace Project_Erov.Services
{
    public class PlaceService
    {

        public List<Place> GetPlace()
        {
            if (DataContextManager.DataContext.PlaceList == null)
                DataContextManager.DataContext.PlaceList = new List<Place>();
            return DataContextManager.DataContext.PlaceList;
        }
        public Place GetPlaceId(int id)
        {
            if (DataContextManager.DataContext.PlaceList == null)
                return null;
            return DataContextManager.DataContext.PlaceList.Find(e => e.Id == id);

        }
        public bool AddPlace(Place e)
        {
            if (DataContextManager.DataContext.PlaceList == null)
            {
                DataContextManager.DataContext.PlaceList = new List<Place>();

            }
            DataContextManager.DataContext.PlaceList.Add(e);
            return true;
        }
        public bool UpdatePlace(int id, Place e)
        {
            if (DataContextManager.DataContext.PlaceList == null)
            {
                return false;
            }
            var index = DataContextManager.DataContext.PlaceList.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                DataContextManager.DataContext.PlaceList[index] = e;
                return true;
            }
            return false;
        }
        public bool DeletePlace(int id)
        {
            if (DataContextManager.DataContext.PlaceList == null)
            {
                return false;
            }
            var item = DataContextManager.DataContext.PlaceList.Find(ev => ev.Id == id);
            if (item != null)
            {
                DataContextManager.DataContext.PlaceList.Remove(item);
                return true;
            }
            return false;
        }
    }
}

