using Project_Erov.Entities;

namespace Project_Erov.Dto
{
    public class DataContext
    {
        public List<Contributions> ContributionsList { get; set; }
        public List<Erov> ErovList { get; set; }
        public List<Place> PlaceList { get; set; }
        public List<QuestionAnswer> QuestionAnswerList { get; set; }
        public List<User> UsersList { get; set; }

    }
}
