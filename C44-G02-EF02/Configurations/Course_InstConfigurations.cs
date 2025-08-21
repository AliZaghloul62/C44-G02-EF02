namespace C44_G02_EF02.Configurations
{
    public class Course_InstConfigurations : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.ToTable("Instructor_Course");

            builder.HasKey(ic => new { ic.Inst_ID, ic.Course_ID });

            builder.HasOne(ic => ic.Instructor)
                   .WithMany(i => i.Course_Inst)
                   .HasForeignKey(ic => ic.Inst_ID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ic => ic.Course)
                   .WithMany(c => c.Course_Inst)
                   .HasForeignKey(ic => ic.Course_ID)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(ic => ic.Evaluate)
                   .IsRequired(false);

            builder.HasCheckConstraint("CK_Instructor_Course_Evaluate", "Evaluate BETWEEN 1 AND 10");
        }
    }
}
