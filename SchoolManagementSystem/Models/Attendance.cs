namespace SchoolManagementSystem.Models
{
    public enum StatusAttend
    {
        attend,
        absent
    }
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public StatusAttend Status { get; set; }

        public int StudentId { get; set; }

        // Navigation
        public Student Student { get; set; } = null!;
    }
}
