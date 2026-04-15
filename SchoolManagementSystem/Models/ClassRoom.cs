namespace SchoolManagementSystem.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // Navigation
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

}
