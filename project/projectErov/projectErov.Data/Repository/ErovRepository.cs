﻿using Microsoft.IdentityModel.Tokens;
using projectErov.Core.Entities;
using projectErov.Core.IRepository;
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

        public bool ToAdd(ErovEntity t)
        {
			try
			{
				_dataContext.ErovList.Add(t);
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
				ErovEntity t = _dataContext.ErovList.Find(id);
				if (t == null)
					return false;
				_dataContext.ErovList.Remove(t);
				_dataContext.SaveChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

        public List<ErovEntity> ToGetAll()
        {
            return _dataContext.ErovList.ToList();
        }

        public ErovEntity ToGetById(int id)
        {
			return _dataContext.ErovList.FirstOrDefault(t => t.Id == id);
		}

		public bool ToUpdate(int id, ErovEntity c)
        {
			try
			{
				ErovEntity t = _dataContext.ErovList.Find(id);
				if (t== null)
					return false;
				t.Status = c.Status!=t.Status? c.Status : t.Status;//what to do with bool
				t.YardErov = c.YardErov != t.YardErov ? c.YardErov : t.YardErov;
				t.BorderErov = c.BorderErov.IsNullOrEmpty() ? t.BorderErov : c.BorderErov;
				t.IdRav = c.IdRav==0 ? t.IdRav : c.IdRav;
				t.Message = c.Message.IsNullOrEmpty() ? t.Message : c.Message;

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}




    }
}