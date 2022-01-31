namespace SchoolManagement.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public int ClassId { get; set; }
        public virtual Class Class {get; set;}
        public string SubjectName { get; set; }
    }
}