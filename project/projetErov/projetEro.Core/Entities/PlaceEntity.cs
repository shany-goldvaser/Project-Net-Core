namespace projetErov.Core.Entities
{
    public enum Type
    {
        City, Neighborhood, Complex
    }
    public enum Area
    {
        North, South, Center
    }
    public enum NameCity
    {
        BneyBrak, Jersulem, Elad, Tzat
    }
    public class PlaceEntity
    {
        public PlaceEntity()
        {
        }

        public int Id { get; set; }
        public NameCity Name { get; set; }

        public Type Type { get; set; }
        public Area Area { get; set; }
    }
}
