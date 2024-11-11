using ShanyGoldvaserProject.Entities;
namespace ShanyGoldvaserProject.Service
{
    public class ContributionsService
    {
        public List<Contributions> GetContributions() 
        { 
            if(DataContextManager.DataContext.ContributionsList==null)
            {
                DataContextManager.DataContext.ContributionsList = new List<Contributions>();
            }
            return DataContextManager.DataContext.ContributionsList;
        } 
        public Contributions GetContributionsId(int id)
        {
            if (DataContextManager.DataContext.ContributionsList == null)
            {
                return null;
            }
            return DataContextManager.DataContext.ContributionsList.Find(e => e.Id == id);

        }
        public bool AddContributions(Contributions e)
        {
            if (DataContextManager.DataContext.ContributionsList == null)
                DataContextManager.DataContext.ContributionsList = new List<Contributions>();
            DataContextManager.DataContext.ContributionsList.Add(e);
            return true;
        }
        public bool UpdateContributions(int id, Contributions e)
        {
            if (DataContextManager.DataContext.ContributionsList == null)
                return false;
            var index = DataContextManager.DataContext.ContributionsList.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                DataContextManager.DataContext.ContributionsList[index] = e;
                return true;
            }
            return false;
        }
        public bool DeleteContributions(int id)
        {
            if (DataContextManager.DataContext.ContributionsList == null)
                return false;
            var item = DataContextManager.DataContext.ContributionsList.Find(ev => ev.Id == id);
            if (item != null)
            {
                DataContextManager.DataContext.ContributionsList.Remove(item);
                return true;
            }
            return false;
        }
    }
}
