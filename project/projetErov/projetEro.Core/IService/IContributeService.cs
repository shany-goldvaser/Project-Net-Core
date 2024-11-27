using projetErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetErov.Core.IService
{
    public interface IContributeService
    {
        List<ContributionsEntity> GetAllContributions();
        ContributionsEntity GetContributionsById(int id);
        int GetContributionsByIdIndex(int id);
        bool AddContributions(ContributionsEntity contribute);
        bool UpdateContributions(int id, ContributionsEntity contribute);
        bool DeleteContributions(int id);
    }
}
