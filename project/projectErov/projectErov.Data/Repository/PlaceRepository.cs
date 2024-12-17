using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Data.Repository
{
    public class PlaceRepository : IRepository<PlaceEntity>
    {
        readonly DataContext _dataContext;

        public PlaceRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool ToAdd(PlaceEntity t)
        {
            try
            {
                _dataContext.PlaceList.Add(t);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ToDelete(int id)
        {
            try
            {
                PlaceEntity p = _dataContext.PlaceList.FirstOrDefault(t => t.Id == id);
                if (p == null)
                    return false;
                _dataContext.PlaceList.Remove(p);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PlaceEntity> ToGetAll()
        {
            return _dataContext.PlaceList.ToList();
        }

        public PlaceEntity ToGetById(int id)
        {
            return _dataContext.PlaceList.FirstOrDefault(t=>t.Id==id);
        }

        public bool ToUpdate(int id, PlaceEntity t)
        {
            try
            {
				PlaceEntity p = _dataContext.PlaceList.FirstOrDefault(t => t.Id == id);
                if (p == null)
					return false;
                p.Area = t.Area == 0 ? p.Area : t.Area;
                p.Name = t.Name == 0 ? p.Name : t.Name;
                p.Type = t.Type == 0 ? p.Type : t.Type;
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
