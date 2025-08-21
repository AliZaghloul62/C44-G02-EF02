namespace C44_G02_EF02.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Top_ID { get; set; }
        public Topic Topic { get; set; } // Navigation property to Topic
        public ICollection<Stud_Course> Stud_Courses { get; set; } // Navigation property to Stud_Course
        public ICollection<Course_Inst> Course_Inst { get; set; }
    }
}
