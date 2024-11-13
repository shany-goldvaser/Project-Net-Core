namespace Project_Erov.Entities
{
    public class Contributions
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public DateTime Date { get; set; }
        public string Donor { get; set; }
        public string NameForPraying { get; set; }

        public Contributions(int id, double sum, DateTime date, string donor, string nameForPraying)
        {
            Id = id;
            Sum = sum;
            Date = date;
            Donor = donor;
            NameForPraying = nameForPraying;
        }

        public Contributions()
        {
        }
    }
}
