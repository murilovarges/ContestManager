using ContestManagerDomain.Base;

namespace ContestManagerDomain.Entities
{
    public class Team : BaseEntity<int>
    {
        public virtual required Contest Contest { get; set; } 
        public virtual required string Name { get; set; }
        public virtual List<TeamContestants>? Contestants { get; set; }
    }

    public class TeamContestants : BaseEntity<int>
    {
        public virtual required Team Team { get; set; }
        public virtual required Contestant Contestant { get; set; }
        public virtual required string Role { get; set; }
    }
}
