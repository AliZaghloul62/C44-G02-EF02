namespace C44_G02_EF02.Models
{
    public class Course_Inst
    {
        public int Inst_ID { get; set; }
        public int Course_ID { get; set; }
        public int? Evaluate { get; set; }

        // Navigation properties
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}
