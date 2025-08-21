namespace C44_G02_EF02.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");

            builder.HasKey(s => s.ID);

            builder.Property(s => s.FName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(s => s.LName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(s => s.Address)
                   .HasMaxLength(150);

            builder.Property(s => s.Age)
                   .IsRequired();

            builder.Property(s => s.DepartmentID)
                .IsRequired();

            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DepartmentID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
