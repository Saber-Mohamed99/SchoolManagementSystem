namespace SchoolManagementSystem.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public double MinDegree { get; set; }
        public double MaxDegree { get; set; }

        public int SubjectId { get; set; }
        public int TeacherId { get; set; }

        // Navigation
        public Subject Subject { get; set; } = null!;
        public Teacher Teacher { get; set; } = null!;
        public ICollection<Result> Results { get; set; } = new List<Result>();
    }

}
