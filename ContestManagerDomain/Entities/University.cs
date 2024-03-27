using ContestManagerDomain.Base;

namespace ContestManagerDomain.Entities
{
    public class University : BaseEntity<int>
    {
        public virtual string Name { get; set; } = string.Empty;
        public virtual string UniversityAcronym { get; set; } = string.Empty;

    }
}
