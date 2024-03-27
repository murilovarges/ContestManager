using ContestManagerDomain.Base;

namespace ContestManagerDomain.Entities
{
    public class Contestant : BaseEntity<int>
    {
        public virtual string? Name { get; set; } 
        public virtual string? Email { get; set; } 
        public virtual string? Phone { get; set; } 
        public virtual string? Document { get; set; } 
        public virtual string? UniversityRegistrationNumber { get; set; }
        public virtual string? TshirtSize { get; set; }
        public virtual string? Gender { get; set; }
        public virtual required University? University { get; set; }
        public virtual required Course? Course { get; set; }
    }
}
