namespace poc_console_solr.Domain.Abstractions
{
    public abstract class Entity<TId>
        where TId : struct
    {
        public TId Id { get; protected set; }
        protected abstract void SetId(TId id);
    }
}