using Microsoft.IdentityModel.Tokens;
using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
namespace projectErov.Data.Repository
{
    public class UserRepository : IRepository<UserEntity>
    {
        readonly DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool ToAdd(UserEntity t)
        {
            try
            {
                _dataContext.UsersList.Add(t);
                _dataContext.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool ToDelete(int id)
        {
            try
            {
                UserEntity u = _dataContext.UsersList.FirstOrDefault(e=>e.Id==id);
                if (u == null)
                    return false;
                _dataContext.UsersList.Remove(u);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<UserEntity> ToGetAll()
        {
            return _dataContext.UsersList.ToList();
        }

        public UserEntity ToGetById(int id)
        {
            return _dataContext.UsersList.FirstOrDefault(t=>t.Id==id);
        }
        public bool ToUpdate(int id, UserEntity t)
        {
            try
            {
                UserEntity u = _dataContext.UsersList.FirstOrDefault(e => e.Id == id);
                if (u == null)
                    return false;
                u.FullName = t.FullName.IsNullOrEmpty() ? u.FullName : t.FullName;
                u.Adress = t.Adress.IsNullOrEmpty() ? u.Adress : t.Adress;
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
