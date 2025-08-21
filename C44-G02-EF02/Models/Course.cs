namespace C44_G02_EF02.Models
{/*
  ID INT PK.
• Duration INT NOT NULL CHECK (Duration > 0).
• Name NVARCHAR(100) NOT NULL UNIQUE.
• Description NVARCHAR(255) NULL.
• Top_ID INT FK NOT NULL → references Topic(ID).
  */
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
