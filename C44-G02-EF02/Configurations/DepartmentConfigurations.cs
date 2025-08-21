namespace C44_G02_EF02.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");

            builder.HasKey(d => d.ID);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(d => d.Name)
                   .IsUnique();

            builder.HasMany(d => d.Students)
                    .WithOne(s => s.Department)
                    .HasForeignKey(s => s.DepartmentID);

            builder.Property(d => d.HiringDate)
                   .IsRequired()
                   .HasColumnType("DATE");

            builder.HasCheckConstraint("CK_Department_HiringDate", "HiringDate <= GETDATE()");
        }
    }
}
