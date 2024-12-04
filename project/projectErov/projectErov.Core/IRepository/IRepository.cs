using projectErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.IRepository
{
    public interface IRepository<T>
    {
        List<T> ToGetAll();
        T ToGetById(int id);
        bool ToAdd(T t);
        bool ToUpdate(int id, T t);
        bool ToDelete(int id);
    }

}

