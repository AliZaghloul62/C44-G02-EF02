namespace C44_G02_EF02.Configurations
{
    public class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");

            builder.HasKey(i => i.ID);

            builder.Property(i => i.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(i => i.Salary)
                   .IsRequired()
                   .HasColumnType("decimal(10,2)");

            builder.HasCheckConstraint("CK_Instructor_Salary", "Salary > 0");

            builder.Property(i => i.HourRateBouns)
                   .HasColumnType("decimal(10,2)")
                   .HasDefaultValue(0);

            builder.HasCheckConstraint("CK_Instructor_HourRateBouns", "HourRateBouns >= 0");

            builder.Property(i => i.Address)
                   .HasMaxLength(150);


            builder.Property(i => i.Dept_ID)
                   .IsRequired();


            builder.HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                     .HasForeignKey(i => i.Dept_ID)
                     .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
