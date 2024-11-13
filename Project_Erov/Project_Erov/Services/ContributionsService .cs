using Project_Erov.Dto;
using Project_Erov.Entities;
namespace Project_Erov.Services
{
    public class ContributionsService
    {
        readonly IDataContextContribution _dataContextContribution;

        public ContributionsService(IDataContextContribution dataContextContribution)
        {
            _dataContextContribution = dataContextContribution;
        }

        public List<Contributions> GetContributions()
        {
            var data = _dataContextContribution.LoadData();
            if (data == null)
            {
                return null;
            }
            return data.ToList();
        }
        public Contributions GetContributionsId(int id)
        {
            var data = _dataContextContribution.LoadData();
            if (data == null)
                return null;
            return data.Where(c => c.Id == id).FirstOrDefault();

        }
        public bool AddContributions(Contributions e)
        {
            var data = _dataContextContribution.LoadData();
            if (data == null)
                return false;
            data.Add(e);
            return _dataContextContribution.SaveData(data);
        }
        public bool UpdateContributions(int id, Contributions e)
        {
            var data = _dataContextContribution.LoadData();
            if (data == null)
                return false;
            var index = data.FindIndex(ev => ev.Id == id);
            if (index != -1)
            {
                data[index] = e;
            }
            return _dataContextContribution.SaveData(data);
        }
        public bool DeleteContributions(int id)
        {
            var data = _dataContextContribution.LoadData();
            if (data == null)
                return false;
            var item = data.Find(ev => ev.Id == id);
            if (item != null)
            {
                data.Remove(item);
            }
            return _dataContextContribution.SaveData(data);
        }
    }
}
