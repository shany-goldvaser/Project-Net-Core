﻿using projetErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetErov.Core.IService
{
    public interface IUserService
    {
        List<UserEntity> GetAllUser();
        UserEntity GetUserById(int id);
        int GetUserByIdIndex(int id);
        bool AddUser(UserEntity user);
        bool UpdateUser(int id, UserEntity user);
        bool DeleteUser(int id);
    }
}
