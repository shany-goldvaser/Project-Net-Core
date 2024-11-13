using Project_Erov.Entities;

namespace Project_Erov.Dto
{
    public interface IDataContextContribution
    {
        public List<Contributions> LoadData();
        public bool SaveData(List<Contributions> data);
    }
}
