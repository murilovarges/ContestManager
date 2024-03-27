using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ContestManagerDomain.Entities;

namespace ContestManagerRepository.Mappings
{
    public class ContestantMap : IEntityTypeConfiguration<Contestant>
    {
        public void Configure(EntityTypeBuilder<Contestant> builder)
        {
            builder.ToTable("Contestant");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Email)
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Phone)
                .HasColumnType("varchar(50)");
            
            builder.Property(prop => prop.Document)
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.UniversityRegistrationNumber)
                .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Gender)
                .HasColumnType("varchar(50)");

            builder.HasOne(x => x.University)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Course);
        }
    }
}
