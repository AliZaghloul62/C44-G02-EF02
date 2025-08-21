namespace C44_G02_EF02.Models
{
    public class Stud_Course
    {
        public int Stud_ID { get; set; }
        public int Course_ID { get; set; }

        [Range(0, 100, ErrorMessage = "Grade must be between 0 and 100.")]
        public int? Grade { get; set; }

        // Navigation Properties
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}
