using projetErov.Core.Entities;
using projetErov.Core.IRepository;
using projetErov.Core.IService;
using System.Collections.Generic;
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
            if (GetContributionsByIdIndex(contribute.Id) < 0)
                return _repContribute.Add(contribute);
            return false;
        }

        public bool DeleteContributions(int id)
        {
            int i = GetContributionsByIdIndex(id);
            if (id >= 0)
               return _repContribute.Delete(i);
            return false;
        }

        public List<ContributionsEntity> GetAllContributions()
        {
            return _repContribute.GetAll();
        }

        public ContributionsEntity GetContributionsById(int id)
        {
            return _repContribute.GetById(id);
        }

        public int GetContributionsByIdIndex(int id)
        {
            return _repContribute.GetIndexId(id);
        }

        public bool UpdateContributions(int id, ContributionsEntity contribute)
        {
            int i = GetContributionsByIdIndex(id);
            if (id >= 0)
                return _repContribute.Update(i,contribute);
            return false;
        }
    }
}
