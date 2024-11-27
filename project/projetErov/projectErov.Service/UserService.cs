using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using projetErov.Core.IService;
using System;
using System.Collections.Generic;
using System.Linq;

namespace projectErov.Service
{
    public class UserService : IUserService
    {
        readonly IRepository<UserEntity> _repUser;

        public UserService(IRepository<UserEntity> repUser)
        {
            _repUser = repUser;
        }
        public bool IsValidIsraelId(string id)
        {
            id = id.Trim();
            if (id.Length > 9 || !int.TryParse(id, out _))
                return false;
            id = id.Length < 9 ? ("00000000" + id).Substring(id.Length) : id;
            return id.Select(c => int.Parse(c.ToString()))
                     .Select((digit, i) => digit * (i % 2 + 1))
                     .Sum(step => step > 9 ? step - 9 : step) % 10 == 0;
        }
        public bool IsValidEmail(string email)
        {
            int i = email.LastIndexOf('@');
            int j = email.LastIndexOf('.');
            return i != -1 && j != -1 && i < j;
        }
        public bool AddUser(UserEntity user)
        {
            if (GetUserByIdIndex(user.Id) <0 && IsValidEmail(user.Email) && IsValidIsraelId(user.Tz))
                return _repUser.Add(user);
            return false;

        }

        public bool DeleteUser(int id)
        {
            int i = GetUserByIdIndex(id);
            if (i >= 0)
              return  _repUser.Delete(i);
            return false;
        }

        public List<UserEntity> GetAllUser()
        {
           return _repUser.GetAll();
        }

        public UserEntity GetUserById(int id)
        {
            return _repUser.GetById(id);
        }

        public int GetUserByIdIndex(int id)
        {
            return _repUser.GetIndexId(id);
        }

        public bool UpdateUser(int id, UserEntity user)
        {
            int i = GetUserByIdIndex(id);
            if (i >= 0 && IsValidEmail(user.Email) && IsValidIsraelId(user.Tz))
                return _repUser.Update(i, user);                
            return false;
        }
    }
}
