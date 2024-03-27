using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using ContestManagerDomain.Entities;

namespace ContestManagerRepository.Mappings
{
    public class ContestMap : IEntityTypeConfiguration<Contest>
    {
        public void Configure(EntityTypeBuilder<Contest> builder)
        {
            builder.ToTable("Contest");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Description)
                .HasColumnType("varchar(1000)");

            builder.Property(prop => prop.InitialContestDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(prop => prop.FinalContestDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(prop => prop.InitialRegistrationDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(prop => prop.FinalRegistrationDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(prop => prop.MinimalTeamContestant);

            builder.Property(prop => prop.MaximumTeamContestant);
            
            builder.Property(prop => prop.MinimalTeamCoach);

            builder.Property(prop => prop.Image);
            
            builder.Property(prop => prop.Link)
                .HasColumnType("varchar(100)");

        }


    }
}
