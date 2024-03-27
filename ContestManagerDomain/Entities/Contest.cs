using ContestManagerDomain.Base;

namespace ContestManagerDomain.Entities
{
    public class Contest : BaseEntity<int>
    {
        public virtual required string Name { get; set; }
        public virtual required string Description { get; set; }
        public virtual DateTime InitialContestDate { get; set; }
        public virtual DateTime FinalContestDate { get; set; }
        public virtual DateTime InitialRegistrationDate { get; set; }
        public virtual DateTime FinalRegistrationDate { get; set; }
        public virtual int MinimalTeamContestant { get; set; }
        public virtual int MaximumTeamContestant { get; set; }
        public virtual int MinimalTeamCoach { get; set; }
        public virtual int MaximumTeamCoach{ get; set; }
        public virtual byte[]? Image { get; set; }
        public virtual string? Link { get; set; }

    }
}
