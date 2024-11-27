using projetErov.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace projectErov.Data
{
    public class DataContext
    {
        public List<ContributionsEntity> ContributionsList { get; set; }
        public List<ErovEntity> ErovList { get; set; }
        public List<PlaceEntity> PlaceList { get; set; }
        public List<QuestionAnswerEntity> QuestionAnswerList { get; set; }
        public List<UserEntity> UsersList { get; set; }

        public DataContext()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
            string jsonString = File.ReadAllText(path);
            ContributionsList = JsonSerializer.Deserialize<List<ContributionsEntity>>(jsonString);
        }

        public void SaveChanges()
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Data", "data.json");
            string jsonString = JsonSerializer.Serialize<List<ContributionsEntity>>(ContributionsList);
            File.WriteAllText(path, jsonString);
        } 
    }
}
