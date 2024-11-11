namespace ShanyGoldvaserProject.Entities
{   
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Tz { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public bool Permission { get; set; }
    }
}
