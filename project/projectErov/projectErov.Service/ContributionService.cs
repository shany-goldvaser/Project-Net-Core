
using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using projectErov.Core.IService;

namespace projectErov.Service
{
    public class ContributionService : IContributeService
    {
        readonly IRepository<ContributionsEntity> _repContribute;

        public ContributionService(IRepository<ContributionsEntity> repContribute)
        {
            _repContribute = repContribute;
        }

        public bool AddContributions(ContributionsEntity contribute)
        {
            if(GetContributionsById(contribute.NumInvoice) == null)
                return _repContribute.ToAdd(contribute);
            return false;
        }

        public bool DeleteContributions(int id)
        {
            if (GetContributionsById(id) == null)
                return false;
            return _repContribute.ToDelete(id);
        }

        public List<ContributionsEntity> GetAllContributions()
        {
            return _repContribute.ToGetAll();
        }

        public ContributionsEntity GetContributionsById(int id)
        {
            return _repContribute.ToGetById(id);
        }


        public bool UpdateContributions(int id, ContributionsEntity contribute)
        {
            if (GetContributionsById(id) != null)
                return _repContribute.ToUpdate(id,contribute);
            return AddContributions(contribute);
        }
    }
}
