namespace KCrud.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public DateTime DateTimeCreated { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
