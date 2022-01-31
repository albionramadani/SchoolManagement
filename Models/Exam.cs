namespace SchoolManagement.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        public int TotalMarks { get; set; }
        public int OutOfMarks { get; set; }


    }
}