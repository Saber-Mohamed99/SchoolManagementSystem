namespace SchoolManagementSystem.Models
{
    public class ParentsPhone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;

        public int StudentId { get; set; }

        // Navigation
        public Student Student { get; set; } = null!;
    }

}
