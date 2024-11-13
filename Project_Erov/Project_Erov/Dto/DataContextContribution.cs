using Project_Erov.Entities;
using System.Text.Json;

namespace Project_Erov.Dto
{
    public class DataContextContribution : IDataContextContribution
    {
        List<Contributions> IDataContextContribution.LoadData()
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
                string jsonString = File.ReadAllText(path);
                var AllCoins = JsonSerializer.Deserialize<List<Contributions>>(jsonString);// typeof(DataCoins)); ;
                if (AllCoins == null) 
                   { return null; }
                return AllCoins;
            }
            catch
            {
                return null;
            }
        }

        bool IDataContextContribution.SaveData(List<Contributions> data)
        {
            try
            {
                string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
                string jsonString = JsonSerializer.Serialize<List<Contributions>>(data);
                File.WriteAllText(path, jsonString);
                return true;
            }
            catch { return false; }
        }
    }
}
