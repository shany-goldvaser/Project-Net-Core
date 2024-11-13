using Microsoft.Extensions.Logging;
using Project_Erov.Dto;
using Project_Erov.Entities;
using System;

namespace Project_Erov.Services
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            if (DataContextManager.DataContext.UsersList == null)
            {
                DataContextManager.DataContext.UsersList = new List<User>();
            }
            return DataContextManager.DataContext.UsersList;
        }
        public User GetUsersId(int id)
        {
            if (DataContextManager.DataContext.UsersList == null)
            {
                return null;
            }
            return DataContextManager.DataContext.UsersList.Find(e => e.Id == id);

        }
        public bool AddUsers(User e)
        {
            if (DataContextManager.DataContext.UsersList == null)
            {
                DataContextManager.DataContext.UsersList = new List<User>();
            }
            if (!IsIsraeliIdNumber(e.Tz))
                return false;
            if (!IsValidEmail(e.Email))
                return false;
            DataContextManager.DataContext.UsersList.Add(e);
            return true;
        }
        public bool UpdateUsers(int id, User e)
        {
            var index = DataContextManager.DataContext.UsersList.FindIndex(ev => ev.Id == id);
            if (DataContextManager.DataContext.UsersList == null)
                return false;
            if (index != -1)
            {
                if (DataContextManager.DataContext.UsersList[index].Email != e.Tz)
                {
                    if (!IsIsraeliIdNumber(e.Tz))
                        return false;
                }
                if (DataContextManager.DataContext.UsersList[index].Email != e.Email)
                {
                    if (!IsIsraeliIdNumber(e.Email))
                        return false;
                }
                DataContextManager.DataContext.UsersList[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteUsers(int id)
        {
            if (DataContextManager.DataContext.UsersList == null)
            {
                return false;
            }
            var item = DataContextManager.DataContext.UsersList.Find(ev => ev.Id == id);
            if (item != null)
            {
                DataContextManager.DataContext.UsersList.Remove(item);
                return true;
            }
            return false;
        }
        public bool IsIsraeliIdNumber(string id)
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

    }
}
