using projetErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetErov.Core.IRepository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        int GetIndexId(int id);
        bool Add(T t);
        bool Update(int index, T t);
        bool Delete(int index);
    }

}

