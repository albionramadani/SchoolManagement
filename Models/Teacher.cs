using System;

namespace SchoolManagement.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class{get; set; }
    }
}