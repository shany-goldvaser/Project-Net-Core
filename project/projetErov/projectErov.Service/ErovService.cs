using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using projetErov.Core.IService;
using System.Collections.Generic;
namespace projectErov.Service
{
    public class ErovService : IErovService
    {
        readonly IRepository<ErovEntity> _repErov;

        public ErovService(IRepository<ErovEntity> repErov)
        {
            _repErov = repErov;
        }

        public bool AddErov(ErovEntity erov)
        {
            if (GetErovByIdIndex(erov.Id) < 0)
                return _repErov.Add(erov);
            return false;
        }

        public bool DeleteErov(int id)
        {
            int i = GetErovByIdIndex(id);
                if (i >= 0)
                return _repErov.Delete(i);
            return false;
        }

        public List<ErovEntity> GetAllErov()
        {
           return _repErov.GetAll();
        }

        public ErovEntity GetErovById(int id)
        {
            return _repErov.GetById(id);
        }

        public int GetErovByIdIndex(int id)
        {
          return _repErov.GetIndexId(id);
        }

        public bool UpdateErov(int id, ErovEntity erov)
        {
            int i = GetErovByIdIndex(id);
            if (i >= 0)
                return _repErov.Update(i, erov);
            return _repErov.Add(erov);
        }
    }
}
