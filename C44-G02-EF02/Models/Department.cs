namespace C44_G02_EF02.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Student>? Students { get; set; } // Navigation property to Students
        public int? Ins_ID { get; set; } 
        public Instructor? HeadInstructor { get; set; } // Navigation property to the head of the department
        public ICollection<Instructor>? Instructors { get; set; } // Navigation property to Instructors
        public DateTime HiringDate { get; set; }



    }
}
