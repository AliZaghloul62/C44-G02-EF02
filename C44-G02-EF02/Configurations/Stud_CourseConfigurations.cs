namespace C44_G02_EF02.Configurations
{
    public class Stud_CourseConfigurations : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.ToTable("Stud_Course");

            builder.HasKey(sc => new { sc.Stud_ID, sc.Course_ID });

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.Stud_Courses)
                   .HasForeignKey(sc => sc.Stud_ID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.Stud_Courses)
                   .HasForeignKey(sc => sc.Course_ID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(sc => sc.Grade)
                   .HasColumnType("int");

            builder.HasCheckConstraint("CK_Stud_Course_Grade", "Grade BETWEEN 0 AND 100");
        }
    }
}
