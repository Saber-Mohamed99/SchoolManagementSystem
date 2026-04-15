namespace SchoolManagementSystem.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public string Day { get; set; } = string.Empty;
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        // Navigation
        public ClassRoom ClassRoom { get; set; } = null!;
        public Subject Subject { get; set; } = null!;
        public Teacher Teacher { get; set; } = null!;
    }

}
