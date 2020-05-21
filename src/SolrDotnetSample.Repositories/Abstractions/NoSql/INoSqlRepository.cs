namespace SolrDotnetSample.Repositories.Abstractions.NoSql
{
    public interface INoSqlRepository<TModel, in TId> : IRepository<TModel, TId>
        where TModel : Model<TId>
        where TId : struct { }
}