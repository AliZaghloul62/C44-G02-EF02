namespace C44_G02_EF02.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        [Range(18,60)]
        public int Age { get; set; }
        public int DepartmentID { get; set; }
        public Department Department { get; set; } // Navigation property to Department
        public ICollection<Stud_Course> Stud_Courses { get; set; } // Navigation property to Stud_Course
    }
}
