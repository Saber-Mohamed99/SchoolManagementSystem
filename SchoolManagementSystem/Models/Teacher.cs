namespace SchoolManagementSystem.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        // Navigation
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }

}
