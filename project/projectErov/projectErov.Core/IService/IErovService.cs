using projectErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projectErov.Core.IService
{
    public interface IErovService
    {
        List<ErovEntity> GetAllErov();
        ErovEntity GetErovById(int id);
        bool AddErov(ErovEntity erov);
        bool UpdateErov(int id, ErovEntity erov);
        bool DeleteErov(int id);

    }
}
