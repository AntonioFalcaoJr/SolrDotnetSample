namespace SolrDotnetSample.Repositories.Abstractions
{
    public abstract class Model<TId>
        where TId : struct
    {
        public virtual TId Id { get; set; }
    }
}