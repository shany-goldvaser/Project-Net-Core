namespace projetErov.Core.Entities
{
    public enum LevelErov
    {
        City, Neighborhood, GoodNeighborhood
    }
    public class ErovEntity
    {
        public int Id { get; set; }
        public LevelErov Level { get; set; }
        public string BorderErov { get; set; }
        public bool YardErov { get; set; }
        public bool Status { get; set; }
        public int IdRav { get; set; }
        public string Message { get; set; }
        public PlaceEntity City { get; set; }
        public PlaceEntity TypePlace { get; set; }
    }
}
