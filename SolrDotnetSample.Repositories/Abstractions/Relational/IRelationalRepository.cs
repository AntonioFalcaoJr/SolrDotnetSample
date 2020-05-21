namespace SolrDotnetSample.Repositories.Abstractions.Relational
{
    public interface IRelationalRepository<TModel, in TId> : IRepository<TModel, TId>
        where TModel : Model<TId>
        where TId : struct { }
}