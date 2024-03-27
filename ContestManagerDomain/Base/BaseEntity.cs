namespace ContestManagerDomain.Base
{
    public abstract partial class BaseEntity<TId> 
    {
        public virtual TId Id { get; set; }
    }
}
