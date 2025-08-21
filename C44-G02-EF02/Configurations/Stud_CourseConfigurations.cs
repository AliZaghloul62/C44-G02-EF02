namespace C44_G02_EF02.Configurations
{
    public class Stud_CourseConfigurations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.ToTable("Stud_Course");

            // Composite Primary Key
            builder.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            // Relations
            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.Stud_Courses)
                   .HasForeignKey(sc => sc.Stud_ID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.Stud_Courses)
                   .HasForeignKey(sc => sc.Course_ID)
                   .OnDelete(DeleteBehavior.Cascade);

            // Grade Property
            builder.Property(sc => sc.Grade)
                   .HasColumnType("int");

            // Check Constraint for Grade
            builder.HasCheckConstraint("CK_Stud_Course_Grade", "Grade BETWEEN 0 AND 100");
        }
    }
}
