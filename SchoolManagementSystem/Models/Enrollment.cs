namespace SchoolManagementSystem.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public bool IsCompleted { get; set; }

        public int StudentId { get; set; }
        public int LevelId { get; set; }
        public int ClassId { get; set; }

        // Navigation
        public Student Student { get; set; } = null!;
        public Level Level { get; set; } = null!;
        public ClassRoom ClassRoom { get; set; } = null!;
    }

}
