namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? Img { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public ICollection<Result> Results { get; set; } = new List<Result>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<ParentsPhone> ParentsPhones { get; set; } = new List<ParentsPhone>();
    }
}
