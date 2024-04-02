namespace StudentAdminPortal.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int PermanentAddress { get; set; }
        public int PostalAddress { get; set; }
        public int StudentId { get; set; }
    }
}