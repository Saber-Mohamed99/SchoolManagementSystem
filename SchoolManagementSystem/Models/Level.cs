namespace SchoolManagementSystem.Models
{
    public enum TermTypes
    {
        First,
        second
    }
    public enum OrderTypes
    {
        First,
        second,
        third
    }

    public class Level
    {
        public int Id { get; set; }
        public TermTypes Term { get; set; } = TermTypes.First;
        public OrderTypes Order { get; set; } = OrderTypes.First;
        public double MinDegreeToPass { get; set; }

        // Navigation
        public ICollection<Subject> Subjects { get; set; } = new List<Subject>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }

}
