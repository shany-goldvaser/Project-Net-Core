using projectErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectErov.Core.IService
{
    public interface IContributeService
    {
        List<ContributionsEntity> GetAllContributions();
        ContributionsEntity GetContributionsById(int id);
        bool AddContributions(ContributionsEntity contribute);
        bool UpdateContributions(int id, ContributionsEntity contribute);
        bool DeleteContributions(int id);
    }
}
