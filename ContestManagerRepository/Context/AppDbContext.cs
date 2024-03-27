using ContestManagerDomain.Entities;
using ContestManagerRepository.Mappings;
using Microsoft.EntityFrameworkCore;

namespace ContestManagerRepository.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Contest> Contests { get; set; }
        public DbSet<Contestant> Contestants { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contest>(new ContestMap().Configure);
            modelBuilder.Entity<Contestant>(new ContestantMap().Configure);
            modelBuilder.Entity<Team>(new TeamMap().Configure);
            modelBuilder.Entity<TeamContestants>(new TeamContestantsMap().Configure);
            modelBuilder.Entity<University>(new UniversityMap().Configure);
            modelBuilder.Entity<Course>(new CourseMap().Configure);

            modelBuilder.Entity<Contest>().HasData(
                new Contest
                {
                    Id = 1,
                    Name = "VII InterIF 2024 - Final Piracicaba",
                    Description = "A maior maratona do IFSP",
                    InitialContestDate = DateTime.Now,
                    FinalContestDate = DateTime.Now,
                    InitialRegistrationDate = DateTime.Now,
                    FinalRegistrationDate = DateTime.Now
                },
                new Contest
                {
                    Id = 2,
                    Name = "VI InterIF 2023 - Final Campinas",
                    Description = "A maior maratona do IFSP",
                    InitialContestDate = DateTime.Now,
                    FinalContestDate = DateTime.Now,
                    InitialRegistrationDate = DateTime.Now,
                    FinalRegistrationDate= DateTime.Now
                }
            );
        }

    }
}
