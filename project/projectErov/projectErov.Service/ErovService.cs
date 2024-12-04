
using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using projectErov.Core.IService;
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
            if (GetErovById(erov.Id)==null)
                return _repErov.ToAdd(erov);
            return false;
        }

        public bool DeleteErov(int id)
        {
			if (GetErovById(id) != null)
				return _repErov.ToDelete(id);
            return false;
        }

        public List<ErovEntity> GetAllErov()
        {
           return _repErov.ToGetAll();
        }

        public ErovEntity GetErovById(int id)
        {
            return _repErov.ToGetById(id);
        }
        public bool UpdateErov(int id, ErovEntity erov)
        {
			if (GetErovById(id) != null)
				return _repErov.ToUpdate(id,erov);
			return AddErov(erov);
        }
    }
}
