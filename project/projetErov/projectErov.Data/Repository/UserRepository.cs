using projetErov.Core.Entities;
using projetErov.Core.IRepository;
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

        public bool Add(UserEntity t)
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

        public bool Delete(int index)
        {
            try
            {
                _dataContext.UsersList.RemoveAt(index);
                _dataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<UserEntity> GetAll()
        {
            return _dataContext.UsersList;
        }

        public UserEntity GetById(int id)
        {
            return _dataContext.UsersList.FirstOrDefault(t=>t.Id==id);
        }

        public int GetIndexId(int id)
        {
           return _dataContext.UsersList.FindIndex(t => t.Id == id);


        }

        public bool Update(int index, UserEntity t)
        {
            try
            {
                _dataContext.UsersList[index]=t;
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
