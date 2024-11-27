using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projectErov.Data.Repository
{
    public class ContributionsRepository : IRepository<ContributionsEntity>
    {
        readonly DataContext _dataContext;
        public ContributionsRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool Add(ContributionsEntity t)
        {   
            try
            {
                _dataContext.ContributionsList.Add(t);
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
                _dataContext.ContributionsList.RemoveAt(index);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<ContributionsEntity> GetAll()
        {
            return _dataContext.ContributionsList;
        }
        public ContributionsEntity GetById(int id)
        {
            return _dataContext.ContributionsList.FirstOrDefault(t => t.Id == id);
        }

        public int GetIndexId(int id)
        {
            return _dataContext.ContributionsList.FindIndex(t => t.Id == id);
  
        }

        public bool Update(int index, ContributionsEntity t)
        {
            try
            {
                _dataContext.ContributionsList[index] = t;
                _dataContext.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
