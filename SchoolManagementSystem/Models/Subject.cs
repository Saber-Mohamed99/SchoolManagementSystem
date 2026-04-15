namespace SchoolManagementSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public int Chapters { get; set; }
        public double MaxScore { get; set; }

        public int LevelId { get; set; }
        public int TeacherId { get; set; }

        // Navigation
        public Level Level { get; set; } = null!;
        public Teacher Teacher { get; set; } = null!;
        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }

}
