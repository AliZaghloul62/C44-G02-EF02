namespace C44_G02_EF02.Configurations
{
    public class TopicConfigurations : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.ToTable("Topics");

            builder.HasKey(t => t.ID);

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasIndex(t => t.Name)
                   .IsUnique();
            
            builder.HasMany(t => t.Courses)
                   .WithOne(c => c.Topic)
                   .HasForeignKey(c => c.Top_ID)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
