using Project_Erov.Dto;
using Project_Erov.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_Erov
{
    internal class TestContext : IDataContextContribution
    {
        List<Contributions> IDataContextContribution.LoadData()
        {
            List<Contributions> contributions = new List<Contributions>
            {
                new (1, 19.2, new DateTime(2024, 5, 5), "abc", "ad fasf"),
                new (2, 19.2, new DateTime(2024, 12, 1), "abc", "fdf fasf"),
                new (3, 19.2, new DateTime(2024, 5, 1), "dsf jb", "adggf")
            };
            return contributions;
        }

        bool IDataContextContribution.SaveData(List<Contributions> data)
        {
            return true;
        }
    }
}
