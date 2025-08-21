namespace C44_G02_EF02.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");

            builder.HasKey(c => c.ID);

            builder.Property(c => c.Duration)
                   .IsRequired();

            builder.HasCheckConstraint("CK_Topic_Duration", "Duration > 0");

            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(c => c.Name)
                   .IsUnique();

            builder.Property(c => c.Description)
                .HasMaxLength(255);
        }
    }
}
