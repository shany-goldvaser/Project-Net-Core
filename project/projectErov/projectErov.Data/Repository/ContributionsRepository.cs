using Microsoft.IdentityModel.Tokens;
using projectErov.Core.Entities;
using projectErov.Core.IRepository;
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

        public bool ToAdd(ContributionsEntity t)
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

		public bool ToDelete(int id)
        {
            try
            {
                ContributionsEntity t = _dataContext.ContributionsList.FirstOrDefault(t => t.NumInvoice == id);
                if (t == null)
                    return false;
                _dataContext.ContributionsList.Remove(t);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

		public List<ContributionsEntity> ToGetAll()
        {
			return _dataContext.ContributionsList.ToList();
		}

        public ContributionsEntity ToGetById(int id)
        {
		  return _dataContext.ContributionsList.FirstOrDefault(t => t.NumInvoice == id);
		}

		public bool ToUpdate(int id, ContributionsEntity t)
        {
            try
            {
                ContributionsEntity c = _dataContext.ContributionsList.FirstOrDefault(t => t.NumInvoice == id);
                if (c == null)
                    return false;
                c.NameForPraying = t.NameForPraying.IsNullOrEmpty() ? c.NameForPraying : t.NameForPraying;
                c.Sum = t.Sum==0 ? c.Sum : t.Sum;
                c.Date = t.Date == null ? c.Date : t.Date;//what to do with date
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
