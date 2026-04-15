namespace SchoolManagementSystem.Models
{
    public enum StatusResult
    {
        Success,
        Failure
    }
    public class Result

    {
        public int Id { get; set; }
        public double ObtainedDegree { get; set; }
        public StatusResult Status { get; set; }

        public int StudentId { get; set; }
        public int ExamId { get; set; }

        // Navigation
        public Student Student { get; set; } = null!;
        public Exam Exam { get; set; } = null!;
    }

}
