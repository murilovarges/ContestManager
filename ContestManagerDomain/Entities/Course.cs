using ContestManagerDomain.Base;

namespace ContestManagerDomain.Entities
{
    public class Course : BaseEntity<int>
    {
        public virtual required University University { get; set; }
        public virtual string? Name { get; set; }
        public virtual bool IsMediumLevel { get; set; }
    }
}
