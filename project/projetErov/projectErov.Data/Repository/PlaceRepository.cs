using projetErov.Core.Entities;
using projetErov.Core.IRepository;
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

        public bool Add(PlaceEntity t)
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

        public bool Delete(int index)
        {
            try
            {
                _dataContext.PlaceList.RemoveAt(index);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PlaceEntity> GetAll()
        {
            return _dataContext.PlaceList;
        }

        public PlaceEntity GetById(int id)
        {
            return _dataContext.PlaceList.FirstOrDefault(t=>t.Id==id);
        }

        public int GetIndexId(int id)
        {
           return _dataContext.PlaceList.FindIndex(t => t.Id == id);
        }

        public bool Update(int index, PlaceEntity t)
        {
            try
            {
                _dataContext.PlaceList[index]=t;
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
