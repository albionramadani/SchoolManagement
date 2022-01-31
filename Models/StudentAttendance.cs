using System;
namespace SchoolManagement.Models
{
    public class StudentAttendance
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class {get; set;}
        public int SubjectId { get; set; }
        public virtual Subject Subject {get; set;}
        public bool Status { get; set; }
        public DateTime Date { get; set; }
    }
}