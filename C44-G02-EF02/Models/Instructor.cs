namespace C44_G02_EF02.Models
{
    public class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRateBouns { get; set; } = 0;
        public int Dept_ID { get; set; }
        public Department Department { get; set; } // Navigation property to Department
        public ICollection<Course_Inst> Course_Inst { get; set; }// Navigation property to Instructor_Course
    }
}
