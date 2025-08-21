namespace C44_G02_EF02.Models
{
    //ID INT PK.
    // Name NVARCHAR(100) NOT NULL UNIQUE.
    public class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Course>? Courses { get; set; } // Navigation property to Courses
    }
}
