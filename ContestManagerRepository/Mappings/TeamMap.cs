using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

using ContestManagerDomain.Entities;

namespace ContestManagerRepository.Mappings
{
    public class TeamMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(x => x.Contest);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.HasMany(prop => prop.Contestants)
                .WithOne(prop => prop.Team)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

    public class TeamContestantsMap : IEntityTypeConfiguration<TeamContestants>
    {
        public void Configure(EntityTypeBuilder<TeamContestants> builder)
        {
            builder.ToTable("TeamContestants");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(x => x.Team);
            
            builder.HasOne(x => x.Contestant);

            builder.Property(prop => prop.Role)
                .IsRequired()
                .HasColumnType("varchar(100)");
            
            builder.HasOne(prop => prop.Team)
                .WithMany(prop => prop.Contestants)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
