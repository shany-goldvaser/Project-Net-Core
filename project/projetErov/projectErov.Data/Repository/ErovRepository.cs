using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projectErov.Data.Repository
{
    public class ErovRepository :IRepository<ErovEntity>
    {
        readonly DataContext _dataContext;

        public ErovRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool Add(ErovEntity t)
        {
            try
            {
                _dataContext.ErovList.Add(t);
                _dataContext.SaveChanges();
                return true;
            }  
            catch(Exception)
            {
                return false;
            }
        }

        public bool Delete(int index)
        {
            try
            {
                _dataContext.ErovList.RemoveAt(index);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ErovEntity> GetAll()
        {
            return _dataContext.ErovList;
        }

        public ErovEntity GetById(int id)
        {
            return _dataContext.ErovList.FirstOrDefault(t => t.Id == id);
        }

        public int GetIndexId(int id)
        {
            return _dataContext.ErovList.FindIndex(t => t.Id == id);
    
        }

        public bool Update(int index, ErovEntity t)
        {
            try
            {
                _dataContext.ErovList[index] = t;
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
